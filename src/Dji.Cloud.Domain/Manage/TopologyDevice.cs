namespace Dji.Cloud.Domain.Manage;

public class TopologyDevice
{
    public string? SerialNumber { get; set; }

    public bool OnlineStatus { get; set; }

    public string? DeviceCallSign { get; set; }

    public string? UserId { get; set; }

    public string? UserCallSign { get; set; }

    public string? Model { get; set; }

    public bool BoundStatus { get; set; }

    public string? GatewaySerialNumber { get; set; }

    public int Domain { get; set; }
    
    public DeviceModel? DeviceModel { get; set; }

    public IconUrl? IconUrl { get; set; }
}
