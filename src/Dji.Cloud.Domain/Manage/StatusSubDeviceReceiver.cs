using Newtonsoft.Json;

namespace Dji.Cloud.Domain.Manage;

public class StatusSubDeviceReceiver
{
    public string? SerialNumber { get; set; }
    
    public int Domain { get; set; }

    public int Type { get; set; }

    public string? Index { get; set; }

    public string? Nonce { get; set; }

    public int Version { get; set; }

    [JsonProperty("sub_type")]
    public int SubType { get; set; }

    [JsonProperty("device_secret")]
    public string? DeviceSecret { get; set; }
}
