using AutoMapper;
using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Profiles;

public class TopologyDeviceProfile : Profile
{
    public TopologyDeviceProfile()
    { 
        //CreateMap<DeviceProfile, TopologyDevice>()
        //    .ForMember(x => x.SerialNumber, opt => opt)
    }
}



//public TopologyDeviceDTO deviceConvertToTopologyDTO(DeviceDTO device)
    //    {
    //        TopologyDeviceDTO.TopologyDeviceDTOBuilder builder = TopologyDeviceDTO.builder();

//        if (device != null)
//        {
//            builder.sn(device.getDeviceSn())
//                    .deviceCallsign(device.getNickname())
//                    .deviceModel(DeviceModelDTO.builder()
//                            .domain(String.valueOf(device.getDomain()))
//                            .subType(String.valueOf(device.getSubType()))
//                            .type(String.valueOf(device.getType()))
//                            .key(device.getDomain() + "-" + device.getType() + "-" + device.getSubType())
//                            .build())
//                    .iconUrls(device.getIconUrl())
//                    .onlineStatus(RedisOpsUtils.checkExist(RedisConst.DEVICE_ONLINE_PREFIX + device.getDeviceSn()))
//                    .boundStatus(device.getBoundStatus())
//                    .model(device.getDeviceName())
//                    .userId(device.getUserId())
//                    .domain(device.getDomain())
//                    .build();
//        }
//        return builder.build();
//    }