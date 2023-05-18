using AutoMapper;
using Dji.Cloud.Application.Abstracts.Constants;
using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Application.Extensions;
using Dji.Cloud.Domain.Manage;
using Dji.Cloud.Domain.Oss;
using Dji.Cloud.Domain.Redis;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Dji.Cloud.Infrastructure.Abstracts.Interfaces;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Globalization;

namespace Dji.Cloud.Application.Services.Manage;

public class DeviceFirmwareService : IDeviceFirmwareService
{
    private readonly OssConfiguration _ossConfiguration;

    // TODO: Moved to CQRS Query
    private readonly IDeviceFirmwareRepository _deviceFirmwareRepository;
    private readonly IGenericRepository<DeviceFirmwareEntity> _deviceFirmwareGenericRepository;

    private readonly IDeviceService _deviceService;
    private readonly IFirmwareModelService _firmwareModelService;

    private readonly IMapper _mapper;
    private readonly ILogger<DeviceFirmwareService> _logger;

    public DeviceFirmwareService(IOptions<OssConfiguration> ossConfigurationOptions,
                                 IDeviceFirmwareRepository deviceFirmwareRepository,
                                 IGenericRepository<DeviceFirmwareEntity> deviceFirmwareGenericRepository,
                                 IDeviceService deviceService,
                                 IFirmwareModelService firmwareModelService,
                                 IMapper mapper, 
                                 ILogger<DeviceFirmwareService> logger)
    {
        _ossConfiguration = ossConfigurationOptions.Value;

        _deviceFirmwareRepository = deviceFirmwareRepository;
        _deviceFirmwareGenericRepository = deviceFirmwareGenericRepository;
        
        _deviceService = deviceService;
        _firmwareModelService = firmwareModelService;

        _mapper = mapper;
        _logger = logger;
    }

    //    @Autowired
    //    private IDeviceFirmwareMapper mapper;

    //    @Autowired
    //    private MessageSenderServiceImpl messageSenderService;

    //    @Autowired
    //    private ObjectMapper objectMapper;

    //    @Autowired
    //    private SendMessageServiceImpl webSocketMessageService;

    //    @Autowired
    //    private IWebSocketManageService webSocketManageService;

    //    @Autowired
    //    private OssServiceContext ossServiceContext;

    //@Override
    //@ServiceActivator(inputChannel = ChannelName.INBOUND_EVENTS_OTA_PROGRESS, outputChannel = ChannelName.OUTBOUND)
    //    public void handleOtaProgress(CommonTopicReceiver receiver, MessageHeaders headers)
    //{
    //    String topic = headers.get(MqttHeaders.RECEIVED_TOPIC).toString();
    //    String sn = topic.substring((TopicConst.THING_MODEL_PRE + TopicConst.PRODUCT).length(),
    //            topic.indexOf(TopicConst.EVENTS_SUF));

    //    EventsReceiver<EventsOutputReceiver> eventsReceiver = objectMapper.convertValue(receiver.getData(),
    //            new TypeReference<EventsReceiver<EventsOutputReceiver>>() { });
    //    eventsReceiver.setBid(receiver.getBid());

    //    EventsOutputReceiver output = eventsReceiver.getOutput();
    //    log.info("SN: {}, {} ===> Upgrading progress: {}",
    //            sn, receiver.getMethod(), output.getProgress().toString());

    //    if (eventsReceiver.getResult() != ResponseResult.CODE_SUCCESS)
    //    {
    //        log.error("SN: {}, {} ===> Error code: {}", sn, receiver.getMethod(), eventsReceiver.getResult());
    //    }

    //    DeviceDTO device = (DeviceDTO)RedisOpsUtils.get(RedisConst.DEVICE_ONLINE_PREFIX + sn);
    //    String childDeviceSn = device.getChildDeviceSn();
    //    boolean upgrade = RedisOpsUtils.getExpire(RedisConst.FIRMWARE_UPGRADING_PREFIX + sn) > 0;
    //    boolean childUpgrade = RedisOpsUtils.getExpire(RedisConst.FIRMWARE_UPGRADING_PREFIX + childDeviceSn) > 0;

    //    // Determine whether it is the ending state, delete the update state key in redis after the job ends.
    //    EventsResultStatusEnum statusEnum = EventsResultStatusEnum.find(output.getStatus());
    //    Collection<ConcurrentWebSocketSession> sessions = webSocketManageService.getValueWithWorkspaceAndUserType(
    //            device.getWorkspaceId(), UserTypeEnum.WEB.getVal());
    //    CustomWebSocketMessage<Object> build = CustomWebSocketMessage.builder()
    //            .data(eventsReceiver)
    //            .timestamp(System.currentTimeMillis())
    //            .bizCode(receiver.getMethod())
    //            .build();
    //    if (upgrade)
    //    {
    //        if (statusEnum.getEnd())
    //        {
    //            // Delete the cache after the update is complete.
    //            RedisOpsUtils.del(RedisConst.FIRMWARE_UPGRADING_PREFIX + sn);
    //        }
    //        else
    //        {
    //            // Update the update progress of the dock in redis.
    //            RedisOpsUtils.setWithExpire(
    //                    RedisConst.FIRMWARE_UPGRADING_PREFIX + sn, output.getProgress().getPercent(),
    //                    RedisConst.DEVICE_ALIVE_SECOND * RedisConst.DEVICE_ALIVE_SECOND);
    //        }
    //        eventsReceiver.setSn(sn);
    //        webSocketMessageService.sendBatch(sessions, build);
    //    }
    //    if (childUpgrade)
    //    {
    //        if (!StringUtils.hasText(eventsReceiver.getSn()))
    //        {
    //            eventsReceiver.setSn(childDeviceSn);
    //            webSocketMessageService.sendBatch(sessions, build);
    //        }
    //        if (statusEnum.getEnd())
    //        {
    //            RedisOpsUtils.del(RedisConst.FIRMWARE_UPGRADING_PREFIX + childDeviceSn);
    //        }
    //        else
    //        {
    //            // Update the update progress of the drone in redis.
    //            RedisOpsUtils.setWithExpire(
    //                    RedisConst.FIRMWARE_UPGRADING_PREFIX + childDeviceSn, output.getProgress().getPercent(),
    //                    RedisConst.DEVICE_ALIVE_SECOND * RedisConst.DEVICE_ALIVE_SECOND);
    //        }
    //    }

    //    if (receiver.getNeedReply() != null && receiver.getNeedReply() == 1)
    //    {
    //        String replyTopic = headers.get(MqttHeaders.RECEIVED_TOPIC) + TopicConst._REPLY_SUF;
    //        messageSenderService.publish(replyTopic,
    //                CommonTopicResponse.builder()
    //                        .tid(receiver.getTid())
    //                        .bid(receiver.getBid())
    //                        .method(receiver.getMethod())
    //                        .timestamp(System.currentTimeMillis())
    //                        .data(RequestsReply.success())
    //                        .build());
    //    }
    //}

    /// <summary>
    /// Parse firmware file information
    /// </summary>
    /// <param name="stream">the stream</param>
    /// <returns>the device firmware</returns>
    public async Task<DeviceFirmware> VerifyFirmwareFileAsync(Stream stream)
    {
        DeviceFirmware? result = null;

        using (var zipInputStream = new ZipInputStream(stream))
        {
            var nextEntry = zipInputStream.GetNextEntry();
            while (nextEntry != null)
            {
                var configName = nextEntry.Name;
                if (!configName.Contains(Path.DirectorySeparatorChar) && configName.EndsWith($"{FirmwareFileProperties.FirmwareConfigFileSuffix}{FirmwareFileProperties.FIRMWARE_SIG_FILE_SUFFIX}"))
                {
                    var fileNameArray = configName.Split(FirmwareFileProperties.FIRMWARE_FILE_DELIMITER);
                    var date = fileNameArray[FirmwareFileProperties.FILENAME_RELEASE_DATE_INDEX];
                    
                    var index = date.IndexOf(".");
                    if (index != -1)
                    {
                        date = date.Substring(0, index);
                    }

                    result = new DeviceFirmware { 
                        ReleasedTime = DateTime.ParseExact(date, FirmwareFileProperties.FILENAME_RELEASE_DATE_FORMAT, CultureInfo.CurrentCulture),
                        ProductVersion = fileNameArray[FirmwareFileProperties.FILENAME_VERSION_INDEX].Substring(1)    
                    };
                }
                nextEntry = zipInputStream.GetNextEntry();
            }
        }

        return await Task.FromResult(result!);
    }
     
    /// <summary>
    /// Checks for file existence based on md5.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="fileMd5">the file Md5</param>
    /// <returns>the status</returns>
    public async Task<bool> CheckFileExistsAsync(string workspaceId, string fileMd5)
    {
        var key = $"{RedisConst.FileUploadingPrefix}{workspaceId}{fileMd5}";

        var count = await _deviceFirmwareGenericRepository.GetCountAsync(entity => entity.WorkspaceId == workspaceId && entity.FileMd5 == fileMd5);

        return RedisOpsUtils.ContainsKey(key) || count > 0;
    }

    /// <summary>
    /// Query firmware version information by page.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="request">the request</param>
    /// <returns>the device's firmwares</returns>
    public async Task<PaginationResponse<DeviceFirmware>> GetFirmwaresAsync(string workspaceId, DeviceFirmwareQueryRequest request)
    {
        _logger.LogInformation($"{nameof(GetFirmwareAsync)} called with Workspace Id: {workspaceId}.");

        var deviceFirmwareEntities = await _deviceFirmwareRepository.GetDeviceFirmwaresAsync(workspaceId, request.DeviceName!, request.ProductVersion!, 
                                                                                             request.Page, request.PageSize);

        var deviceFirmwares = _mapper.Map<IEnumerable<DeviceFirmware>>(deviceFirmwareEntities);

        var total = await _deviceFirmwareGenericRepository.GetCountAsync();

        var response = new PaginationResponse<DeviceFirmware> {  
            List = deviceFirmwares,
            Pagination = new Pagination {
                Page = request.Page,
                PageSize = request.PageSize,
                Total = total
            }
        };

        _logger.LogInformation($"{nameof(GetFirmwaresAsync)} was getting firmwares with Workspace Id: {workspaceId}.");

        return response;
    }

    /// <summary>
    /// Get the firmware information that the device needs to update.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="upgrades">upgrades</param>
    /// <returns></returns>
    public async Task<IEnumerable<DeviceOtaCreateRequest>> GetDeviceOtaFirmwareAsync(string workspaceId, IEnumerable<DeviceFirmwareUpgrade> upgrades)
    {
        _logger.LogInformation($"{nameof(GetDeviceOtaFirmwareAsync)} was called with Workspace Id: {workspaceId}.");

        var result = new List<DeviceOtaCreateRequest>();

        foreach (var upgrade in upgrades)
        {
            var isExists = await _deviceService.CheckDeviceOnlineAsync(upgrade.SerialNumber!);
            if (!isExists)
            {
                var message = $"Device with Device Name: {upgrade.DeviceName} is offline.";
                
                var exception = new ArgumentException(message);
                _logger.LogError(exception, message);
                
                throw exception;
            }

            var deviceFirmware = await GetFirmwareAsync(workspaceId, upgrade.DeviceName!, upgrade.ProductVersion!);
            if (deviceFirmware == null)
            {
                var message = "This firmware version does not exist or is not available.";

                var exception = new ArgumentException(message);
                _logger.LogError(exception, message);

                throw exception;
            }

            var deviceOtaCreateRequest = _mapper.Map<DeviceOtaCreateRequest>(deviceFirmware);
            deviceOtaCreateRequest.SerialNumber = upgrade.SerialNumber;
            deviceOtaCreateRequest.FirmwareUpgradeType = upgrade.FirmwareUpgradeType;

            // TODO:
            // fileUrl(ossServiceContext.getObjectUrl(OssConfiguration.bucket, dto.getObjectKey()).toString())

            result.Add(deviceOtaCreateRequest);
        }

        _logger.LogInformation($"{nameof(GetDeviceOtaFirmwareAsync)} was getting list of device's requests successfully with Workspace Id: {workspaceId}.");

        return result;
    }

    /// <summary>
    /// Query specific firmware information based on the device model and firmware version.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="deviceName">device name</param>
    /// <param name="version">version</param>
    /// <returns>device firmware note</returns>
    public async Task<DeviceFirmware> GetFirmwareAsync(string workspaceId, string deviceName, string version)
    {
        _logger.LogInformation($"{nameof(GetFirmwareAsync)} was called with params: Workspace Id: {workspaceId}, Device Name: {deviceName}, Version: {version}.");

        var deviceFirmwareEntity = await _deviceFirmwareGenericRepository.FirstOrDefaultAsync(entity => entity.WorkspaceId == workspaceId &&
                                                                                                 EF.Functions.Like(entity.FirmwareVersion!, version) &&
                                                                                                 EF.Functions.Like(entity.DeviceName!, deviceName) &&
                                                                                                 entity.Status);
        if (deviceFirmwareEntity == null)
        {
            _logger.LogError($"Device Firmware with params: Workspace Id: {workspaceId} and Device Name: {deviceName} and Version: {version}.");
        }

        var deviceFirmware = _mapper.Map<DeviceFirmware>(deviceFirmwareEntity);

        _logger.LogInformation($"{nameof(GetFirmwareAsync)} was getting successfully Device Firmware with params: Workspace Id: {workspaceId}, Device Name: {deviceName}, Version: {version}.");

        return deviceFirmware;
    }

    /// <summary>
    /// Get the latest firmware release note for this device model.
    /// </summary>
    /// <param name="deviceName">device name</param>
    /// <returns>device firmware note</returns>
    public async Task<DeviceFirmwareNote> GetLatestFirmwareReleaseNoteAsync(string deviceName)
    {
        _logger.LogInformation($"{nameof(GetLatestFirmwareReleaseNoteAsync)} was called with Device Name: {deviceName}.");

        var deviceFirmwareEntity = await _deviceFirmwareRepository.GetDeviceFirmwareAsync(deviceName);
        if (deviceFirmwareEntity == null)
        {
            _logger.LogError($"Device Firmware with params: Device Name: {deviceName} is not found.");
        }

        var result = _mapper.Map<DeviceFirmwareNote>(deviceFirmwareEntity);

        _logger.LogInformation($"{nameof(GetLatestFirmwareReleaseNoteAsync)} was getting Device Firmware Note successfully with Device Name: {deviceName}.");

        return result;
    }

    /// <summary>
    /// Import firmware file for device upgrades.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="userName">the user name</param>
    /// <param name="request">the request</param>
    /// <param name="fileName">the file name</param>
    /// <param name="stream">the stream</param>
    /// <returns></returns>
    public async Task ImportFirmwareFileAsync(string workspaceId, string userName, DeviceFirmwareUpdateRequest request, string fileName, Stream stream)
    {
        _logger.LogInformation($"{ImportFirmwareFileAsync} called with params: Workspace Id: {workspaceId} and User Name: {userName}.");

        var key = $"{RedisConst.FileUploadingPrefix}{workspaceId}";

        try
        {    
            var existKey = $"{key}{fileName}";

            if (RedisOpsUtils.GetExpire(existKey) > 0)
            {
                var message = "Please try again later.";

                var exception = new ArgumentException(message);
                _logger.LogError(exception, message);

                throw exception;
            }

            RedisOpsUtils.SetWithExpire(existKey, true, RedisConst.DeviceAliveSecond);

            var size = stream.Length;
            var md5 = stream.ToMD5Hash();
            key += md5;

            var isExists = await CheckFileExistsAsync(workspaceId, md5);
            if (isExists)
            {
                var message = "The file already exists.";

                _logger.LogError(message);
                throw new ArgumentException(message);
            }

            RedisOpsUtils.Set(key, DateTime.UtcNow.Millisecond);

            var deviceFirmware = await VerifyFirmwareFileAsync(stream);
            if (deviceFirmware == null)
            {
                var message = "The file format is incorrect.";

                _logger.LogError(message);
                throw new ArgumentException(message);
            }

            var firmwareId = Guid.NewGuid().ToString();
            var objectKey = $"{_ossConfiguration.ObjectDirPrefix}{Path.DirectorySeparatorChar}{firmwareId}{FirmwareFileProperties.FirmwareFileSuffix}";

            // TODO:
            // ossServiceContext.putObject(OssConfiguration.bucket, objectKey, file.getInputStream());

            _logger.LogInformation($"Upload Success: {fileName}.");

            var firmware = new DeviceFirmware
            {
                DeviceName = request.DeviceName,
                ReleaseNote = request.ReleaseNote,
                FirmwareStatus = request.FirmwareStatus,
                FileMd5 = md5,
                ObjectKey = objectKey,
                FileName = fileName,
                WorkspaceId = workspaceId,
                UserName = userName,
                FileSize = size,
                ProductVersion = deviceFirmware.ProductVersion,
                ReleasedTime = deviceFirmware.ReleasedTime,
                FirmwareId = firmwareId
            };

            await SaveFirmwareInfoAsync(firmware, request.DeviceName!);
        }
        catch (Exception exc)
        {
            _logger.LogError(exc.Message);
        }
        finally
        {
            RedisOpsUtils.Delete(key);
        }

        _logger.LogInformation($"{ImportFirmwareFileAsync} saved Firmeware successfully with params: Workspace Id: {workspaceId} and User Name: {userName}.");
    }

    //@Override
    //    public void importFirmwareFile(String workspaceId, String creator, DeviceFirmwareUploadParam param, MultipartFile file)
    //{
    //    String key = RedisConst.FILE_UPLOADING_PREFIX + workspaceId;
    //    String existKey = key + file.getOriginalFilename();
    //    if (RedisOpsUtils.getExpire(existKey) > 0)
    //    {
    //        throw new RuntimeException("Please try again later.");
    //    }
    //    RedisOpsUtils.setWithExpire(existKey, true, RedisConst.DEVICE_ALIVE_SECOND);
    //    try (InputStream is = file.getInputStream()) {
    //        long size = is.available();
    //        String md5 = DigestUtils.md5DigestAsHex(is);
    //        key += md5;
    //        boolean exist = checkFileExist(workspaceId, md5);
    //        if (exist)
    //        {
    //            throw new RuntimeException("The file already exists.");
    //        }
    //        RedisOpsUtils.set(key, System.currentTimeMillis());
    //        Optional<DeviceFirmwareDTO> firmwareOpt = verifyFirmwareFile(file);
    //        if (firmwareOpt.isEmpty())
    //        {
    //            throw new RuntimeException("The file format is incorrect.");
    //        }

    //        String firmwareId = UUID.randomUUID().toString();
    //        String objectKey = OssConfiguration.objectDirPrefix + File.separator + firmwareId + FirmwareFileProperties.FIRMWARE_FILE_SUFFIX;

    //        ossServiceContext.putObject(OssConfiguration.bucket, objectKey, file.getInputStream());
    //        log.info("upload success. {}", file.getOriginalFilename());
    //        DeviceFirmwareDTO firmware = DeviceFirmwareDTO.builder()
    //                .releaseNote(param.getReleaseNote())
    //                .firmwareStatus(param.getStatus())
    //                .fileMd5(md5)
    //                .objectKey(objectKey)
    //                .fileName(file.getOriginalFilename())
    //                .workspaceId(workspaceId)
    //                .username(creator)
    //                .fileSize(size)
    //                .productVersion(firmwareOpt.get().getProductVersion())
    //                .releasedTime(firmwareOpt.get().getReleasedTime())
    //                .firmwareId(firmwareId)
    //                .build();

    //        saveFirmwareInfo(firmware, param.getDeviceName());
    //    } catch (IOException e)
    //    {
    //        e.printStackTrace();
    //    }
    //    finally
    //    {
    //        RedisOpsUtils.del(key);
    //    }
    //}

    /// <summary>
    /// Save the file information of the firmware.
    /// </summary>
    /// <param name="deviceFirmware">the device firmware</param>
    /// <param name="deviceNames">the device names</param>
    /// <returns></returns>
    public async Task SaveFirmwareInfoAsync(DeviceFirmware deviceFirmware, IEnumerable<string> deviceNames)
    {
        var deviceFirmwareEntity = _mapper.Map<DeviceDictionaryEntity>(deviceFirmware);

        // TODO
        var firmwareModel = new FirmwareModel { FirmwareId = deviceFirmware.FirmwareId, DeviceNames = deviceNames };

        await _firmwareModelService.SaveFirmwareDeviceNameAsync(firmwareModel);

        //await _firmwareModelService.SaveFirmwareDeviceNameAsync(new FirmwareModel { FirmwareId = deviceFirmware.FirmwareId, DeviceNames = deviceNames });

    }

    //@Override
    //    public void saveFirmwareInfo(DeviceFirmwareDTO firmware, List<String> deviceNames)
    //{
    //    DeviceFirmwareEntity entity = dto2Entity(firmware);
    //    mapper.insert(entity);
    //    firmwareModelService.saveFirmwareDeviceName(
    //            FirmwareModelDTO.builder().firmwareId(entity.getFirmwareId()).deviceNames(deviceNames).build());
    //}

    /// <summary>
    /// Update the file information of the firmware.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="firmwareId">the firmware id</param>
    /// <param name="request">the request</param>
    /// <returns></returns>
    public async Task UpdateFirmwareInfoAsync(string workspaceId, string firmwareId, DeviceFirmwareUpdateRequest request)
    {
        _logger.LogInformation($"{nameof(UpdateFirmwareInfoAsync)} called with parameters: Workspace Id: {workspaceId}, Firmware Id: {firmwareId}.");

        var deviceFirmware = _mapper.Map<DeviceFirmware>(request);

        var deviceFirmwareEntity = _mapper.Map<DeviceFirmwareEntity>(deviceFirmware);

        var targetDeviceFirmwareEntity = await _deviceFirmwareGenericRepository.FirstOrDefaultAsync(x => x.FirmwareId == firmwareId && x.WorkspaceId == workspaceId);
        if (targetDeviceFirmwareEntity == null)
        {
            var message = $"Device Firmware with Workspace Id: {workspaceId} and Firmware Id: {firmwareId}";
            _logger.LogError(message);
        }

        if (targetDeviceFirmwareEntity != null)
        {
            targetDeviceFirmwareEntity = _mapper.Map<DeviceFirmwareEntity>(deviceFirmwareEntity);
            targetDeviceFirmwareEntity.UpdateTime = DateTime.UtcNow.Ticks;
            
            await _deviceFirmwareGenericRepository.UpdateAsync(targetDeviceFirmwareEntity);
        }

        _logger.LogInformation($"{nameof(UpdateFirmwareInfoAsync)} was updated successfully with parameters: Workspace Id: {workspaceId}, Firmware Id: {firmwareId}.");
    }
}
