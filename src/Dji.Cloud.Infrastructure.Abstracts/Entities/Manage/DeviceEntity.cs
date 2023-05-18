using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

public class DeviceEntity : AuditableEntity
{
    public string? SerialNumber { get; set; }
    public string? DeviceName { get; set; }
    public string? WorkspaceId { get; set; }
    public int DeviceType { get; set; }
    public int SubType { get; set; }
    public int Domain { get; set; }
    public int Version { get; set; }
    public string? DeviceIndex { get; set; }
    public string? ChildSerialNumber { get; set; }
    public string? DeviceDesc { get; set; }
    public string? UrlNormal { get; set; }
    public string? UrlSelect { get; set; }
    public string? UserId { get; set; }
    public string? NickName { get; set; }
    public string? FirmwareVersion { get; set; }
    public bool CompatibleStatus { get; set; }
    public bool BoundStatus { get; set; }
    public long BoundTime { get; set; }
    public long LoginTime { get; set; }
}
