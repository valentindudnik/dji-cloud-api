using AutoMapper;
using Dji.Cloud.Domain.Manage;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

namespace Dji.Cloud.Application.Profiles;

public class WorkspaceProfile : Profile
{
    public WorkspaceProfile()
    {
        CreateMap<WorkspaceEntity, Workspace>()
            .ForMember(x => x.WorkspaceId, opt => opt.MapFrom(x => x.WorkspaceId))
            .ForMember(x => x.WorkspaceName, opt => opt.MapFrom(x => x.WorkspaceName))
            .ForMember(x => x.WorkspaceDesc, opt => opt.MapFrom(x => x.WorkspaceDesc))
            .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id))
            .ForMember(x => x.BindCode, opt => opt.MapFrom(x => x.BindCode))
            .ForMember(x => x.PlatformName, opt => opt.MapFrom(x => x.PlatformName));

        CreateMap<Workspace, WorkspaceEntity>()
          .ForMember(x => x.WorkspaceId, opt => opt.MapFrom(x => x.WorkspaceId))
          .ForMember(x => x.WorkspaceName, opt => opt.MapFrom(x => x.WorkspaceName))
          .ForMember(x => x.WorkspaceDesc, opt => opt.MapFrom(x => x.WorkspaceDesc))
          .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id))
          .ForMember(x => x.BindCode, opt => opt.MapFrom(x => x.BindCode))
          .ForMember(x => x.PlatformName, opt => opt.MapFrom(x => x.PlatformName))
          .ForMember(x => x.CreateTime, opt => opt.MapFrom(x => DateTime.UtcNow))
          .ForMember(x => x.UpdateTime, opt => opt.MapFrom(x => DateTime.UtcNow)); 
    }
}
