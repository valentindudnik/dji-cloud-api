namespace Dji.Cloud.Domain.Manage;

public class FirmwareModel
{
    public string? FirmwareId { get; set; }

    public IEnumerable<string>? DeviceNames { get; set; }
}
