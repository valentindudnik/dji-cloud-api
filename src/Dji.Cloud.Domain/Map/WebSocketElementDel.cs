using Newtonsoft.Json;

namespace Dji.Cloud.Domain.Map;

public class WebSocketElementDel
{
    [JsonProperty("id")]
    public string? ElementId { get; set; }
    [JsonProperty("group_id")]
    public string? GroupId { get; set; }
}
