using Newtonsoft.Json;

namespace Dji.Cloud.Domain.Map;

public class ContentProperty
{
    public string? Color { get; set; }

    [JsonProperty("clampToGround")]
    public bool ClampToGround { get; set; }
}
