using Newtonsoft.Json;

namespace Dji.Cloud.Domain.Wayline;

public class WaylineQueryRequest
{
    [JsonProperty("favorited")]
    public bool? Favorited { get; set; }

    [JsonProperty("page")]
    public int Page { get; set; } = 1;

    [JsonProperty("page_size")]
    public int PageSize { get; set; } = 10;

    [JsonProperty("order_by")]
    public string? OrderBy { get; set; }

    [JsonProperty("template_type")]
    public int[]? TemplateType { get; set; }

    [JsonProperty("workspace_id")]
    public string? WorkspaceId { get; set; }
}
