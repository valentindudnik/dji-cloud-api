namespace Dji.Cloud.Domain.Manage;

public class CapacityCamera
{
    public string? Id { get; set; }

    public string? DeviceSerialNumber { get; set; }

    public string? Name { get; set; }

    public string? Index { get; set; }

    public string? Type { get; set; }

    public IEnumerable<CapacityVideo>? Videos { get; set; }
}
