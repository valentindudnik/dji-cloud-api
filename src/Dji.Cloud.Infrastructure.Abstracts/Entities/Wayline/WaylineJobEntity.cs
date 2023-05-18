using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Wayline;

public class WaylineJobEntity : AuditableEntity
{
    public string? JobId { get; set; }
    public string? Name { get; set; }
    public string? FileId { get; set; }
    public string? DockSerialNumber { get; set; }
    public string? WorkspaceId { get; set; }
    public int TaskType { get; set; }
    public int WaylineType { get; set; }
    public string? UserName { get; set; }
    public long ExecuteTime { get; set; }
    public long EndTime { get; set; }
    public int ErrorCode { get; set; }
    public int Status { get; set; }
    public int RthAltitude { get; set; }
    public int OutOfControlAction { get; set; }
    public int MediaCount { get; set; }
    public long BeginTime { get; set; }
    public long CompletedTime { get; set; }
    public string? ParentId { get; set; }
}
