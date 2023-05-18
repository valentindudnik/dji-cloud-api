using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Services.Manage;

public class LogsFileIndexService : ILogsFileIndexService
{
    //@Autowired
    //private ILogsFileIndexMapper mapper;

    //@Override
    //public Boolean insertFileIndex(LogsFile file, String deviceSn, Integer domain, String fileId)
    //{
    //    if (Objects.isNull(file))
    //    {
    //        return false;
    //    }
    //    LogsFileIndexEntity entity = this.logsFile2Entity(file);
    //    entity.setDomain(domain);
    //    entity.setDeviceSn(deviceSn);
    //    entity.setFileId(fileId);

    //    return mapper.insert(entity) > 0;
    //}

    //@Override
    //public List<LogsFileUpload> getFileIndexByFileIds(List<LogsFileDTO> files)
    //{
    //    List<LogsFileUpload> list = new ArrayList<>();
    //    files.forEach(file-> {
    //        Optional<LogsFileUpload> fileOpt = this.getFileIndexByFileId(file.getFileId());
    //        fileOpt.ifPresent(fileUpload-> {
    //            fileUpload.setObjectKey(file.getStatus() ? file.getObjectKey() : null);
    //            list.add(fileUpload);
    //        });
    //    });
    //    return list;
    //}

    //@Override
    //public void deleteFileIndexByFileIds(List<String> fileIds)
    //{
    //    mapper.delete(new LambdaUpdateWrapper<LogsFileIndexEntity>()
    //            .or(wrapper->fileIds.forEach(fileId->wrapper.eq(LogsFileIndexEntity::getFileId, fileId))));
    //}

    //@Override
    //public Optional<LogsFileUpload> getFileIndexByFileId(String fileId)
    //{
    //    List<LogsFileIndexEntity> logsFileIndexList = mapper.selectList(
    //            new LambdaQueryWrapper<LogsFileIndexEntity>().eq(LogsFileIndexEntity::getFileId, fileId));
    //    if (CollectionUtils.isEmpty(logsFileIndexList))
    //    {
    //        return Optional.empty();
    //    }
    //    LogsFileIndexEntity entity = logsFileIndexList.get(0);
    //    List<LogsFile> logsFileList = logsFileIndexList.stream().map(this::entity2LogsFile).collect(Collectors.toList());
    //    return Optional.of(LogsFileUpload.builder()
    //            .deviceSn(entity.getDeviceSn())
    //            .deviceModelDomain(String.valueOf(entity.getDomain()))
    //            .list(logsFileList)
    //            .fileId(fileId)
    //            .build());

    //}

    //private LogsFile entity2LogsFile(LogsFileIndexEntity entity)
    //{
    //    if (Objects.isNull(entity))
    //    {
    //        return null;
    //    }
    //    return LogsFile.builder()
    //            .bootIndex(entity.getBootIndex())
    //            .startTime(entity.getStartTime())
    //            .endTime(entity.getEndTime())
    //            .size(entity.getSize())
    //            .build();

    //}

    //private LogsFileIndexEntity logsFile2Entity(LogsFile file)
    //{
    //    if (Objects.isNull(file))
    //    {
    //        return null;
    //    }
    //    return LogsFileIndexEntity.builder()
    //            .bootIndex(file.getBootIndex())
    //            .size(file.getSize())
    //            .startTime(file.getStartTime())
    //            .endTime(file.getEndTime())
    //            .build();
    //}
    public Task DeleteFileIndexByFileIdsAsync(IEnumerable<string> fileIds)
    {
        throw new NotImplementedException();
    }

    public Task<LogsFileUpload> GetFileIndexByFileIdAsync(string fileId)
    {
        throw new NotImplementedException();
    }

    public Task<LogsFileUpload> GetFileIndexByFileIdsAsync(IEnumerable<LogsFile> fileIds)
    {
        throw new NotImplementedException();
    }

    public Task<bool> InsertFileIndexAsync(LogsFile file, string deviceSerialNumber, int domain, string fileId)
    {
        throw new NotImplementedException();
    }
}
