using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Services.Manage;

public class FirmwareModelService : IFirmwareModelService
{
    //@Autowired
    //private IFirmwareModelMapper mapper;

    //@Override
    //public void saveFirmwareDeviceName(FirmwareModelDTO firmwareModel)
    //{
    //    dto2Entity(firmwareModel).forEach(entity->mapper.insert(entity));
    //}

    //private List<FirmwareModelEntity> dto2Entity(FirmwareModelDTO dto)
    //{
    //    if (Objects.isNull(dto) || CollectionUtils.isEmpty(dto.getDeviceNames()))
    //    {
    //        return Collections.EMPTY_LIST;
    //    }
    //    return dto.getDeviceNames().stream()
    //            .map(deviceName->FirmwareModelEntity.builder()
    //                    .firmwareId(dto.getFirmwareId())
    //                    .deviceName(deviceName).build())
    //            .collect(Collectors.toList());
    //}
    public Task SaveFirmwareDeviceNameAsync(FirmwareModel firmwareModel)
    {
        throw new NotImplementedException();
    }
}
