using Dji.Cloud.Application.Abstracts.Requests.Common;

namespace Dji.Cloud.Application.Abstracts.Requests.Manage;

public class DeviceFirmwareQueryRequest : PaginationRequest
{
    public string? DeviceName { get; set; }
    public string? ProductVersion { get; set; }
    public bool Status { get; set; }
}
