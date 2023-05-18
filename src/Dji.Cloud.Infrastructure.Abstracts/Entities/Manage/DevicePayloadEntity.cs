using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

public class DevicePayloadEntity : AuditableEntity
{
    public string? PayloadSerialNumber { get; set; }
    public string? PayloadName { get; set; }
    public int PayloadType { get; set; }
    public int SubType { get; set; }
    public string? FirmwareVersion { get; set; }
    public int PayloadIndex { get; set; }
    public string? DeviceSerialNumber { get; set; }
    public string? PayloadDesc { get; set; }
}
