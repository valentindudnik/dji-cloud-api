namespace Dji.Cloud.Domain.Manage;

public class LiveCapacityReceiver
{
    public int AvailableVideoNumber { get; set; }

    public int CoexistVideoNumberMax { get; set; }

    public IEnumerable<CapacityDeviceReceiver>? DeviceList { get; set; }
}
