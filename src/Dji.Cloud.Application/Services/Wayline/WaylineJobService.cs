﻿using Dji.Cloud.Application.Abstracts.Interfaces.Wayline;
using Dji.Cloud.Domain.Wayline;
using Dji.Cloud.Domain;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Enums;

namespace Dji.Cloud.Application.Services.Wayline;

public class WaylineJobService : IWaylineJobService
{
    //    @Autowired
    //    private IWaylineJobMapper mapper;

    //    @Autowired
    //    private IWaylineFileService waylineFileService;

    //    @Autowired
    //    private IDeviceService deviceService;

    //    @Autowired
    //    private IMessageSenderService messageSender;
    //    @Autowired
    //    private ObjectMapper objectMapper;
    //    @Autowired
    //    private IFileService fileService;

    //    private Optional<WaylineJobDTO> insertWaylineJob(WaylineJobEntity jobEntity)
    //    {
    //        int id = mapper.insert(jobEntity);
    //        if (id <= 0)
    //        {
    //            return Optional.empty();
    //        }
    //        return Optional.ofNullable(this.entity2Dto(jobEntity));
    //    }

    //    @Override
    //    public Optional<WaylineJobDTO> createWaylineJob(CreateJobParam param, String workspaceId, String username, Long beginTime, Long endTime)
    //    {
    //        if (Objects.isNull(param))
    //        {
    //            return Optional.empty();
    //        }
    //        // Immediate tasks, allocating time on the backend.
    //        WaylineJobEntity jobEntity = WaylineJobEntity.builder()
    //                .name(param.getName())
    //                .dockSn(param.getDockSn())
    //                .fileId(param.getFileId())
    //                .username(username)
    //                .workspaceId(workspaceId)
    //                .jobId(UUID.randomUUID().toString())
    //                .beginTime(beginTime)
    //                .endTime(endTime)
    //                .status(WaylineJobStatusEnum.PENDING.getVal())
    //                .taskType(param.getTaskType())
    //                .waylineType(param.getWaylineType())
    //                .outOfControlAction(param.getOutOfControlAction())
    //                .rthAltitude(param.getRthAltitude())
    //                .mediaCount(0)
    //        .build();

    //        return insertWaylineJob(jobEntity);
    //    }

    //    @Override
    //    public Optional<WaylineJobDTO> createWaylineJobByParent(String workspaceId, String parentId)
    //    {
    //        Optional<WaylineJobDTO> parentJobOpt = this.getJobByJobId(workspaceId, parentId);
    //        if (parentJobOpt.isEmpty())
    //        {
    //            return Optional.empty();
    //        }
    //        WaylineJobEntity jobEntity = this.dto2Entity(parentJobOpt.get());
    //        jobEntity.setJobId(UUID.randomUUID().toString());
    //        jobEntity.setErrorCode(null);
    //        jobEntity.setCompletedTime(null);
    //        jobEntity.setExecuteTime(null);
    //        jobEntity.setStatus(WaylineJobStatusEnum.PENDING.getVal());
    //        jobEntity.setParentId(parentId);

    //        return this.insertWaylineJob(jobEntity);
    //    }

    //    @Override
    //    public ResponseResult publishFlightTask(CreateJobParam param, CustomClaim customClaim) throws SQLException
    //    {
    //        if (WaylineTaskTypeEnum.IMMEDIATE.getVal() == param.getTaskType()) {
    //            param.setExecuteTime(System.currentTimeMillis());
    //        }
    //Optional<WaylineJobDTO> waylineJobOpt = this.createWaylineJob(param,
    //        customClaim.getWorkspaceId(), customClaim.getUsername(),
    //        param.getExecuteTime(), param.getExecuteTime());
    //        if (waylineJobOpt.isEmpty()) {
    //            throw new SQLException("Failed to create wayline job.");
    //        }
    //        WaylineJobDTO waylineJob = waylineJobOpt.get();

    //boolean isOnline = deviceService.checkDeviceOnline(waylineJob.getDockSn());
    //if (!isOnline)
    //{
    //    throw new RuntimeException("Dock is offline.");
    //}

    //// get wayline file
    //Optional<WaylineFileDTO> waylineFile = waylineFileService.getWaylineByWaylineId(waylineJob.getWorkspaceId(), waylineJob.getFileId());
    //if (waylineFile.isEmpty())
    //{
    //    throw new SQLException("Wayline file doesn't exist.");
    //}

    //// get file url
    //URL url = waylineFileService.getObjectUrl(waylineJob.getWorkspaceId(), waylineFile.get().getWaylineId());

    //WaylineTaskCreateDTO flightTask = WaylineTaskCreateDTO.builder()
    //        .flightId(waylineJob.getJobId())
    //        .executeTime(waylineJob.getBeginTime().atZone(ZoneId.systemDefault()).toInstant().toEpochMilli())
    //        .taskType(waylineJob.getTaskType())
    //        .waylineType(waylineJob.getWaylineType())
    //        .rthAltitude(waylineJob.getRthAltitude())
    //        .outOfControlAction(waylineJob.getOutOfControlAction())
    //        .file(WaylineTaskFileDTO.builder()
    //                .url(url.toString())
    //                .fingerprint(waylineFile.get().getSign())
    //                .build())
    //        .build();

    //String topic = TopicConst.THING_MODEL_PRE + TopicConst.PRODUCT +
    //        waylineJob.getDockSn() + TopicConst.SERVICES_SUF;
    //CommonTopicResponse<Object> response = CommonTopicResponse.builder()
    //        .tid(UUID.randomUUID().toString())
    //        .bid(waylineJob.getJobId())
    //        .timestamp(System.currentTimeMillis())
    //        .data(flightTask)
    //        .method(WaylineMethodEnum.FLIGHT_TASK_PREPARE.getMethod())
    //        .build();

    //ServiceReply serviceReply = messageSender.publishWithReply(topic, response);
    //if (ResponseResult.CODE_SUCCESS != serviceReply.getResult())
    //{
    //    log.info("Prepare task ====> Error code: {}", serviceReply.getResult());
    //    this.updateJob(WaylineJobDTO.builder()
    //            .workspaceId(waylineJob.getWorkspaceId())
    //            .jobId(waylineJob.getJobId())
    //            .executeTime(LocalDateTime.now())
    //            .status(WaylineJobStatusEnum.FAILED.getVal())
    //            .completedTime(LocalDateTime.now())
    //            .code(serviceReply.getResult()).build());
    //    return ResponseResult.error("Prepare task ====> Error code: " + serviceReply.getResult());
    //}

    //// Issue an immediate task execution command.
    //if (WaylineTaskTypeEnum.IMMEDIATE.getVal() == waylineJob.getTaskType())
    //{
    //    if (!executeFlightTask(waylineJob.getWorkspaceId(), waylineJob.getJobId()))
    //    {
    //        return ResponseResult.error("Failed to execute job.");
    //    }
    //}

    //if (WaylineTaskTypeEnum.TIMED.getVal() == waylineJob.getTaskType())
    //{
    //    boolean isAdd = RedisOpsUtils.zAdd(RedisConst.WAYLINE_JOB_TIMED_EXECUTE,
    //            waylineJob.getWorkspaceId() + RedisConst.DELIMITER + waylineJob.getDockSn() + RedisConst.DELIMITER + waylineJob.getJobId(),
    //            waylineJob.getBeginTime().atZone(ZoneId.systemDefault()).toInstant().toEpochMilli());
    //    if (!isAdd)
    //    {
    //        return ResponseResult.error("Failed to create scheduled job.");
    //    }
    //}
    //return ResponseResult.success();
    //    }

    //    @Override
    //    public Boolean executeFlightTask(String workspaceId, String jobId)
    //{
    //    // get job
    //    Optional<WaylineJobDTO> waylineJob = this.getJobByJobId(workspaceId, jobId);
    //    if (waylineJob.isEmpty())
    //    {
    //        throw new IllegalArgumentException("Job doesn't exist.");
    //    }

    //    boolean isOnline = deviceService.checkDeviceOnline(waylineJob.get().getDockSn());
    //    if (!isOnline)
    //    {
    //        throw new RuntimeException("Dock is offline.");
    //    }

    //    WaylineJobDTO job = waylineJob.get();
    //    WaylineTaskCreateDTO flightTask = WaylineTaskCreateDTO.builder().flightId(jobId).build();

    //    String topic = TopicConst.THING_MODEL_PRE + TopicConst.PRODUCT +
    //            job.getDockSn() + TopicConst.SERVICES_SUF;
    //    CommonTopicResponse<Object> response = CommonTopicResponse.builder()
    //            .tid(UUID.randomUUID().toString())
    //            .bid(jobId)
    //            .timestamp(System.currentTimeMillis())
    //            .data(flightTask)
    //            .method(WaylineMethodEnum.FLIGHT_TASK_EXECUTE.getMethod())
    //            .build();

    //    ServiceReply serviceReply = messageSender.publishWithReply(topic, response);
    //    if (ResponseResult.CODE_SUCCESS != serviceReply.getResult())
    //    {
    //        log.info("Execute job ====> Error code: {}", serviceReply.getResult());
    //        this.updateJob(WaylineJobDTO.builder()
    //                .jobId(jobId)
    //                .executeTime(LocalDateTime.now())
    //                .status(WaylineJobStatusEnum.FAILED.getVal())
    //                .completedTime(LocalDateTime.now())
    //                .code(serviceReply.getResult()).build());
    //        return false;
    //    }

    //    this.updateJob(WaylineJobDTO.builder()
    //            .jobId(jobId)
    //            .executeTime(LocalDateTime.now())
    //            .status(WaylineJobStatusEnum.IN_PROGRESS.getVal())
    //            .build());
    //    RedisOpsUtils.setWithExpire(RedisConst.WAYLINE_JOB_RUNNING_PREFIX + job.getDockSn(),
    //            EventsReceiver.< WaylineTaskProgressReceiver > builder().bid(jobId).sn(job.getDockSn()).build(),
    //            RedisConst.DEVICE_ALIVE_SECOND * RedisConst.DEVICE_ALIVE_SECOND);
    //    return true;
    //}

    //@Override
    //    public void cancelFlightTask(String workspaceId, Collection<String> jobIds)
    //{
    //    List<WaylineJobDTO> waylineJobs = getJobsByConditions(workspaceId, jobIds, WaylineJobStatusEnum.PENDING);

    //    Set<String> waylineJobIds = waylineJobs.stream().map(WaylineJobDTO::getJobId).collect(Collectors.toSet());
    //    // Check if the task status is correct.
    //    boolean isErr = !jobIds.removeAll(waylineJobIds) || !jobIds.isEmpty();
    //    if (isErr)
    //    {
    //        throw new IllegalArgumentException("These tasks have an incorrect status and cannot be canceled. "
    //                + Arrays.toString(jobIds.toArray()));
    //    }

    //    // Group job id by dock sn.
    //    Map<String, List<String>> dockJobs = waylineJobs.stream()
    //            .collect(Collectors.groupingBy(WaylineJobDTO::getDockSn,
    //                    Collectors.mapping(WaylineJobDTO::getJobId, Collectors.toList())));
    //    dockJobs.forEach((dockSn, idList)-> this.publishCancelTask(workspaceId, dockSn, idList));
    //}

    //public void publishCancelTask(String workspaceId, String dockSn, List<String> jobIds)
    //{
    //    boolean isOnline = deviceService.checkDeviceOnline(dockSn);
    //    if (!isOnline)
    //    {
    //        throw new RuntimeException("Dock is offline.");
    //    }
    //    String topic = TopicConst.THING_MODEL_PRE + TopicConst.PRODUCT + dockSn + TopicConst.SERVICES_SUF;

    //    CommonTopicResponse<Object> response = CommonTopicResponse.builder()
    //            .tid(UUID.randomUUID().toString())
    //            .bid(UUID.randomUUID().toString())
    //            .timestamp(System.currentTimeMillis())
    //            .data(Map.of(MapKeyConst.FLIGHT_IDS, jobIds))
    //            .method(WaylineMethodEnum.FLIGHT_TASK_CANCEL.getMethod())
    //            .build();

    //    ServiceReply serviceReply = messageSender.publishWithReply(topic, response);
    //    if (ResponseResult.CODE_SUCCESS != serviceReply.getResult())
    //    {
    //        log.info("Cancel job ====> Error code: {}", serviceReply.getResult());
    //        throw new RuntimeException("Failed to cancel the wayline job of " + dockSn);
    //    }

    //    for (String jobId : jobIds) {
    //    this.updateJob(WaylineJobDTO.builder()
    //            .workspaceId(workspaceId)
    //            .jobId(jobId)
    //            .status(WaylineJobStatusEnum.CANCEL.getVal())
    //            .completedTime(LocalDateTime.now())
    //            .build());
    //    RedisOpsUtils.zRemove(RedisConst.WAYLINE_JOB_TIMED_EXECUTE, workspaceId + RedisConst.DELIMITER + dockSn + RedisConst.DELIMITER + jobId);
    //}

    //    }

    //    public List<WaylineJobDTO> getJobsByConditions(String workspaceId, Collection<String> jobIds, WaylineJobStatusEnum status)
    //{
    //    return mapper.selectList(
    //            new LambdaQueryWrapper<WaylineJobEntity>()
    //                    .eq(WaylineJobEntity::getWorkspaceId, workspaceId)
    //                    .eq(Objects.nonNull(status), WaylineJobEntity::getStatus, status.getVal())
    //                    .and(!CollectionUtils.isEmpty(jobIds),
    //                            wrapper->jobIds.forEach(id->wrapper.eq(WaylineJobEntity::getJobId, id).or())))
    //            .stream()
    //            .map(this::entity2Dto)
    //            .collect(Collectors.toList());
    //}

    //@Override
    //    public Optional<WaylineJobDTO> getJobByJobId(String workspaceId, String jobId)
    //{
    //    WaylineJobEntity jobEntity = mapper.selectOne(
    //            new LambdaQueryWrapper<WaylineJobEntity>()
    //                    .eq(WaylineJobEntity::getWorkspaceId, workspaceId)
    //                    .eq(WaylineJobEntity::getJobId, jobId));
    //    return Optional.ofNullable(entity2Dto(jobEntity));
    //}

    //@Override
    //    public Boolean updateJob(WaylineJobDTO dto)
    //{
    //    return mapper.update(this.dto2Entity(dto),
    //            new LambdaUpdateWrapper<WaylineJobEntity>()
    //                    .eq(WaylineJobEntity::getJobId, dto.getJobId())) > 0;
    //}

    //@Override
    //    public PaginationData<WaylineJobDTO> getJobsByWorkspaceId(String workspaceId, long page, long pageSize)
    //{
    //    Page<WaylineJobEntity> pageData = mapper.selectPage(
    //            new Page<WaylineJobEntity>(page, pageSize),
    //            new LambdaQueryWrapper<WaylineJobEntity>()
    //                    .eq(WaylineJobEntity::getWorkspaceId, workspaceId)
    //                    .orderByDesc(WaylineJobEntity::getId));
    //    List<WaylineJobDTO> records = pageData.getRecords()
    //            .stream()
    //            .map(this::entity2Dto)
    //            .collect(Collectors.toList());

    //    return new PaginationData<WaylineJobDTO>(records, new Pagination(pageData));
    //}


    //@Override
    //    @ServiceActivator(inputChannel = ChannelName.INBOUND_REQUESTS_FLIGHT_TASK_RESOURCE_GET, outputChannel = ChannelName.OUTBOUND)
    //    @Transactional(isolation = Isolation.READ_UNCOMMITTED)
    //    public void flightTaskResourceGet(CommonTopicReceiver receiver, MessageHeaders headers)
    //{
    //    Map<String, String> jobIdMap = objectMapper.convertValue(receiver.getData(), new TypeReference<Map<String, String>>() { });
    //    String jobId = jobIdMap.get(MapKeyConst.FLIGHT_ID);

    //    CommonTopicResponse.CommonTopicResponseBuilder<RequestsReply> builder = CommonTopicResponse.< RequestsReply > builder()
    //            .tid(receiver.getTid())
    //            .bid(receiver.getBid())
    //            .method(RequestsMethodEnum.FLIGHT_TASK_RESOURCE_GET.getMethod())
    //            .timestamp(System.currentTimeMillis());

    //    String topic = headers.get(MqttHeaders.RECEIVED_TOPIC).toString() + TopicConst._REPLY_SUF;

    //    DeviceDTO device = (DeviceDTO)RedisOpsUtils.get(RedisConst.DEVICE_ONLINE_PREFIX + receiver.getGateway());
    //    Optional<WaylineJobDTO> waylineJobOpt = this.getJobByJobId(device.getWorkspaceId(), jobId);
    //    if (waylineJobOpt.isEmpty())
    //    {
    //        builder.data(RequestsReply.error(CommonErrorEnum.ILLEGAL_ARGUMENT));
    //        messageSender.publish(topic, builder.build());
    //        return;
    //    }

    //    WaylineJobDTO waylineJob = waylineJobOpt.get();

    //    // get wayline file
    //    Optional<WaylineFileDTO> waylineFile = waylineFileService.getWaylineByWaylineId(waylineJob.getWorkspaceId(), waylineJob.getFileId());
    //    if (waylineFile.isEmpty())
    //    {
    //        builder.data(RequestsReply.error(CommonErrorEnum.ILLEGAL_ARGUMENT));
    //        messageSender.publish(topic, builder.build());
    //        return;
    //    }

    //    // get file url
    //    URL url = null;
    //    try
    //    {
    //        url = waylineFileService.getObjectUrl(waylineJob.getWorkspaceId(), waylineFile.get().getWaylineId());
    //        builder.data(RequestsReply.success(WaylineTaskCreateDTO.builder()
    //                .file(WaylineTaskFileDTO.builder()
    //                        .url(url.toString())
    //                        .fingerprint(waylineFile.get().getSign())
    //                        .build())
    //                .build()));

    //    }
    //    catch (SQLException | NullPointerException e) {
    //    e.printStackTrace();
    //    builder.data(RequestsReply.error(CommonErrorEnum.ILLEGAL_ARGUMENT));
    //    messageSender.publish(topic, builder.build());
    //    return;
    //}

    //messageSender.publish(topic, builder.build());

    //    }

    //    @Override
    //    public void uploadMediaHighestPriority(String workspaceId, String jobId)
    //{
    //    Optional<WaylineJobDTO> jobOpt = getJobByJobId(workspaceId, jobId);
    //    if (jobOpt.isEmpty())
    //    {
    //        throw new RuntimeException(CommonErrorEnum.ILLEGAL_ARGUMENT.getErrorMsg());
    //    }

    //    String dockSn = jobOpt.get().getDockSn();
    //    String key = RedisConst.MEDIA_HIGHEST_PRIORITY_PREFIX + dockSn;
    //    if (RedisOpsUtils.checkExist(key) &&
    //            jobId.equals(((MediaFileCountDTO)RedisOpsUtils.get(key)).getJobId()))
    //    {
    //        return;
    //    }

    //    ServiceReply reply = messageSender.publishWithReply(TopicConst.THING_MODEL_PRE + TopicConst.PRODUCT + dockSn + TopicConst.SERVICES_SUF,
    //            CommonTopicResponse.builder()
    //                    .tid(UUID.randomUUID().toString())
    //                    .bid(UUID.randomUUID().toString())
    //                    .timestamp(System.currentTimeMillis())
    //                    .method(MediaMethodEnum.UPLOAD_FLIGHT_TASK_MEDIA_PRIORITIZE.getMethod())
    //                    .data(Map.of(MapKeyConst.FLIGHT_ID, jobId))
    //                    .build());
    //    if (ResponseResult.CODE_SUCCESS != reply.getResult())
    //    {
    //        throw new RuntimeException("Failed to set media job upload priority. Error Code: " + reply.getResult());
    //    }
    //}

    //private WaylineJobEntity dto2Entity(WaylineJobDTO dto)
    //{
    //    WaylineJobEntity.WaylineJobEntityBuilder builder = WaylineJobEntity.builder();
    //    if (dto == null)
    //    {
    //        return builder.build();
    //    }
    //    if (Objects.nonNull(dto.getBeginTime()))
    //    {
    //        builder.beginTime(dto.getBeginTime().atZone(ZoneId.systemDefault()).toInstant().toEpochMilli());
    //    }
    //    if (Objects.nonNull(dto.getEndTime()))
    //    {
    //        builder.endTime(dto.getEndTime().atZone(ZoneId.systemDefault()).toInstant().toEpochMilli());
    //    }
    //    if (Objects.nonNull(dto.getExecuteTime()))
    //    {
    //        builder.executeTime(dto.getExecuteTime().atZone(ZoneId.systemDefault()).toInstant().toEpochMilli());
    //    }
    //    if (Objects.nonNull(dto.getCompletedTime()))
    //    {
    //        builder.completedTime(dto.getCompletedTime().atZone(ZoneId.systemDefault()).toInstant().toEpochMilli());
    //    }
    //    return builder.status(dto.getStatus())
    //            .mediaCount(dto.getMediaCount())
    //            .name(dto.getJobName())
    //            .errorCode(dto.getCode())
    //            .jobId(dto.getJobId())
    //            .fileId(dto.getFileId())
    //            .dockSn(dto.getDockSn())
    //            .workspaceId(dto.getWorkspaceId())
    //            .taskType(dto.getTaskType())
    //            .waylineType(dto.getWaylineType())
    //            .username(dto.getUsername())
    //            .rthAltitude(dto.getRthAltitude())
    //    .outOfControlAction(dto.getOutOfControlAction())
    //    .parentId(dto.getParentId())
    //            .build();
    //}

    //private WaylineJobDTO entity2Dto(WaylineJobEntity entity)
    //{
    //    if (entity == null)
    //    {
    //        return null;
    //    }

    //    WaylineJobDTO.WaylineJobDTOBuilder builder = WaylineJobDTO.builder()
    //            .jobId(entity.getJobId())
    //            .jobName(entity.getName())
    //            .fileId(entity.getFileId())
    //            .fileName(waylineFileService.getWaylineByWaylineId(entity.getWorkspaceId(), entity.getFileId())
    //                    .orElse(WaylineFileDTO.builder().build()).getName())
    //            .dockSn(entity.getDockSn())
    //            .dockName(deviceService.getDeviceBySn(entity.getDockSn())
    //                    .orElse(DeviceDTO.builder().build()).getNickname())
    //    .username(entity.getUsername())
    //    .workspaceId(entity.getWorkspaceId())
    //            .status(WaylineJobStatusEnum.IN_PROGRESS.getVal() == entity.getStatus() &&
    //    RedisOpsUtils.checkExist(RedisConst.WAYLINE_JOB_PAUSED_PREFIX + entity.getJobId()) ?
    //                    WaylineJobStatusEnum.PAUSED.getVal() : entity.getStatus())
    //            .code(entity.getErrorCode())
    //            .beginTime(LocalDateTime.ofInstant(Instant.ofEpochMilli(entity.getBeginTime()), ZoneId.systemDefault()))
    //            .endTime(Objects.nonNull(entity.getEndTime()) ?
    //    LocalDateTime.ofInstant(Instant.ofEpochMilli(entity.getEndTime()), ZoneId.systemDefault()) : null)
    //            .executeTime(Objects.nonNull(entity.getExecuteTime()) ?
    //                    LocalDateTime.ofInstant(Instant.ofEpochMilli(entity.getExecuteTime()), ZoneId.systemDefault()) : null)
    //            .completedTime(WaylineJobStatusEnum.find(entity.getStatus()).getEnd() ?
    //                    LocalDateTime.ofInstant(Instant.ofEpochMilli(entity.getUpdateTime()), ZoneId.systemDefault()) : null)
    //    .taskType(entity.getTaskType())
    //            .waylineType(entity.getWaylineType())
    //            .rthAltitude(entity.getRthAltitude())
    //            .outOfControlAction(entity.getOutOfControlAction())
    //            .mediaCount(entity.getMediaCount());

    //    if (Objects.nonNull(entity.getEndTime()))
    //    {
    //        builder.endTime(LocalDateTime.ofInstant(Instant.ofEpochMilli(entity.getEndTime()), ZoneId.systemDefault()));
    //    }
    //    if (WaylineJobStatusEnum.IN_PROGRESS.getVal() == entity.getStatus() && RedisOpsUtils.getExpire(entity.getJobId()) > 0)
    //    {
    //        EventsReceiver<WaylineTaskProgressReceiver> taskProgress = (EventsReceiver<WaylineTaskProgressReceiver>)RedisOpsUtils.get(RedisConst.WAYLINE_JOB_RUNNING_PREFIX + entity.getDockSn());
    //        if (Objects.nonNull(taskProgress.getOutput()) && Objects.nonNull(taskProgress.getOutput().getProgress()))
    //        {
    //            builder.progress(taskProgress.getOutput().getProgress().getPercent());
    //        }
    //    }

    //    if (entity.getMediaCount() == 0)
    //    {
    //        return builder.build();
    //    }

    //    // sync the number of media files
    //    String key = RedisConst.MEDIA_HIGHEST_PRIORITY_PREFIX + entity.getDockSn();
    //    String countKey = RedisConst.MEDIA_FILE_PREFIX + entity.getDockSn();
    //    Object mediaFileCount = RedisOpsUtils.hashGet(countKey, entity.getJobId());
    //    if (Objects.nonNull(mediaFileCount))
    //    {
    //        builder.uploadedCount(((MediaFileCountDTO)mediaFileCount).getUploadedCount())
    //                .uploading(RedisOpsUtils.checkExist(key) && entity.getJobId().equals(((MediaFileCountDTO)RedisOpsUtils.get(key)).getJobId()));
    //        return builder.build();
    //    }

    //    int uploadedSize = fileService.getFilesByWorkspaceAndJobId(entity.getWorkspaceId(), entity.getJobId()).size();
    //    // All media for this job have been uploaded.
    //    if (uploadedSize >= entity.getMediaCount())
    //    {
    //        return builder.uploadedCount(uploadedSize).build();
    //    }
    //    RedisOpsUtils.hashSet(countKey, entity.getJobId(),
    //            MediaFileCountDTO.builder()
    //                    .jobId(entity.getJobId())
    //                    .mediaCount(entity.getMediaCount())
    //                    .uploadedCount(uploadedSize).build());
    //    return builder.build();
    //}
    public Task CancelFlightTaskAsync(string workspaceId, IEnumerable<string> jobIds)
    {
        throw new NotImplementedException();
    }

    //public Task<WaylineJob> CreateWaylineJobAsync(CreateJobRequest parameters, string workspaceId, string username, long beginTime, long endTime)
    //{
    //    throw new NotImplementedException();
    //}

    public Task<WaylineJob> CreateWaylineJobAsync(CreateJobRequest parameters, string workspaceId, string username, long beginTime, long endTime)
    {
        throw new NotImplementedException();
    }

    public Task<WaylineJob> CreateWaylineJobByParentAsync(string workspaceId, string parentId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExecuteFlightTaskAsync(string workspaceId, string jobId)
    {
        throw new NotImplementedException();
    }

    public Task<WaylineJob> GetJobByJobIdAsync(string workspaceId, string jobId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<WaylineJob>> GetJobsByConditionsAsync(string workspaceId, IEnumerable<string> jobIds, WaylineJobStatusEnum status)
    {
        throw new NotImplementedException();
    }

    public Task<PaginationResponse<WaylineJob>> GetJobsByWorkspaceIdAsync(string workspaceId, long page, long pageSize)
    {
        throw new NotImplementedException();
    }

    public Task PublishCancelTaskAsync(string workspaceId, string dockSerialNumber, IEnumerable<string> jobIds)
    {
        throw new NotImplementedException();
    }

    //public Task<BaseResponse<TEntity>> PublishFlightTaskAsync<TEntity>(CreateJobParameters parameters, TokenInfo customClaim) where TEntity : class
    //{
    //    throw new NotImplementedException();
    //}

    public Task<BaseResponse<TEntity>> PublishFlightTaskAsync<TEntity>(CreateJobRequest request, TokenInfo customClaim) where TEntity : class
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateJobAsync(WaylineJob waylineJob)
    {
        throw new NotImplementedException();
    }

    public Task UploadMediaHighestPriorityAsync(string workspaceId, string jobId)
    {
        throw new NotImplementedException();
    }
}
