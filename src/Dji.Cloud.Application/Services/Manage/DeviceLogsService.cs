using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain;
using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Services.Manage;

public class DeviceLogsService : IDeviceLogsService
{
    //    private static final String LOGS_FILE_SUFFIX = ".tar";

    //    @Autowired
    //    private IDeviceLogsMapper mapper;

    //    @Autowired
    //    private ITopologyService topologyService;

    //    @Autowired
    //    private IMessageSenderService messageSenderService;

    //    @Autowired
    //    private ILogsFileService logsFileService;

    //    @Autowired
    //    private RedisOpsUtils redisOpsUtils;

    //    @Autowired
    //    private IStorageService storageService;

    //    @Autowired
    //    private ObjectMapper objectMapper;

    //    @Autowired
    //    private ISendMessageService webSocketMessageService;

    //    @Autowired
    //    private IWebSocketManageService webSocketManageService;

    //    @Override
    //    public PaginationData<DeviceLogsDTO> getUploadedLogs(String deviceSn, DeviceLogsQueryParam param)
    //    {
    //        LambdaQueryWrapper<DeviceLogsEntity> queryWrapper = new LambdaQueryWrapper<DeviceLogsEntity>()
    //                .eq(DeviceLogsEntity::getDeviceSn, deviceSn)
    //                .between(Objects.nonNull(param.getBeginTime()) && Objects.nonNull(param.getEndTime()),
    //                        DeviceLogsEntity::getCreateTime, param.getBeginTime(), param.getEndTime())
    //                .eq(Objects.nonNull(param.getStatus()), DeviceLogsEntity::getStatus, param.getStatus())
    //                .like(StringUtils.hasText(param.getLogsInformation()),
    //                        DeviceLogsEntity::getLogsInfo, param.getLogsInformation())
    //                .orderByDesc(DeviceLogsEntity::getCreateTime);

    //        Page<DeviceLogsEntity> pagination = mapper.selectPage(new Page<>(param.getPage(), param.getPageSize()), queryWrapper);

    //        List<DeviceLogsDTO> deviceLogsList = pagination.getRecords().stream().map(this::entity2Dto).collect(Collectors.toList());

    //        return new PaginationData<DeviceLogsDTO>(deviceLogsList, new Pagination(pagination));
    //    }

    //    @Override
    //    public String insertDeviceLogs(String bid, String username, String deviceSn, DeviceLogsCreateParam param)
    //{
    //    DeviceLogsEntity entity = DeviceLogsEntity.builder()
    //            .deviceSn(deviceSn)
    //            .username(username)
    //            .happenTime(param.getHappenTime())
    //            .logsInfo(Objects.requireNonNullElse(param.getLogsInformation(), ""))
    //            .logsId(bid)
    //            .status(DeviceLogsStatusEnum.UPLOADING.getVal())
    //            .build();
    //    boolean insert = mapper.insert(entity) > 0;
    //    if (!insert)
    //    {
    //        return "";
    //    }
    //    for (LogsFileUpload file : param.getFiles()) {
    //    insert = logsFileService.insertFile(file, entity.getLogsId());
    //    if (!insert)
    //    {
    //        return "";
    //    }
    //}

    //return bid;
    //    }


    //    @Override
    //    public ResponseResult pushFileUpload(String username, String deviceSn, DeviceLogsCreateParam param)
    //{
    //    StsCredentialsDTO stsCredentials = storageService.getSTSCredentials();
    //    LogsUploadCredentialsDTO credentialsDTO = new LogsUploadCredentialsDTO(stsCredentials);
    //    // Set the storage name of the file.
    //    List<LogsFileUpload> files = param.getFiles();
    //    files.forEach(file->file.setObjectKey(credentialsDTO.getObjectKeyPrefix() + "/" + UUID.randomUUID().toString() + LOGS_FILE_SUFFIX));

    //    credentialsDTO.setParams(LogsFileUploadList.builder().files(files).build());
    //    String bid = UUID.randomUUID().toString();
    //    ServiceReply reply = messageSenderService.publishWithReply(
    //            TopicConst.THING_MODEL_PRE + TopicConst.PRODUCT + deviceSn + TopicConst.SERVICES_SUF,
    //            CommonTopicResponse.< LogsUploadCredentialsDTO > builder()
    //                    .tid(UUID.randomUUID().toString())
    //                    .bid(bid)
    //                    .timestamp(System.currentTimeMillis())
    //                    .method(LogsFileMethodEnum.FILE_UPLOAD_START.getMethod())
    //                    .data(credentialsDTO)
    //                    .build());

    //    if (ResponseResult.CODE_SUCCESS != reply.getResult())
    //    {
    //        return ResponseResult.error(String.valueOf(reply.getResult()));
    //    }

    //    String logsId = this.insertDeviceLogs(bid, username, deviceSn, param);
    //    if (!bid.equals(logsId))
    //    {
    //        return ResponseResult.error("Database insert failed.");
    //    }

    //    // Save the status of the log upload.
    //    redisOpsUtils.hashSet(RedisConst.LOGS_FILE_PREFIX + deviceSn, bid, LogsOutputProgressDTO.builder().logsId(logsId).build());
    //    return ResponseResult.success();

    //}

    //@Override
    //    public ResponseResult pushUpdateFile(String deviceSn, LogsFileUpdateParam param)
    //{
    //    LogsFileUpdateMethodEnum method = LogsFileUpdateMethodEnum.find(param.getStatus());
    //    if (LogsFileUpdateMethodEnum.UNKNOWN == method)
    //    {
    //        return ResponseResult.error("Illegal param");
    //    }
    //    String topic = TopicConst.THING_MODEL_PRE + TopicConst.PRODUCT + deviceSn + TopicConst.SERVICES_SUF;
    //    String bid = UUID.randomUUID().toString();
    //    ServiceReply reply = messageSenderService.publishWithReply(topic,
    //            CommonTopicResponse.< LogsFileUpdateParam > builder()
    //                    .tid(UUID.randomUUID().toString())
    //                    .bid(bid)
    //                    .timestamp(System.currentTimeMillis())
    //                    .method(LogsFileMethodEnum.FILE_UPLOAD_UPDATE.getMethod())
    //                    .data(param)
    //                    .build());

    //    if (ResponseResult.CODE_SUCCESS != reply.getResult())
    //    {
    //        return ResponseResult.error("Error Code : " + reply.getResult());
    //    }

    //    return ResponseResult.success();
    //}

    //@Override
    //    public void deleteLogs(String deviceSn, String logsId)
    //{
    //    mapper.delete(new LambdaUpdateWrapper<DeviceLogsEntity>()
    //            .eq(DeviceLogsEntity::getLogsId, logsId).eq(DeviceLogsEntity::getDeviceSn, deviceSn));
    //    logsFileService.deleteFileByLogsId(logsId);
    //}

    //@ServiceActivator(inputChannel = ChannelName.INBOUND_EVENTS_FILE_UPLOAD_PROGRESS, outputChannel = ChannelName.OUTBOUND)
    //    @Override
    //    public void handleFileUploadProgress(CommonTopicReceiver receiver, MessageHeaders headers)
    //{
    //    String topic = headers.get(MqttHeaders.RECEIVED_TOPIC).toString();
    //    String sn = topic.substring((TopicConst.THING_MODEL_PRE + TopicConst.PRODUCT).length(),
    //            topic.indexOf(TopicConst.EVENTS_SUF));

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

    //    EventsReceiver<OutputLogsProgressReceiver> eventsReceiver = objectMapper.convertValue(receiver.getData(),
    //            new TypeReference<EventsReceiver<OutputLogsProgressReceiver>>() { });

    //    EventsReceiver<LogsOutputProgressDTO> webSocketData = new EventsReceiver<>();
    //    webSocketData.setBid(receiver.getBid());
    //    webSocketData.setSn(sn);

    //    DeviceDTO device = (DeviceDTO)redisOpsUtils.get(RedisConst.DEVICE_ONLINE_PREFIX + sn);

    //    try
    //    {
    //        OutputLogsProgressReceiver output = eventsReceiver.getOutput();
    //        EventsResultStatusEnum statusEnum = EventsResultStatusEnum.find(output.getStatus());
    //        log.info("Logs upload progress: {}", output.toString());

    //        String key = RedisConst.LOGS_FILE_PREFIX + sn;
    //        LogsOutputProgressDTO progress;
    //        boolean exist = redisOpsUtils.checkExist(key);
    //        if (!exist && !statusEnum.getEnd())
    //        {
    //            progress = LogsOutputProgressDTO.builder().logsId(receiver.getBid()).build();
    //            redisOpsUtils.hashSet(key, receiver.getBid(), progress);
    //        }
    //        else if (exist)
    //        {
    //            progress = (LogsOutputProgressDTO)redisOpsUtils.hashGet(key, receiver.getBid());
    //        }
    //        else
    //        {
    //            progress = LogsOutputProgressDTO.builder().build();
    //        }
    //        progress.setStatus(output.getStatus());

    //        // If the logs file is empty, delete the cache of this task.
    //        List<LogsExtFileReceiver> fileReceivers = output.getExt().getFiles();
    //        if (CollectionUtils.isEmpty(fileReceivers))
    //        {
    //            redisOpsUtils.del(RedisConst.LOGS_FILE_PREFIX + sn);
    //        }

    //        // refresh cache.
    //        List<LogsProgressDTO> fileProgressList = new ArrayList<>();
    //        fileReceivers.forEach(file-> {
    //            LogsProgressReceiver logsProgress = file.getProgress();
    //            if (!StringUtils.hasText(file.getDeviceSn()))
    //            {
    //                if (String.valueOf(DeviceDomainEnum.DOCK.getVal()).equals(file.getDeviceModelDomain()))
    //                {
    //                    file.setDeviceSn(sn);
    //                }
    //                else if (String.valueOf(DeviceDomainEnum.SUB_DEVICE.getVal()).equals(file.getDeviceModelDomain()))
    //                {
    //                    file.setDeviceSn(device.getChildDeviceSn());
    //                }
    //            }

    //            fileProgressList.add(LogsProgressDTO.builder()
    //                    .deviceSn(file.getDeviceSn())
    //                    .deviceModelDomain(file.getDeviceModelDomain())
    //                    .result(logsProgress.getResult())
    //            .status(logsProgress.getStatus())
    //                    .uploadRate(logsProgress.getUploadRate())
    //                    .progress(((logsProgress.getCurrentStep() - 1) * 100 + logsProgress.getProgress()) / logsProgress.getTotalStep())
    //                    .build());
    //        });
    //progress.setFiles(fileProgressList);
    //webSocketData.setOutput(progress);
    //redisOpsUtils.hashSet(RedisConst.LOGS_FILE_PREFIX + sn, receiver.getBid(), progress);
    //// Delete the cache at the end of the task.
    //if (statusEnum.getEnd())
    //{
    //    redisOpsUtils.del(RedisConst.LOGS_FILE_PREFIX + sn);
    //    this.updateLogsStatus(receiver.getBid(), DeviceLogsStatusEnum.find(statusEnum).getVal());

    //    fileReceivers.forEach(file->logsFileService.updateFile(receiver.getBid(), file));
    //}
    //        } catch (NullPointerException e) {
    //    this.updateLogsStatus(receiver.getBid(), DeviceLogsStatusEnum.FAILED.getVal());

    //    redisOpsUtils.del(RedisConst.LOGS_FILE_PREFIX + sn);
    //}

    //webSocketMessageService.sendBatch(
    //        webSocketManageService.getValueWithWorkspaceAndUserType(
    //                device.getWorkspaceId(), UserTypeEnum.WEB.getVal()),
    //        CustomWebSocketMessage.builder()
    //                .data(webSocketData)
    //                .timestamp(System.currentTimeMillis())
    //                .bizCode(receiver.getMethod())
    //                .build());

    //    }

    //    @Override
    //    public void updateLogsStatus(String logsId, Integer value)
    //{

    //    mapper.update(DeviceLogsEntity.builder().status(value).build(),
    //            new LambdaUpdateWrapper<DeviceLogsEntity>().eq(DeviceLogsEntity::getLogsId, logsId));
    //    if (DeviceLogsStatusEnum.DONE.getVal() == value)
    //    {
    //        logsFileService.updateFileUploadStatus(logsId, true);
    //    }
    //}

    //@Override
    //    public URL getLogsFileUrl(String logsId, String fileId)
    //{
    //    return logsFileService.getLogsFileUrl(logsId, fileId);
    //}

    //private DeviceLogsDTO entity2Dto(DeviceLogsEntity entity)
    //{
    //    if (Objects.isNull(entity))
    //    {
    //        return null;
    //    }
    //    String key = RedisConst.LOGS_FILE_PREFIX + entity.getDeviceSn();
    //    LogsOutputProgressDTO progress = new LogsOutputProgressDTO();
    //    if (redisOpsUtils.hashCheck(key, entity.getLogsId()))
    //    {
    //        progress = (LogsOutputProgressDTO)redisOpsUtils.hashGet(key, entity.getLogsId());
    //    }

    //    return DeviceLogsDTO.builder()
    //            .logsId(entity.getLogsId())
    //            .createTime(LocalDateTime.ofInstant(Instant.ofEpochMilli(entity.getCreateTime()), ZoneId.systemDefault()))
    //            .happenTime(Objects.isNull(entity.getHappenTime()) ?
    //                    null : LocalDateTime.ofInstant(Instant.ofEpochMilli(entity.getHappenTime()), ZoneId.systemDefault()))
    //            .status(entity.getStatus())
    //            .logsInformation(entity.getLogsInfo())
    //            .userName(entity.getUsername())
    //            .deviceLogs(LogsFileUploadList.builder().files(logsFileService.getLogsFileByLogsId(entity.getLogsId())).build())
    //            .logsProgress(progress.getFiles())
    //            .deviceTopo(topologyService.getDeviceTopologyByGatewaySn(entity.getDeviceSn()).orElse(null))
    //            .build();
    //}

    public Task DeleteLogsAsync(string deviceSerialNumber, string logsId)
    {
        throw new NotImplementedException();
    }

    public Task<Uri> GetLogsFileUriAsync(string logsId, string fileId)
    {
        throw new NotImplementedException();
    }

    public async Task<BaseResponse<TEntity>> GetRealTimeLogsAsync<TEntity>(string serialNumber, IEnumerable<string> domains) where TEntity : class
    {
        // TODO:
        
        return null;
    }

    //    @Override
    //    public ResponseResult getRealTimeLogs(String deviceSn, List<String> domainList)
    //    {
    //        boolean exist = redisOpsUtils.getExpire(RedisConst.DEVICE_ONLINE_PREFIX + deviceSn) > 0;
    //        if (!exist)
    //        {
    //            return ResponseResult.error("Device is offline.");
    //        }

    //        String topic = TopicConst.THING_MODEL_PRE + TopicConst.PRODUCT + deviceSn + TopicConst.SERVICES_SUF;
    //        LogsFileUploadList data = messageSenderService.publishWithReply(
    //                LogsFileUploadList.class,
    //                topic,
    //                CommonTopicResponse.builder()
    //                        .tid(UUID.randomUUID().toString())
    //                        .bid(UUID.randomUUID().toString())
    //                        .method(LogsFileMethodEnum.FILE_UPLOAD_LIST.getMethod())
    //                        .timestamp(System.currentTimeMillis())
    //                        .data(Map.of(MapKeyConst.MODULE_LIST, domainList))
    //                        .build(), 1);

    //        for (LogsFileUpload file : data.getFiles()) {
    //            if (file.getDeviceSn().isBlank()) {
    //                file.setDeviceSn(deviceSn);
    //            }
    //        }
    //        return ResponseResult.success(data);
    //    }


    public Task<PaginationResponse<DeviceLogs>> GetUploadedLogsAsync(string serialNumber, DeviceLogsQueryRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<string> InsertDeviceLogsAsync(string bid, string userName, string deviceSerialNumber, DeviceLogsCreateRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<TEntity>> PushFileUploadAsync<TEntity>(string userName, string deviceSerialNumber, DeviceLogsCreateRequest request) where TEntity : class
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<TEntity>> PushUpdateFileAsync<TEntity>(string deviceSerialNumber, LogsFileUpdateRequest request) where TEntity : class
    {
        throw new NotImplementedException();
    }

    public Task UpdateLogsStatusAsync(string logsId, int value)
    {
        throw new NotImplementedException();
    }
}
