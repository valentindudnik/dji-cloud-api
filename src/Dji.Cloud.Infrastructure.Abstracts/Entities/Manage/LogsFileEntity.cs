using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

public class LogsFileEntity : AuditableEntity
{
    public string? FileId { get; set; }
    public string? Name { get; set; }
    public long Size { get; set; }
    public string? LogsId { get; set; }
    public string? DeviceSerialNumber { get; set; }
    public string? Fingerprint { get; set; }
    public string? ObjectKey { get; set; }
    public bool Status { get; set; }
}
