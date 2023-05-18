using Newtonsoft.Json;

namespace Dji.Cloud.Domain.Manage;

public class LiveType
{
    [JsonProperty("url_type")]
    public int UrlType { get; set; }

    [JsonProperty("url")]
    public string? Url { get; set; }

    [JsonProperty("video_id")]
    public string? VideoId { get; set; }

    [JsonProperty("video_quality")]
    public int VideoQuality { get; set; }

    [JsonProperty("video_type")]
    public string? VideoType { get; set; }
}
