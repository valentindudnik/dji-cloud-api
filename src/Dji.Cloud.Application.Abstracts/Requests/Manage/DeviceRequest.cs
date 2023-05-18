namespace Dji.Cloud.Application.Abstracts.Requests.Manage;

public class DeviceRequest
{
    public string? DeviceSerialNumber { get; set; }

    public string? WorkspaceId { get; set; }

    public int DeviceType { get; set; }

    public int SubType { get; set; }

    public IEnumerable<int>? Domains { get; set; }

    public string? ChildSerialNumber { get; set; }

    public bool BoundStatus { get; set; }

    public bool OrderBy { get; set; }

    public bool IsAsc { get; set; }
}
