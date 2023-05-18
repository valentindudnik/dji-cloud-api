namespace Dji.Cloud.Domain.Manage;

public class DeviceFirmwareUpgrade
{
    public string? DeviceName { get; set; }

    public string? SerialNumber { get; set; }

    public string? ProductVersion { get; set; }

    public int FirmwareUpgradeType { get; set; }
}
