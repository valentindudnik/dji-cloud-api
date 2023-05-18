using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Media;

public class MediaFileEntity : AuditableEntity
{
    public string? FileId { get; set; }
    public string? FileName { get; set; }
    public string? FilePath { get; set; }
    public string? WorkspaceId { get; set; }
    public string? Fingerprint { get; set; }
    public string? TinnyFingerprint { get; set; }
    public string? ObjectKey { get; set; }
    public int SubFileType { get; set; }
    public bool IsOriginal { get; set; }
    public string? Drone { get; set; }
    public string? Payload { get; set; }
    public string? JobId { get; set; }
}
