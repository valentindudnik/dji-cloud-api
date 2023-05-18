using Newtonsoft.Json;

namespace Dji.Cloud.Application.Abstracts.Requests.Common;

public class PaginationRequest
{
    [JsonProperty("page")]
    public int Page { get; set; }

    [JsonProperty("page_size")]
    public int PageSize { get; set; } = 10;
}
