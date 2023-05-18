using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

public class LogsFileIndexEntity : AuditableEntity
{
    public int BootIndex { get; set; }
    public string? FileId { get; set; }
    public long StartTime { get; set; }
    public long EndTime { get; set; }
    public long Size { get; set; }
    public string? DeviceSerialNumber { get; set; }
    public int Domain { get; set; }
}
