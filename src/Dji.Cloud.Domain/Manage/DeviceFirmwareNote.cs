namespace Dji.Cloud.Domain.Manage;

public class DeviceFirmwareNote
{
    public string? DeviceName { get; set; }

    public string? ProductVersion { get; set; }

    public string? ReleaseNote { get; set; }

    public DateTime ReleasedTime { get; set; }
}
