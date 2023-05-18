using Dji.Cloud.Application.Abstracts.Interfaces.Media;
using Dji.Cloud.Application.Abstracts.Requests.Media;
using Dji.Cloud.Domain.Mqtt.Models;

namespace Dji.Cloud.Application.Services.Media;

public class MediaService : IMediaService
{
    //        @Autowired
    //    private IFileService fileService;

    //        @Autowired
    //    private IWaylineJobService waylineJobService;

    //        @Autowired
    //    private ObjectMapper objectMapper;

    //        @Autowired
    //    private IMessageSenderService messageSenderService;

    //        @Autowired
    //    private IDeviceService deviceService;

    //        @Autowired
    //    private ISendMessageService sendMessageService;

    //        @Autowired
    //    private IWebSocketManageService webSocketManageService;

    //        @Override
    //    public Boolean fastUpload(String workspaceId, String fingerprint)
    //        {
    //            return fileService.checkExist(workspaceId, fingerprint);
    //        }

    //        @Override
    //    public Integer saveMediaFile(String workspaceId, FileUploadDTO file)
    //        {
    //            return fileService.saveFile(workspaceId, file);
    //        }

    //        @Override
    //    public List<String> getAllTinyFingerprintsByWorkspaceId(String workspaceId)
    //        {
    //            return fileService.getAllFilesByWorkspaceId(workspaceId)
    //                    .stream()
    //                    .map(MediaFileDTO::getTinnyFingerprint)
    //                    .collect(Collectors.toList());
    //        }

    //        @Override
    //    public List<String> getExistTinyFingerprints(String workspaceId, List<String> tinyFingerprints)
    //        {
    //            List<String> tinyFingerprintList = this.getAllTinyFingerprintsByWorkspaceId(workspaceId);
    //            return tinyFingerprints
    //                    .stream()
    //                    .filter(tinyFingerprintList::contains)
    //                    .collect(Collectors.toList());

    //        }

    //        @Override
    //        @ServiceActivator(inputChannel = ChannelName.INBOUND_EVENTS_FILE_UPLOAD_CALLBACK, outputChannel = ChannelName.OUTBOUND)
    //    public void handleFileUploadCallBack(CommonTopicReceiver receiver)
    //        {
    //            FileUploadCallback callback = objectMapper.convertValue(receiver.getData(), FileUploadCallback.class);

    //        String topic = TopicConst.THING_MODEL_PRE + TopicConst.PRODUCT + receiver.getGateway()
    //                + TopicConst.EVENTS_SUF + TopicConst._REPLY_SUF;
    //        CommonTopicResponse<RequestsReply> data = CommonTopicResponse.< RequestsReply > builder()
    //                .timestamp(System.currentTimeMillis())
    //                .method(EventsMethodEnum.FILE_UPLOAD_CALLBACK.getMethod())
    //                .data(RequestsReply.success())
    //                .tid(receiver.getTid())
    //                .bid(receiver.getBid())
    //                .build();

    //        if (callback.getResult() != ResponseResult.CODE_SUCCESS) {
    //            messageSenderService.publish(topic, data);
    //            return;
    //        }

    //    String jobId = callback.getFile().getExt().getFlightId();

    //    MediaFileCountDTO mediaFileCount = (MediaFileCountDTO)RedisOpsUtils.hashGet(RedisConst.MEDIA_FILE_PREFIX + receiver.getGateway(), jobId);
    //        // duplicate data
    //        if (receiver.getBid().equals(mediaFileCount.getBid()) && receiver.getTid().equals(mediaFileCount.getTid())) {
    //            messageSenderService.publish(topic, data);
    //            return;
    //        }

    //DeviceDTO device = (DeviceDTO)RedisOpsUtils.get(RedisConst.DEVICE_ONLINE_PREFIX + receiver.getGateway());
    //Optional<WaylineJobDTO> jobOpt = waylineJobService.getJobByJobId(device.getWorkspaceId(), jobId);
    //if (jobOpt.isPresent())
    //{
    //    boolean isSave = parseMediaFile(callback, jobOpt.get());
    //    if (!isSave)
    //    {
    //        data.setData(RequestsReply.error(CommonErrorEnum.ILLEGAL_ARGUMENT));
    //    }
    //}

    //messageSenderService.publish(topic, data);

    //notifyUploadedCount(mediaFileCount, receiver, jobId);
    //    }

    //    /**
    //     * update the uploaded count and notify web side
    //     * @param mediaFileCount
    //     * @param receiver
    //     * @param jobId
    //     */
    //    private void notifyUploadedCount(MediaFileCountDTO mediaFileCount, CommonTopicReceiver receiver, String jobId)
    //{
    //    mediaFileCount.setBid(receiver.getBid());
    //    mediaFileCount.setTid(receiver.getTid());
    //    mediaFileCount.setUploadedCount(mediaFileCount.getUploadedCount() + 1);

    //    String key = RedisConst.MEDIA_FILE_PREFIX + receiver.getGateway();
    //    // After all the files of the job are uploaded, delete the media file key.
    //    if (mediaFileCount.getUploadedCount() >= mediaFileCount.getMediaCount())
    //    {
    //        RedisOpsUtils.hashDel(key, new String[] { jobId });

    //        // After uploading, delete the key with the highest priority.
    //        String highestKey = RedisConst.MEDIA_HIGHEST_PRIORITY_PREFIX + receiver.getGateway();
    //        if (RedisOpsUtils.checkExist(highestKey) &&
    //                jobId.equals(((MediaFileCountDTO)RedisOpsUtils.get(highestKey)).getJobId()))
    //        {
    //            RedisOpsUtils.del(highestKey);
    //        }

    //        if (RedisOpsUtils.hashLen(key) == 0)
    //        {
    //            RedisOpsUtils.del(key);
    //        }
    //    }
    //    else
    //    {
    //        RedisOpsUtils.hashSet(key, jobId, mediaFileCount);
    //    }

    //    DeviceDTO dock = (DeviceDTO)RedisOpsUtils.get(RedisConst.DEVICE_ONLINE_PREFIX + receiver.getGateway());
    //    sendMessageService.sendBatch(webSocketManageService.getValueWithWorkspaceAndUserType(dock.getWorkspaceId(), UserTypeEnum.WEB.getVal()),
    //    CustomWebSocketMessage.builder()
    //                    .bizCode(BizCodeEnum.FILE_UPLOAD_CALLBACK.getCode())
    //                    .timestamp(System.currentTimeMillis())
    //                    .data(mediaFileCount)
    //                    .build());
    //}

    //private Boolean parseMediaFile(FileUploadCallback callback, WaylineJobDTO job)
    //{
    //    // Set the drone sn that shoots the media
    //    Optional<DeviceDTO> dockDTO = deviceService.getDeviceBySn(job.getDockSn());
    //    dockDTO.ifPresent(dock->callback.getFile().getExt().setSn(dock.getChildDeviceSn()));

    //    // set path
    //    String objectKey = callback.getFile().getObjectKey();
    //    callback.getFile().setPath(objectKey.substring(objectKey.indexOf("/") + 1, objectKey.lastIndexOf("/")));

    //    return fileService.saveFile(job.getWorkspaceId(), callback.getFile()) > 0;
    //}

    //@Override
    //    @ServiceActivator(inputChannel = ChannelName.INBOUND_EVENTS_HIGHEST_PRIORITY_UPLOAD_FLIGHT_TASK_MEDIA, outputChannel = ChannelName.OUTBOUND)
    //    public void handleHighestPriorityUploadFlightTaskMedia(CommonTopicReceiver receiver, MessageHeaders headers)
    //{
    //    Map map = objectMapper.convertValue(receiver.getData(), Map.class);
    //if (map.isEmpty() || !map.containsKey(MapKeyConst.FLIGHT_ID))
    //{
    //    return;
    //}

    //messageSenderService.publish(headers.get(MqttHeaders.RECEIVED_TOPIC) + TopicConst._REPLY_SUF,
    //        CommonTopicResponse.builder()
    //                .data(RequestsReply.success())
    //                .method(receiver.getMethod())
    //                .timestamp(System.currentTimeMillis())
    //                .bid(receiver.getBid())
    //                .tid(receiver.getTid())
    //                .build());

    //String dockSn = receiver.getGateway();
    //String jobId = map.get(MapKeyConst.FLIGHT_ID).toString();
    //String key = RedisConst.MEDIA_HIGHEST_PRIORITY_PREFIX + dockSn;
    //MediaFileCountDTO countDTO = new MediaFileCountDTO();
    //if (RedisOpsUtils.checkExist(key))
    //{
    //    countDTO = (MediaFileCountDTO)RedisOpsUtils.get(key);
    //    if (jobId.equals(countDTO.getJobId()))
    //    {
    //        RedisOpsUtils.setWithExpire(key, countDTO, RedisConst.DEVICE_ALIVE_SECOND * 5);
    //        return;
    //    }
    //    countDTO.setPreJobId(countDTO.getJobId());
    //}
    //countDTO.setJobId(jobId);

    //RedisOpsUtils.setWithExpire(key, countDTO, RedisConst.DEVICE_ALIVE_SECOND * 5);

    //DeviceDTO dock = (DeviceDTO)RedisOpsUtils.get(RedisConst.DEVICE_ONLINE_PREFIX + dockSn);
    //sendMessageService.sendBatch(webSocketManageService.getValueWithWorkspaceAndUserType(dock.getWorkspaceId(), UserTypeEnum.WEB.getVal()),
    //        CustomWebSocketMessage.builder()
    //                .timestamp(System.currentTimeMillis())
    //                .bizCode(BizCodeEnum.HIGHEST_PRIORITY_UPLOAD_FLIGHT_TASK_MEDIA.getCode())
    //                .data(countDTO)
    //                .build());

    //    }
    public async Task<bool> FastUploadAsync(string workspaceId, string fingerprint)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<string>> GetAllTinyFingerprintsByWorkspaceId(string workspaceId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<string>> GetExistTinyFingerprints(string workspaceId, IEnumerable<string> tinyFingerPrints)
    {
        throw new NotImplementedException();
    }

    public async Task HandleFileUploadCallBackAsync<TEntity>(CommonTopicReceiver<TEntity> receiver) where TEntity : class
    {
        throw new NotImplementedException();
    }

    public async Task<int> SaveMediaFileAsync(string workspaceId, FileUploadRequest request)
    {
        throw new NotImplementedException();
    }
}
