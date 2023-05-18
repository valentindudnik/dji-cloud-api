using Newtonsoft.Json;

namespace Dji.Cloud.Domain.Map;

public class ElementResource
{
    public int Type { get; set; }

    [JsonProperty("user_name")]
    public string? UserName { get; set; }

    public ResourceContent? Content { get; set; }
}
