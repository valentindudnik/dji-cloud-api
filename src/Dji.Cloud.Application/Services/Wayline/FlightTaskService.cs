using Dji.Cloud.Application.Abstracts.Interfaces.Wayline;

namespace Dji.Cloud.Application.Services.Wayline;

public class FlightTaskService : IFlightTaskService
{
//    @Autowired
//private IMessageSenderService messageSender;

//    @Autowired
//private ObjectMapper mapper;

//    @Autowired
//private ISendMessageService websocketMessageService;

//    @Autowired
//private IWebSocketManageService webSocketManageService;

//    @Autowired
//private IWaylineJobService waylineJobService;

//    @Override
//    @ServiceActivator(inputChannel = ChannelName.INBOUND_EVENTS_FLIGHT_TASK_PROGRESS, outputChannel = ChannelName.OUTBOUND)
//public void handleProgress(CommonTopicReceiver receiver, MessageHeaders headers)
//    {
//        String receivedTopic = String.valueOf(headers.get(MqttHeaders.RECEIVED_TOPIC));
//        String dockSn = receivedTopic.substring((TopicConst.THING_MODEL_PRE + TopicConst.PRODUCT).length(),
//                receivedTopic.indexOf(TopicConst.EVENTS_SUF));
//        EventsReceiver<WaylineTaskProgressReceiver> eventsReceiver = mapper.convertValue(receiver.getData(),
//                new TypeReference<EventsReceiver<WaylineTaskProgressReceiver>>() { });
//        eventsReceiver.setBid(receiver.getBid());
//        eventsReceiver.setSn(receiver.getGateway());

//        WaylineTaskProgressReceiver output = eventsReceiver.getOutput();

//        log.info("Task progress: {}", output.getProgress().toString());

//        if (eventsReceiver.getResult() != ResponseResult.CODE_SUCCESS)
//        {
//            log.error("Task progress ===> Error code: " + eventsReceiver.getResult());
//        }

//        EventsResultStatusEnum statusEnum = EventsResultStatusEnum.find(output.getStatus());
//        String key = RedisConst.WAYLINE_JOB_RUNNING_PREFIX + dockSn;
//        RedisOpsUtils.setWithExpire(key, eventsReceiver, RedisConst.DEVICE_ALIVE_SECOND * RedisConst.DEVICE_ALIVE_SECOND);

//        if (statusEnum.getEnd())
//        {
//            WaylineJobDTO job = WaylineJobDTO.builder()
//                    .jobId(receiver.getBid())
//                    .status(WaylineJobStatusEnum.SUCCESS.getVal())
//                    .completedTime(LocalDateTime.now())
//            .mediaCount(output.getExt().getMediaCount())
//                    .build();

//            // record the update of the media count.
//            if (Objects.nonNull(job.getMediaCount()) && job.getMediaCount() != 0)
//            {
//                RedisOpsUtils.hashSet(RedisConst.MEDIA_FILE_PREFIX + receiver.getGateway(), job.getJobId(),
//                        MediaFileCountDTO.builder().jobId(receiver.getBid()).mediaCount(job.getMediaCount()).uploadedCount(0).build());
//            }

//            if (EventsResultStatusEnum.OK != statusEnum)
//            {
//                job.setCode(eventsReceiver.getResult());
//                job.setStatus(WaylineJobStatusEnum.FAILED.getVal());
//            }

//            waylineJobService.updateJob(job);
//            RedisOpsUtils.del(key);
//            RedisOpsUtils.del(RedisConst.WAYLINE_JOB_PAUSED_PREFIX + receiver.getBid());
//        }

//        DeviceDTO device = (DeviceDTO)RedisOpsUtils.get(RedisConst.DEVICE_ONLINE_PREFIX + receiver.getGateway());
//        websocketMessageService.sendBatch(
//                webSocketManageService.getValueWithWorkspaceAndUserType(
//                        device.getWorkspaceId(), UserTypeEnum.WEB.getVal()),
//                CustomWebSocketMessage.builder()
//                        .data(eventsReceiver)
//                        .timestamp(System.currentTimeMillis())
//                        .bizCode(BizCodeEnum.FLIGHT_TASK_PROGRESS.getCode())
//                        .build());

//        if (receiver.getNeedReply() == 1)
//        {
//            messageSender.publish(receivedTopic + TopicConst._REPLY_SUF,
//                    CommonTopicResponse.builder()
//                            .tid(receiver.getTid())
//                            .bid(receiver.getBid())
//                            .method(EventsMethodEnum.FLIGHT_TASK_PROGRESS.getMethod())
//                            .timestamp(System.currentTimeMillis())
//                            .data(RequestsReply.success())
//                            .build());
//        }
//    }

//    @Scheduled(initialDelay = 10, fixedRate = 5, timeUnit = TimeUnit.SECONDS)
//private void checkScheduledJob()
//    {
//        Object jobIdValue = RedisOpsUtils.zGetMin(RedisConst.WAYLINE_JOB_TIMED_EXECUTE);
//        if (Objects.isNull(jobIdValue))
//        {
//            return;
//        }
//        log.info("Check the timed tasks of the wayline. {}", jobIdValue);
//        // format: {workspace_id}:{dock_sn}:{job_id}
//        String[] jobArr = String.valueOf(jobIdValue).split(RedisConst.DELIMITER);
//        double time = RedisOpsUtils.zScore(RedisConst.WAYLINE_JOB_TIMED_EXECUTE, jobIdValue);
//        long now = System.currentTimeMillis();
//        int offset = 30_000;

//        // Expired tasks are deleted directly.
//        if (time < now - offset)
//        {
//            RedisOpsUtils.zRemove(RedisConst.WAYLINE_JOB_TIMED_EXECUTE, jobIdValue);
//            waylineJobService.updateJob(WaylineJobDTO.builder()
//                    .jobId(jobArr[2])
//                    .status(WaylineJobStatusEnum.FAILED.getVal())
//                    .executeTime(LocalDateTime.now())
//                    .completedTime(LocalDateTime.now())
//                    .code(HttpStatus.SC_REQUEST_TIMEOUT).build());
//            return;
//        }

//        if (now <= time && time <= now + offset)
//        {
//            try
//            {
//                waylineJobService.executeFlightTask(jobArr[0], jobArr[2]);
//            }
//            catch (Exception e)
//            {
//                log.info("The scheduled task delivery failed.");
//                waylineJobService.updateJob(WaylineJobDTO.builder()
//                        .jobId(jobArr[2])
//                        .status(WaylineJobStatusEnum.FAILED.getVal())
//                        .executeTime(LocalDateTime.now())
//                        .completedTime(LocalDateTime.now())
//                        .code(HttpStatus.SC_INTERNAL_SERVER_ERROR).build());
//            }
//            finally
//            {
//                RedisOpsUtils.zRemove(RedisConst.WAYLINE_JOB_TIMED_EXECUTE, jobIdValue);
//            }
//        }
//    }
}
