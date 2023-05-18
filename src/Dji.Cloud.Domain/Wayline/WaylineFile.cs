using Newtonsoft.Json;

namespace Dji.Cloud.Domain.Wayline;

public class WaylineFile
{
    [JsonProperty("id")]
    public string? WaylineId { get; set; }

    public string? Name { get; set; }

    public string? DroneModelKey { get; set; }

    public string? Sign { get; set; }

    public IEnumerable<string>? PayloadModelKeys { get; set; }

    public bool? Favorited { get; set; }

    public IEnumerable<int>? TemplateTypes { get; set; }

    public string? ObjectKey { get; set; }

    [JsonProperty("user_name")]
    public string? UserName { get; set; }

    public long? UpdateTime { get; set; }
}
