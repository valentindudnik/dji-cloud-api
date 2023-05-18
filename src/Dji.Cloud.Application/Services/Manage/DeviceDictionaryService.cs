using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Services.Manage;

public class DeviceDictionaryService : IDeviceDictionaryService
{
    //@Autowired
    //private IDeviceDictionaryMapper mapper;

    //@Override
    //public Optional<DeviceDictionaryDTO> getOneDictionaryInfoByTypeSubType(Integer domain, Integer deviceType, Integer subType)
    //{
    //    if (domain == null || deviceType == null || subType == null)
    //    {
    //        return Optional.empty();
    //    }
    //    return Optional.ofNullable(
    //            entityConvertToDTO(
    //                    mapper.selectOne(
    //                            new LambdaQueryWrapper<DeviceDictionaryEntity>()
    //                                    .eq(DeviceDictionaryEntity::getDomain, domain)
    //                                    .eq(DeviceDictionaryEntity::getDeviceType, deviceType)
    //                                    .eq(DeviceDictionaryEntity::getSubType, subType)
    //                                    .last(" limit 1 "))));
    //}

    ///**
    // * Convert database entity objects into dictionary data transfer object.
    // * @param entity
    // * @return
    // */
    //private DeviceDictionaryDTO entityConvertToDTO(DeviceDictionaryEntity entity)
    //{
    //    DeviceDictionaryDTO.DeviceDictionaryDTOBuilder builder = DeviceDictionaryDTO.builder();

    //    if (entity != null)
    //    {
    //        builder.deviceName(entity.getDeviceName())
    //                .deviceDesc(entity.getDeviceDesc())
    //                .deviceType(entity.getDeviceType())
    //                .domain(entity.getDomain())
    //                .subType(entity.getSubType());
    //    }
    //    return builder.build();
    //}
    public Task<DeviceDictionary> GetOneDictionaryInfoByTypeSubTypeAsync(int domain, int deviceType, int subType)
    {
        throw new NotImplementedException();
    }
}
