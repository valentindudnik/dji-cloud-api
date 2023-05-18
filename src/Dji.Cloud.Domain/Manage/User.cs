using Newtonsoft.Json;

namespace Dji.Cloud.Domain.Manage;

public class User
{   
    [JsonProperty("user_id")]
    public string? UserId { get; set; }

    [JsonProperty("username")]
    public string? UserName { get; set; }

    [JsonProperty("workspace_id")]
    public string? WorkspaceId { get; set; }

    [JsonProperty("user_type")]
    public int UserType { get; set; }

    [JsonProperty("mqtt_username")]
    public string? MqttUserName { get; set; }

    [JsonProperty("mqtt_password")]
    public string? MqttPassword { get; set; }

    [JsonProperty("access_token")]
    public string? AccessToken { get; set; }

    [JsonProperty("mqtt_addr")]
    public string? MqttAddr { get; set; }
}
