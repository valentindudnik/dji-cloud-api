using Dji.Cloud.Application.Abstracts.Requests.Common;

namespace Dji.Cloud.Application.Abstracts.Requests.Manage;

public class GetBoundDevicesRequest : PaginationRequest
{
    public int Domain { get; set; }
}
