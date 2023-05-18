using AutoMapper;
using Dji.Cloud.Domain.Wayline;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Wayline;

namespace Dji.Cloud.Application.Profiles;

public class WaylineFileProfile : Profile
{
    public WaylineFileProfile()
    {
        CreateMap<WaylineFile, WaylineFileEntity>()
            .ForMember(x => x.WaylineId, opt => opt.MapFrom(x => x.WaylineId))
            .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Name))
            .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.UserName))
            .ForMember(x => x.TemplateTypes, opt => opt.MapFrom(x => x.TemplateTypes))
            .ForMember(x => x.DroneModelKey, opt => opt.MapFrom(x => x.DroneModelKey))
            .ForMember(x => x.PayloadModelKeys, opt => opt.MapFrom(x => x.PayloadModelKeys))
            .ForMember(x => x.Favorited, opt => opt.MapFrom(x => x.Favorited))
            .ForMember(x => x.Sign, opt => opt.MapFrom(x => x.Sign))
            .ForMember(x => x.UpdateTime, opt => opt.MapFrom(x => x.UpdateTime))
            .ForMember(x => x.ObjectKey, opt => opt.MapFrom(x => x.ObjectKey));
    }
}
