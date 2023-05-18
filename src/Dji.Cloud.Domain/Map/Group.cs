using Newtonsoft.Json;

namespace Dji.Cloud.Domain.Map;

public class Group
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public int? Type { get; set; }

    public IEnumerable<GroupElement>? Elements { get; set; }

    [JsonProperty("is_distributed")]
    public bool? IsDistributed { get; set; }

    [JsonProperty("is_lock")]
    public bool? IsLock { get; set; }

    [JsonProperty("create_time")]
    public long? CreateTime { get; set; }
}
