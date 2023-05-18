namespace Dji.Cloud.Domain.Manage;

public class Device
{
    public string? DeviceSerialNumber { get; set; }
    public string? DeviceName { get; set; }
    public string? WorkspaceId { get; set; }
    public string? DeviceIndex { get; set; }
    public string? DeviceDesc { get; set; }
    public string? ChildDeviceSerialNumber { get; set; }
    public int Domain { get; set; }
    public int Type { get; set; }
    public int SubType { get; set; }
    public IEnumerable<DevicePayload>? Payloads { get; set; }
    public IconUrl? IconUrl { get; set; }
    public bool Status { get; set; }
    public bool BoundStatus { get; set; }
    public string? NickName { get; set; }
    public string? UserId { get; set; }
    public string? FirmwareVersion { get; set; }
    public string? WorkspaceName { get; set; }
    public int FirmwareStatus { get; set; }
    public int FirmwareProgress { get; set; }
    public DateTime? LoginTime { get; set; }
    public DateTime? BoundTime { get; set; }
    public Device? Children { get; set; }
}
