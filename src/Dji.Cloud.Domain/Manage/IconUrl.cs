using Newtonsoft.Json;

namespace Dji.Cloud.Domain.Manage;

public class IconUrl
{
    [JsonProperty("normal_icon_url")]
    public string? NormalUrl { get; set; }

    [JsonProperty("selected_icon_url")]
    public string? SelectUrl { get; set; }
}
