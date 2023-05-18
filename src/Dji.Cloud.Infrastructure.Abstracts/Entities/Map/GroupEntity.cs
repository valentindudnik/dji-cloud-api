using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Map;

public class GroupEntity : AuditableEntity
{
    public string? GroupId { get; set; }
    public string? GroupName { get; set; }
    public int GroupType { get; set; }
    public string? WorkspaceId { get; set; }
    public bool IsDistributed { get; set; }
    public bool IsLock { get; set; }
}
