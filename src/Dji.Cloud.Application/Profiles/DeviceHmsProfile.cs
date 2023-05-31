using AutoMapper;
using Dji.Cloud.Domain.Manage;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

namespace Dji.Cloud.Application.Profiles;

public class DeviceHmsProfile : Profile
{
    public DeviceHmsProfile()
    {
        CreateMap<DeviceHmsEntity, DeviceHms>()
            .ForMember(x => x.Bid, opt => opt.MapFrom(x => x.Bid))
            .ForMember(x => x.Tid, opt => opt.MapFrom(x => x.Tid))
            .ForMember(x => x.SerialNumber, opt => opt.MapFrom(x => x.SerialNumber))
            .ForMember(x => x.HmsId, opt => opt.MapFrom(x => x.HmsId))
            .ForMember(x => x.Key, opt => opt.MapFrom(x => x.HmsKey))
            .ForMember(x => x.Level, opt => opt.MapFrom(x => x.Level))
            .ForMember(x => x.Module, opt => opt.MapFrom(x => x.Module))
            .ForMember(x => x.MessageEn, opt => opt.MapFrom(x => x.MessageEn))
            .ForMember(x => x.MessageZh, opt => opt.MapFrom(x => x.MessageZh))
            .ForMember(x => x.UpdateTime, opt => opt.MapFrom(x => DateTime.FromBinary(x.UpdateTime!.Value)))
            .ForMember(x => x.CreateTime, opt => opt.MapFrom(x => DateTime.FromBinary(x.CreateTime)));
    }
}
