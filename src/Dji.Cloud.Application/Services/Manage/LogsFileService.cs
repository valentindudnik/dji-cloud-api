using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Services.Manage;

public class LogsFileService : ILogsFileService
{
    //@Autowired
    //private ILogsFileMapper mapper;

    //@Autowired
    //private ILogsFileIndexService logsFileIndexService;

    //@Autowired
    //private OssServiceContext ossService;

    //@Autowired
    //private OssServiceContext ossServiceContext;

    //@Override
    //public List<LogsFileDTO> getLogsFileInfoByLogsId(String logsId)
    //{
    //    return mapper.selectList(
    //            new LambdaQueryWrapper<LogsFileEntity>()
    //                    .eq(LogsFileEntity::getLogsId, logsId)).stream()
    //            .map(this::entity2Dto).collect(Collectors.toList());
    //}

    //private LogsFileDTO entity2Dto(LogsFileEntity entity)
    //{
    //    if (Objects.isNull(entity))
    //    {
    //        return null;
    //    }
    //    return LogsFileDTO.builder()
    //            .deviceSn(entity.getDeviceSn())
    //            .fileId(entity.getFileId())
    //            .fingerprint(entity.getFingerprint())
    //            .logsId(entity.getLogsId())
    //            .name(entity.getName())
    //            .objectKey(entity.getObjectKey())
    //            .size(entity.getSize())
    //            .status(entity.getStatus())
    //            .build();
    //}

    //@Override
    //public List<LogsFileUpload> getLogsFileByLogsId(String logsId)
    //{
    //    List<LogsFileDTO> logsFiles = this.getLogsFileInfoByLogsId(logsId);
    //    if (CollectionUtils.isEmpty(logsFiles))
    //    {
    //        return new ArrayList<>();
    //    }
    //    return logsFileIndexService.getFileIndexByFileIds(logsFiles);
    //}

    //@Override
    //public Boolean insertFile(LogsFileUpload file, String logsId)
    //{
    //    LogsFileEntity entity = LogsFileEntity.builder()
    //    .logsId(logsId)
    //            .fileId(UUID.randomUUID().toString())
    //            .objectKey(file.getObjectKey())
    //            .status(false)
    //            .deviceSn(file.getDeviceSn())
    //            .build();
    //    boolean insert = mapper.insert(entity) > 0;
    //    if (!insert)
    //    {
    //        return false;
    //    }
    //    for (LogsFile logsFile : file.getList())
    //    {
    //        insert = logsFileIndexService.insertFileIndex(logsFile, file.getDeviceSn(), Integer.valueOf(file.getDeviceModelDomain()), entity.getFileId());
    //        if (!insert)
    //        {
    //            return false;
    //        }
    //    }
    //    return true;
    //}

    //@Override
    //public void deleteFileByLogsId(String logsId)
    //{
    //    List<LogsFileDTO> logsFiles = this.getLogsFileInfoByLogsId(logsId);
    //    if (CollectionUtils.isEmpty(logsFiles))
    //    {
    //        return;
    //    }
    //    mapper.delete(new LambdaUpdateWrapper<LogsFileEntity>().eq(LogsFileEntity::getLogsId, logsId));
    //    List<String> fileIds = new ArrayList<>();
    //    logsFiles.forEach(file-> {
    //        if (file.getStatus())
    //        {
    //            ossService.deleteObject(OssConfiguration.bucket, file.getObjectKey());
    //        }
    //        fileIds.add(file.getFileId());
    //    });

    //    logsFileIndexService.deleteFileIndexByFileIds(fileIds);
    //}

    //@Override
    //public void updateFile(String logsId, LogsExtFileReceiver fileReceiver)
    //{
    //    List<LogsFileDTO> logsFiles = this.getLogsFileInfoByLogsId(logsId);
    //    if (CollectionUtils.isEmpty(logsFiles))
    //    {
    //        return;
    //    }
    //    mapper.update(receiver2Entity(fileReceiver),
    //            new LambdaUpdateWrapper<LogsFileEntity>().eq(LogsFileEntity::getLogsId, logsId)
    //                    .eq(LogsFileEntity::getDeviceSn, fileReceiver.getDeviceSn()));
    //}

    //@Override
    //public void updateFileUploadStatus(String logsId, Boolean isUploaded)
    //{
    //    mapper.update(LogsFileEntity.builder().status(isUploaded).build(),
    //            new LambdaUpdateWrapper<LogsFileEntity>().eq(LogsFileEntity::getLogsId, logsId));
    //}

    //@Override
    //public URL getLogsFileUrl(String logsId, String fileId)
    //{
    //    LogsFileEntity logsFile = mapper.selectOne(new LambdaQueryWrapper<LogsFileEntity>()
    //            .eq(LogsFileEntity::getLogsId, logsId).eq(LogsFileEntity::getFileId, fileId));
    //    if (Objects.isNull(logsFile))
    //    {
    //        return null;
    //    }
    //    return ossService.getObjectUrl(OssConfiguration.bucket, logsFile.getObjectKey());
    //}

    //private LogsFileEntity receiver2Entity(LogsExtFileReceiver receiver)
    //{
    //    if (Objects.isNull(receiver))
    //    {
    //        return null;
    //    }
    //    return LogsFileEntity.builder()
    //            .fingerprint(receiver.getFingerprint())
    //            .size(receiver.getSize())
    //            .status(Objects.nonNull(receiver.getProgress()) &&
    //                    EventsResultStatusEnum.OK.getDesc().equals(receiver.getProgress().getStatus()))
    //            .name(receiver.getKey().substring(receiver.getKey().lastIndexOf("/") + 1)).build();
    //}
    public Task DeleteFilebyLogsIdAsync(string logsId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<LogsFileUpload>> GetLogsFileByLogsIdAsync(string logsId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<LogsFile>> GetLogsFileInfoByLogsIdAsync(string logsId)
    {
        throw new NotImplementedException();
    }

    public Task<Uri> GetLogsFileUriAsync(string logsId, string fileId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> InsertFileAsync(LogsFileUpload file, string logsId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateFileAsync(string logsId, LogsExtFileReceiver fileReceiver)
    {
        throw new NotImplementedException();
    }

    public Task UpdateFileUploadStatusAsync(string logsId, bool isUploaded)
    {
        throw new NotImplementedException();
    }
}
