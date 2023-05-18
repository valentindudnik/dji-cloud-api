using Newtonsoft.Json;

namespace Dji.Cloud.Domain.Mqtt.Models;

public class CommonTopicResponse<TEntity> where TEntity : class 
{
    [JsonProperty("tid")]
    public string? TopicId { get; set; }

    [JsonProperty("bid")]
    public string? Bid { get; set; }

    [JsonProperty("method")]
    public string? Method { get; set; }

    [JsonProperty("data")]
    public TEntity? Data { get; set; }

    [JsonProperty("timestamp")]
    public long Timestamp { get; set; }
}
