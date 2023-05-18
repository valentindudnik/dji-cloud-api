using Dji.Cloud.Domain.Enums;

namespace Dji.Cloud.Domain.Manage;

public class FirmwareVersionReceiver
{
    public string? FirmwareVersion { get; set; }

    public int CompatibleStatus { get; set; }

    public int FirmwareUpgradeStatus { get; set; }

    public string? SerialNumber { get; set; }

    public DeviceDomains Domain { get; set; }
}
