namespace Dji.Cloud.Domain.Manage;

public class DeviceFirmware
{
    public string? FirmwareId { get; set; }

    public string? FileName { get; set; }

    public string? ProductVersion { get; set; }

    public string? ObjectKey { get; set; }

    public long FileSize { get; set; }

    public string? FileMd5 { get; set; }

    public IEnumerable<string>? DeviceName { get; set; }

    public string? ReleaseNote { get; set; }

    public DateTime? ReleasedTime { get; set; }

    public bool FirmwareStatus { get; set; }

    public string? WorkspaceId { get; set; }

    public string? UserName { get; set; }
}
