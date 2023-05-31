using Dji.Cloud.Application.Abstracts.Requests.Common;

namespace Dji.Cloud.Application.Abstracts.Requests.Manage;

public class DeviceHmsQueryRequest : PaginationRequest
{
    public IEnumerable<string>? SerialNumber { get; set; }
    public long? UpdateTime { get; set; }
    public long? BeginTime { get; set; }
    public long? EndTime { get; set; }
    public string? Language { get; set; }
    public string? Message { get; set; }
    public int? Level { get; set; }
}
