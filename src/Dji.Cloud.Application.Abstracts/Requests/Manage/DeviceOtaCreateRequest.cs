namespace Dji.Cloud.Application.Abstracts.Requests.Manage;

public class DeviceOtaCreateRequest
{
    public string? SerialNumber { get; set; }

    public string? ProductVersion { get; set; }

    public string? FileUrl { get; set; }

    public string? Md5 { get; set; }

    public long FileSize { get; set; }

    public int FirmwareUpgradeType { get; set; }

    public string? FileName { get; set; }
}
