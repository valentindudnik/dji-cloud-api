using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

public class DeviceLogsEntity : AuditableEntity
{
    public string? LogsId { get; set; }
    public string? UserName { get; set; }
    public string? LogsInfo { get; set; }
    public string? DeviceSerialNumber { get; set; }
    public long HappenTime { get; set; }
    public bool Status { get; set; }
}
