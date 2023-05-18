using AutoMapper;
using Dji.Cloud.Domain.Manage;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

namespace Dji.Cloud.Application.Profiles;

public class DeviceProfile : Profile
{
    public DeviceProfile()
    {
        CreateMap<DeviceEntity, Device>()
            .ForMember(x => x.WorkspaceId, opt => opt.MapFrom(x => x.WorkspaceId))
            .ForMember(x => x.DeviceIndex, opt => opt.MapFrom(x => x.DeviceIndex))
            .ForMember(x => x.DeviceName, opt => opt.MapFrom(x => x.DeviceName))
            .ForMember(x => x.DeviceSerialNumber, opt => opt.MapFrom(x => x.SerialNumber))
            .ForMember(x => x.DeviceDesc, opt => opt.MapFrom(x => x.DeviceDesc))
            .ForMember(x => x.ChildDeviceSerialNumber, opt => opt.MapFrom(x => x.ChildSerialNumber))
            .ForMember(x => x.SubType, opt => opt.MapFrom(x => x.SubType))
            .ForMember(x => x.Domain, opt => opt.MapFrom(x => x.Domain))
            .ForMember(x => x.BoundStatus, opt => opt.MapFrom(x => x.BoundStatus))
            .ForMember(x => x.LoginTime, opt => opt.MapFrom(x => x.LoginTime))
            .ForMember(x => x.NickName, opt => opt.MapFrom(x => x.NickName))
            .ForMember(x => x.FirmwareVersion, opt => opt.MapFrom(x => x.FirmwareVersion));
    }
}

///**
// * Convert database entity object into device data transfer object.
// * @param entity
// * @return
// */
//private DeviceDTO deviceEntityConvertToDTO(DeviceEntity entity)
//{
//    if (entity == null)
//    {
//        return null;
//    }
//    DeviceDTO.DeviceDTOBuilder deviceDTOBuilder = DeviceDTO.builder()
//            .deviceSn(entity.getDeviceSn())
//            .childDeviceSn(entity.getChildSn())
//    .deviceName(entity.getDeviceName())
//    .deviceDesc(entity.getDeviceDesc())
//            .deviceIndex(entity.getDeviceIndex())
//            .workspaceId(entity.getWorkspaceId())
//            .type(entity.getDeviceType())
//    .subType(entity.getSubType())
//    .domain(entity.getDomain())
//            .iconUrl(IconUrlDTO.builder()
//                    .normalUrl(entity.getUrlNormal())
//                    .selectUrl(entity.getUrlSelect())
//                    .build())
//            .boundStatus(entity.getBoundStatus())
//            .loginTime(entity.getLoginTime() != null ?
//                    LocalDateTime.ofInstant(Instant.ofEpochMilli(entity.getLoginTime()), ZoneId.systemDefault())
//                    : null)
//            .boundTime(entity.getBoundTime() != null ?
//                    LocalDateTime.ofInstant(Instant.ofEpochMilli(entity.getBoundTime()), ZoneId.systemDefault())
//                    : null)
//            .nickname(entity.getNickname())
//            .firmwareVersion(entity.getFirmwareVersion())
//            .workspaceName(entity.getWorkspaceId() != null ?
//                    workspaceService.getWorkspaceByWorkspaceId(entity.getWorkspaceId())
//                            .map(WorkspaceDTO::getWorkspaceName).orElse("") : "");

//    if (!StringUtils.hasText(entity.getFirmwareVersion()))
//    {
//        return deviceDTOBuilder.firmwareStatus(DeviceFirmwareStatusEnum.NOT_UPGRADE.getVal()).build();
//    }
//    // Query whether the device is updating firmware.
//    Object progress = RedisOpsUtils.get(RedisConst.FIRMWARE_UPGRADING_PREFIX + entity.getDeviceSn());
//    if (Objects.nonNull(progress))
//    {
//        return deviceDTOBuilder.firmwareStatus(DeviceFirmwareStatusEnum.UPGRADING.getVal()).firmwareProgress((int)progress).build();
//    }

//    // First query the latest firmware version of the device model and compare it with the current firmware version
//    // to see if it needs to be upgraded.
//    Optional<DeviceFirmwareNoteDTO> firmwareReleaseNoteOpt = deviceFirmwareService.getLatestFirmwareReleaseNote(entity.getDeviceName());
//    if (firmwareReleaseNoteOpt.isPresent())
//    {
//        DeviceFirmwareNoteDTO firmwareNoteDTO = firmwareReleaseNoteOpt.get();
//        if (firmwareNoteDTO.getProductVersion().equals(entity.getFirmwareVersion()))
//        {
//            return deviceDTOBuilder.firmwareStatus(entity.getCompatibleStatus() ?
//                    DeviceFirmwareStatusEnum.NOT_UPGRADE.getVal() :
//                    DeviceFirmwareStatusEnum.CONSISTENT_UPGRADE.getVal()).build();
//        }

//        return deviceDTOBuilder.firmwareStatus(DeviceFirmwareStatusEnum.NORMAL_UPGRADE.getVal()).build();
//    }
//    return deviceDTOBuilder.firmwareStatus(DeviceFirmwareStatusEnum.NOT_UPGRADE.getVal()).build();
//}