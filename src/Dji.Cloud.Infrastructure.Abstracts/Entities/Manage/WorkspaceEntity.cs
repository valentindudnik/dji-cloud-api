using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

public class WorkspaceEntity : AuditableEntity
{
    public string? WorkspaceId { get; set; }
    public string? WorkspaceName { get; set; }
    public string? WorkspaceDesc { get; set; }
    public string? PlatformName { get; set; }
    public string? BindCode { get; set; }
}
