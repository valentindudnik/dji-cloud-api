using AutoMapper;
using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Application.Commands.Manage;
using Dji.Cloud.Domain.Manage;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

namespace Dji.Cloud.Application.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserLoginRequest, UserLoginCommand>();

        CreateMap<UserEntity, User>()
            .ForMember(x => x.UserId, opt => opt.MapFrom(x => x.UserId))
            .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.UserName))
            .ForMember(x => x.WorkspaceId, opt => opt.MapFrom(x => x.WorkspaceId))
            .ForMember(x => x.UserType, opt => opt.MapFrom(x => x.UserType))
            .ForMember(x => x.MqttUserName, opt => opt.MapFrom(x => x.MqttUserName))
            .ForMember(x => x.MqttPassword, opt => opt.MapFrom(x => x.MqttPassword));
    }
}
