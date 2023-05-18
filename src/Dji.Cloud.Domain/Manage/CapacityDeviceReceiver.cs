namespace Dji.Cloud.Domain.Manage;

public class CapacityDeviceReceiver
{
    public string? SerialNumber { get; set; }

    public int AvailableVideoNumber { get; set; }

    public int CoexistVideoNumberMax { get; set; }

    public IEnumerable<CapacityCameraReceiver>? CameraList { get; set; }
}
