using Newtonsoft.Json;

namespace Dji.Cloud.Domain.Map;

public class GroupElement
{
    public int Display { get; set; }
    [JsonProperty("id")]
    public string? ElementId { get; set; }
    public string? Name { get; set; }
    [JsonProperty("create_time")]
    public long CreateTime { get; set; }
    [JsonProperty("update_time")]
    public long UpdateTime { get; set; }
    public ElementResource? Resource { get; set; }
    [JsonProperty("group_id")]
    public string? GroupId { get; set; }
}
