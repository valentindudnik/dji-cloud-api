using Dji.Cloud.Application.Abstracts.Interfaces.Media;
using Dji.Cloud.Application.Abstracts.Requests.Media;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Media;

namespace Dji.Cloud.Application.Services.Media;

public class FileService : IFileService
{
    //    @Autowired
    //private IFileMapper mapper;

    //    @Autowired
    //private IDeviceDictionaryService deviceDictionaryService;

    //    @Autowired
    //private OssServiceContext ossService;

    //    private Optional<MediaFileEntity> getMediaByFingerprint(String workspaceId, String fingerprint)
    //    {
    //        MediaFileEntity fileEntity = mapper.selectOne(new LambdaQueryWrapper<MediaFileEntity>()
    //                .eq(MediaFileEntity::getWorkspaceId, workspaceId)
    //                .eq(MediaFileEntity::getFingerprint, fingerprint));
    //        return Optional.ofNullable(fileEntity);
    //    }

    //    private Optional<MediaFileEntity> getMediaByFileId(String workspaceId, String fileId)
    //    {
    //        MediaFileEntity fileEntity = mapper.selectOne(new LambdaQueryWrapper<MediaFileEntity>()
    //                .eq(MediaFileEntity::getWorkspaceId, workspaceId)
    //                .eq(MediaFileEntity::getFileId, fileId));
    //        return Optional.ofNullable(fileEntity);
    //    }

    //    @Override
    //public Boolean checkExist(String workspaceId, String fingerprint)
    //    {
    //        return this.getMediaByFingerprint(workspaceId, fingerprint).isPresent();
    //    }

    //    @Override
    //public Integer saveFile(String workspaceId, FileUploadDTO file)
    //    {
    //        MediaFileEntity fileEntity = this.fileUploadConvertToEntity(file);
    //        fileEntity.setWorkspaceId(workspaceId);
    //        fileEntity.setFileId(UUID.randomUUID().toString());
    //        return mapper.insert(fileEntity);
    //    }

    //    @Override
    //public List<MediaFileDTO> getAllFilesByWorkspaceId(String workspaceId)
    //    {
    //        return mapper.selectList(new LambdaQueryWrapper<MediaFileEntity>()
    //                .eq(MediaFileEntity::getWorkspaceId, workspaceId))
    //                .stream()
    //                .map(this::entityConvertToDto)
    //                .collect(Collectors.toList());
    //    }

    //    @Override
    //public PaginationData<MediaFileDTO> getMediaFilesPaginationByWorkspaceId(String workspaceId, long page, long pageSize)
    //    {
    //        Page<MediaFileEntity> pageData = mapper.selectPage(
    //                new Page<MediaFileEntity>(page, pageSize),
    //                new LambdaQueryWrapper<MediaFileEntity>()
    //                        .eq(MediaFileEntity::getWorkspaceId, workspaceId)
    //                        .orderByDesc(MediaFileEntity::getId));
    //        List<MediaFileDTO> records = pageData.getRecords()
    //                .stream()
    //                .map(this::entityConvertToDto)
    //                .collect(Collectors.toList());

    //        return new PaginationData<MediaFileDTO>(records, new Pagination(pageData));
    //    }

    //    @Override
    //public URL getObjectUrl(String workspaceId, String fileId)
    //    {
    //        Optional<MediaFileEntity> mediaFileOpt = getMediaByFileId(workspaceId, fileId);
    //        if (mediaFileOpt.isEmpty())
    //        {
    //            throw new IllegalArgumentException("{} doesn't exist.");
    //        }

    //        return ossService.getObjectUrl(OssConfiguration.bucket, mediaFileOpt.get().getObjectKey());
    //    }

    //    @Override
    //public List<MediaFileDTO> getFilesByWorkspaceAndJobId(String workspaceId, String jobId)
    //    {
    //        return mapper.selectList(new LambdaQueryWrapper<MediaFileEntity>()
    //                .eq(MediaFileEntity::getWorkspaceId, workspaceId)
    //                .eq(MediaFileEntity::getJobId, jobId))
    //                .stream()
    //                .map(this::entityConvertToDto).collect(Collectors.toList());
    //    }

    //    /**
    //     * Convert the received file object into a database entity object.
    //     * @param file
    //     * @return
    //     */
    //    private MediaFileEntity fileUploadConvertToEntity(FileUploadDTO file)
    //    {
    //        MediaFileEntity.MediaFileEntityBuilder builder = MediaFileEntity.builder();

    //        if (file != null)
    //        {
    //            builder.fileName(file.getName())
    //                    .filePath(file.getPath())
    //                    .fingerprint(file.getFingerprint())
    //                    .objectKey(file.getObjectKey())
    //                    .subFileType(file.getSubFileType())
    //                    .isOriginal(file.getExt().getIsOriginal())
    //                    .jobId(file.getExt().getFlightId())
    //                    .drone(file.getExt().getSn())
    //                    .tinnyFingerprint(file.getExt().getTinnyFingerprint());

    //            // domain-type-subType
    //            int[] payloadModel = Arrays.stream(file.getExt().getPayloadModelKey().split("-"))
    //                    .map(Integer::valueOf)
    //                    .mapToInt(Integer::intValue)
    //                    .toArray();
    //            Optional<DeviceDictionaryDTO> payloadDict = deviceDictionaryService
    //                    .getOneDictionaryInfoByTypeSubType(DeviceDomainEnum.PAYLOAD.getVal(), payloadModel[1], payloadModel[2]);
    //            payloadDict.ifPresent(payload->builder.payload(payload.getDeviceName()));
    //        }
    //        return builder.build();
    //    }

    //    /**
    //     * Convert database entity objects into file data transfer object.
    //     * @param entity
    //     * @return
    //     */
    //    private MediaFileDTO entityConvertToDto(MediaFileEntity entity)
    //    {
    //        MediaFileDTO.MediaFileDTOBuilder builder = MediaFileDTO.builder();

    //        if (entity != null)
    //        {
    //            builder.fileName(entity.getFileName())
    //                    .fileId(entity.getFileId())
    //                    .filePath(entity.getFilePath())
    //                    .isOriginal(entity.getIsOriginal())
    //                    .fingerprint(entity.getFingerprint())
    //                    .objectKey(entity.getObjectKey())
    //                    .tinnyFingerprint(entity.getTinnyFingerprint())
    //            .payload(entity.getPayload())
    //                    .createTime(LocalDateTime.ofInstant(
    //                            Instant.ofEpochMilli(entity.getCreateTime()), ZoneId.systemDefault()))
    //                    .drone(entity.getDrone())
    //                    .jobId(entity.getJobId());

    //        }

    //        return builder.build();
    //    }
    public async Task<bool> CheckExistAsync(string workspaceId, string fingerprint)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<MediaFile>> GetAllFilesByWorkspaceIdAsync(string workspaceId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<MediaFile>> GetFilesByWorkspaceAndJobIdAsync(string workspaceId, string jobId)
    {
        throw new NotImplementedException();
    }

    public async Task<PaginationResponse<MediaFile>> GetMediaFilesPaginationByWorkspaceIdAsync(string workspaceId, long page, long pageSize)
    {
        throw new NotImplementedException();
    }

    public async Task<Uri> GetObjectUriAsync(string workspaceId, string fileId)
    {
        throw new NotImplementedException();
    }

    public async Task<int> SaveFileAsync(string workspaceId, FileUploadRequest request)
    {
        throw new NotImplementedException();
    }
}
