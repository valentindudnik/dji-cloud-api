using Dji.Cloud.Application.Abstracts.Interfaces.Oss;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.IO.Compression;
using System.Reflection.Metadata;
using System.Xml.Linq;
using Dji.Cloud.Application.Abstracts.Interfaces.Wayline;
using Dji.Cloud.Domain.Wayline;
using Dji.Cloud.Domain;
using System.Data;
using Dji.Cloud.Infrastructure.Abstracts.Interfaces;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Wayline;
using AutoMapper;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Application.Abstracts.Responses.Common;

namespace Dji.Cloud.Application.Services.Wayline;

public class WaylineFileService : IWaylineFileService
{
    private readonly IMapper _mapper;

    private readonly IGenericRepository<WaylineFileEntity> _waylineFileRepository;

    public WaylineFileService(IMapper mapper,
                              IGenericRepository<WaylineFileEntity> waylineFileRepository)
    {
        _mapper = mapper;
        _waylineFileRepository = waylineFileRepository;
    }

    //    @Autowired
    //    private IWaylineFileMapper mapper;

    //    @Autowired
    //    private OssServiceContext ossService;

    //    @Override
    //    public Optional<WaylineFileDTO> getWaylineByWaylineId(String workspaceId, String waylineId)
    //    {
    //        return Optional.ofNullable(
    //                this.entityConvertToDTO(
    //                        mapper.selectOne(
    //                                new LambdaQueryWrapper<WaylineFileEntity>()
    //                                    .eq(WaylineFileEntity::getWorkspaceId, workspaceId)
    //                                    .eq(WaylineFileEntity::getWaylineId, waylineId))));
    //    }

    //    @Override
    //    public URL getObjectUrl(String workspaceId, String waylineId) throws SQLException
    //    {
    //        Optional<WaylineFileDTO> waylineOpt = this.getWaylineByWaylineId(workspaceId, waylineId);
    //        if (waylineOpt.isEmpty()) {
    //            throw new SQLException(waylineId + " does not exist.");
    //}
    //        return ossService.getObjectUrl(OssConfiguration.bucket, waylineOpt.get().getObjectKey());
    //    }

    //    @Override
    //    public Integer saveWaylineFile(String workspaceId, WaylineFileDTO metadata)
    //{
    //    WaylineFileEntity file = this.dtoConvertToEntity(metadata);
    //    file.setWaylineId(UUID.randomUUID().toString());
    //    file.setWorkspaceId(workspaceId);

    //    if (!StringUtils.hasText(file.getSign()))
    //    {
    //        try (InputStream object = ossService.getObject(OssConfiguration.bucket, metadata.getObjectKey())) {
    //    if (object.available() == 0)
    //    {
    //        throw new RuntimeException("The file " + metadata.getObjectKey() +
    //                " does not exist in the bucket[" + OssConfiguration.bucket + "].");
    //    }
    //    file.setSign(DigestUtils.md5DigestAsHex(object));
    //} catch (IOException e) {
    //    e.printStackTrace();
    //}
    //        }
    //        int insertId = mapper.insert(file);
    //return insertId > 0 ? file.getId() : insertId;
    //    }

    //    @Override
    //    public Boolean markFavorite(String workspaceId, List<String> waylineIds, Boolean isFavorite)
    //{
    //    if (waylineIds.isEmpty())
    //    {
    //        return false;
    //    }
    //    if (isFavorite == null)
    //    {
    //        return true;
    //    }
    //    return mapper.update(null, new LambdaUpdateWrapper<WaylineFileEntity>()
    //            .set(WaylineFileEntity::getFavorited, isFavorite)
    //            .eq(WaylineFileEntity::getWorkspaceId, workspaceId)
    //            .in (WaylineFileEntity::getWaylineId, waylineIds)) > 0;
    //}

    //@Override
    //    public List<String> getDuplicateNames(String workspaceId, List<String> names)
    //{
    //    return mapper.selectList(new LambdaQueryWrapper<WaylineFileEntity>()
    //            .eq(WaylineFileEntity::getWorkspaceId, workspaceId)
    //            .in (WaylineFileEntity::getName, names))
    //            .stream()
    //            .map(WaylineFileEntity::getName)
    //            .collect(Collectors.toList());
    //}

    //@Override
    //    public void importKmzFile(MultipartFile file, String workspaceId, String creator)
    //{
    //    Optional<WaylineFileDTO> waylineFileOpt = validKmzFile(file);
    //    if (waylineFileOpt.isEmpty())
    //    {
    //        throw new RuntimeException("The file format is incorrect.");
    //    }

    //    try
    //    {
    //        WaylineFileDTO waylineFile = waylineFileOpt.get();
    //        waylineFile.setWaylineId(workspaceId);
    //        waylineFile.setUsername(creator);

    //        ossService.putObject(OssConfiguration.bucket, waylineFile.getObjectKey(), file.getInputStream());
    //        this.saveWaylineFile(workspaceId, waylineFile);
    //    }
    //    catch (IOException e)
    //    {
    //        e.printStackTrace();
    //    }
    //}

    //private Optional<WaylineFileDTO> validKmzFile(MultipartFile file)
    //{
    //    String filename = file.getOriginalFilename();
    //    if (Objects.nonNull(filename) && !filename.endsWith(WAYLINE_FILE_SUFFIX))
    //    {
    //        throw new RuntimeException("The file format is incorrect.");
    //    }
    //    try (ZipInputStream unzipFile = new ZipInputStream(file.getInputStream(), StandardCharsets.UTF_8)) {

    //    ZipEntry nextEntry = unzipFile.getNextEntry();
    //    while (Objects.nonNull(nextEntry))
    //    {
    //        boolean isWaylines = (KmzFileProperties.FILE_DIR_FIRST + "/" + KmzFileProperties.FILE_DIR_SECOND_WAYLINES).equals(nextEntry.getName());
    //        if (!isWaylines)
    //        {
    //            nextEntry = unzipFile.getNextEntry();
    //            continue;
    //        }
    //        SAXReader reader = new SAXReader();
    //        Document document = reader.read(unzipFile);
    //        if (!StandardCharsets.UTF_8.name().equals(document.getXMLEncoding()))
    //        {
    //            throw new RuntimeException("The file encoding format is incorrect.");
    //        }

    //        Node droneNode = document.selectSingleNode("//" + KmzFileProperties.TAG_WPML_PREFIX + KmzFileProperties.TAG_DRONE_INFO);
    //        Node payloadNode = document.selectSingleNode("//" + KmzFileProperties.TAG_WPML_PREFIX + KmzFileProperties.TAG_PAYLOAD_INFO);
    //        if (Objects.isNull(droneNode) || Objects.isNull(payloadNode))
    //        {
    //            throw new RuntimeException("The file format is incorrect.");
    //        }

    //        String type = droneNode.valueOf(KmzFileProperties.TAG_WPML_PREFIX + KmzFileProperties.TAG_DRONE_ENUM_VALUE);
    //        String subType = droneNode.valueOf(KmzFileProperties.TAG_WPML_PREFIX + KmzFileProperties.TAG_DRONE_SUB_ENUM_VALUE);
    //        String payloadType = payloadNode.valueOf(KmzFileProperties.TAG_WPML_PREFIX + KmzFileProperties.TAG_PAYLOAD_ENUM_VALUE);
    //        String payloadSubType = payloadNode.valueOf(KmzFileProperties.TAG_WPML_PREFIX + KmzFileProperties.TAG_PAYLOAD_SUB_ENUM_VALUE);
    //        String templateId = document.valueOf("//" + KmzFileProperties.TAG_WPML_PREFIX + KmzFileProperties.TAG_TEMPLATE_ID);

    //        if (!StringUtils.hasText(type) || !StringUtils.hasText(subType) ||
    //                !StringUtils.hasText(payloadSubType) || !StringUtils.hasText(payloadType) ||
    //                !StringUtils.hasText(templateId))
    //        {
    //            throw new RuntimeException("The file format is incorrect.");
    //        }

    //        return Optional.of(WaylineFileDTO.builder()
    //                .droneModelKey(String.format("%s-%s-%s", DeviceDomainEnum.SUB_DEVICE.getVal(), type, subType))
    //                .payloadModelKeys(List.of(String.format("%s-%s-%s", DeviceDomainEnum.PAYLOAD.getVal(), payloadType, payloadSubType)))
    //                .objectKey(OssConfiguration.objectDirPrefix + File.separator + filename)
    //                .name(filename.substring(0, filename.lastIndexOf(WAYLINE_FILE_SUFFIX)))
    //                .sign(DigestUtils.md5DigestAsHex(file.getInputStream()))
    //                .templateTypes(List.of(Integer.parseInt(templateId)))
    //                .build());
    //    }

    //} catch (IOException | DocumentException e) {
    //    e.printStackTrace();
    //}
    //return Optional.empty();
    //    }
    //    /**
    //     * Convert database entity objects into wayline data transfer object.
    //     * @param entity
    //     * @return
    //     */
    //    private WaylineFileDTO entityConvertToDTO(WaylineFileEntity entity)
    //{
    //    if (entity == null)
    //    {
    //        return null;
    //    }
    //    return WaylineFileDTO.builder()
    //    .droneModelKey(entity.getDroneModelKey())
    //            .favorited(entity.getFavorited())
    //    .name(entity.getName())
    //            .payloadModelKeys(entity.getPayloadModelKeys() != null ?
    //                    Arrays.asList(entity.getPayloadModelKeys().split(",")) : null)
    //            .templateTypes(Arrays.stream(entity.getTemplateTypes().split(","))
    //                    .map(Integer::parseInt)
    //                    .collect(Collectors.toList()))
    //            .username(entity.getUsername())
    //            .objectKey(entity.getObjectKey())
    //            .sign(entity.getSign())
    //            .updateTime(entity.getUpdateTime())
    //            .waylineId(entity.getWaylineId())
    //            .build();

    //}

    ///**
    // * Convert the received wayline object into a database entity object.
    // * @param file
    // * @return
    // */
    //private WaylineFileEntity dtoConvertToEntity(WaylineFileDTO file)
    //{
    //    WaylineFileEntity.WaylineFileEntityBuilder builder = WaylineFileEntity.builder();

    //    if (file != null)
    //    {
    //        builder.droneModelKey(file.getDroneModelKey())
    //                .name(file.getName())
    //                .username(file.getUsername())
    //                .objectKey(file.getObjectKey())
    //                // Separate multiple payload data with ",".
    //                .payloadModelKeys(String.join(",", file.getPayloadModelKeys()))
    //                .templateTypes(file.getTemplateTypes().stream()
    //                        .map(String::valueOf)
    //                        .collect(Collectors.joining(",")))
    //                .favorited(file.getFavorited())
    //                .sign(file.getSign())
    //                .build();
    //    }

    //    return builder.build();
    //}

    //@Override
    //    public Boolean deleteByWaylineId(String workspaceId, String waylineId)
    //{
    //    Optional<WaylineFileDTO> waylineOpt = this.getWaylineByWaylineId(workspaceId, waylineId);
    //    if (waylineOpt.isEmpty())
    //    {
    //        return true;
    //    }
    //    WaylineFileDTO wayline = waylineOpt.get();
    //    boolean isDel = mapper.delete(new LambdaUpdateWrapper<WaylineFileEntity>()
    //    .eq(WaylineFileEntity::getWorkspaceId, workspaceId)
    //                .eq(WaylineFileEntity::getWaylineId, waylineId))
    //            > 0;
    //    if (!isDel)
    //    {
    //        return false;
    //    }
    //    return ossService.deleteObject(OssConfiguration.bucket, wayline.getObjectKey());
    //}

    public async Task<bool> DeleteByWaylineIdAsync(string workspaceId, string waylineId)
    {
        // TODO:

        throw new NotImplementedException();
    }

    public async Task<BaseResponse<IEnumerable<string>>> GetDuplicateNamesAsync(string workspaceId, IEnumerable<string> names)
    {
        var result = BaseResponse<IEnumerable<string>>.Success();

        // TODO:

        return result;
    }

    public Task<Uri> GetFileUrlAsync(string workspaceId, string waylineId)
    {
        // TODO:

        throw new NotImplementedException();
    }

    public Task<WaylineFile> GetWaylineByWaylineIdAsync(string workspaceId, string waylineId)
    {
        // TODO:

        throw new NotImplementedException();
    }

    //    @Override
    //    public PaginationData<WaylineFileDTO> getWaylinesByParam(String workspaceId, WaylineQueryParam param)
    //    {
    //        // Paging Query
    //        Page<WaylineFileEntity> page = mapper.selectPage(
    //                new Page<WaylineFileEntity>(param.getPage(), param.getPageSize()),
    //                new LambdaQueryWrapper<WaylineFileEntity>()
    //                        .eq(WaylineFileEntity::getWorkspaceId, workspaceId)
    //                        .eq(param.isFavorited(), WaylineFileEntity::getFavorited, param.isFavorited())
    //                        .and(param.getTemplateType() != null, wrapper->  {
    //            for (Integer type : param.getTemplateType())
    //            {
    //                wrapper.like(WaylineFileEntity::getTemplateTypes, type).or();
    //            }
    //        })
    //                        // There is a risk of SQL injection
    //                        .last(StringUtils.hasText(param.getOrderBy()), " order by " + param.getOrderBy()));

    //        // Wrap the results of a paging query into a custom paging object.
    //        List<WaylineFileDTO> records = page.getRecords()
    //                .stream()
    //                .map(this::entityConvertToDTO)
    //                .collect(Collectors.toList());

    //        return new PaginationData<>(records, new Pagination(page));
    //    }


 //   /**
 //* Query the basic data of the wayline file according to the query conditions.
 //* The query condition field in pilot is fixed.
 //* @param orderBy   Sorted fields. Spliced at the end of the sql statement.
 //* @param favorited Whether the wayline file is favorited or not.
 //* @param page
 //* @param pageSize
 //* @param templateType
 //* @param workspaceId
 //* @return
 //*/
 //   @GetMapping("/{workspace_id}/waylines")
 //   public ResponseResult<PaginationData<WaylineFileDTO>> getWaylinesPagination(@RequestParam(name = "order_by") String orderBy,
 //                                     @RequestParam(required = false) boolean favorited, @RequestParam Integer page,
 //                                     @RequestParam(name = "page_size", defaultValue = "10") Integer pageSize,
 //                                     @RequestParam(name = "template_type", required = false) Integer[] templateType,
 //                                     @PathVariable(name = "workspace_id") String workspaceId) {
 //       WaylineQueryParam param = WaylineQueryParam.builder()
 //               .favorited(favorited)
 //               .page(page)
 //               .pageSize(pageSize)
 //               .orderBy(orderBy)
 //               .templateType(templateType)
 //               .build();
 //   PaginationData<WaylineFileDTO> data = waylineFileService.getWaylinesByParam(workspaceId, param);
 //       return ResponseResult.success(data);
 //   }

    /// <summary>
    /// Query the basic data of the wayline file according to the query conditions.
    /// The query condition field in pilot is fixed.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="request">request</param>
    /// <returns>waylines</returns>
    public async Task<BaseResponse<PaginationResponse<WaylineFile>>> GetWaylinesAsync(string workspaceId, WaylineQueryRequest request)
    {
        // configure filtering and sorting
        Expression<Func<WaylineFileEntity, bool>> predicate = entity => entity.WorkspaceId == workspaceId;
        
        //// TODO: 
        //if (request.Favorited.HasValue)
        //{ 
        //    predicate = predicate.and
        //}

        var waylineFiles = await _waylineFileRepository.FindAsync(predicate);
        
        var total = await _waylineFileRepository.GetCountAsync();

        var data = new PaginationResponse<WaylineFile> {
            List = _mapper.Map<IEnumerable<WaylineFile>>(waylineFiles),
            Pagination = new Pagination { 
                Page = request.Page, 
                PageSize = request.PageSize,
                Total = total 
            }
        };

        var response = BaseResponse<PaginationResponse<WaylineFile>>.Success(data);

        return response;
    }

    public Task<PaginationResponse<WaylineFile>> GetWaylinesByAsync(string workspaceId, WaylineQueryRequest request)
    {
        // TODO:

        throw new NotImplementedException();
    }

    public async Task<BaseResponse<string>> MarkFavoriteAsync(string workspaceId, IEnumerable<string> ids, bool isFavorite = false)
    {
        var response = BaseResponse<string>.Success(bool.TrueString);

        // TODO:

        return await Task.FromResult(response);
    }

    public Task<int> SaveWaylineFileAsync(string workspaceId, WaylineFile metadata)
    {
        // TODO:

        throw new NotImplementedException();
    }
}
