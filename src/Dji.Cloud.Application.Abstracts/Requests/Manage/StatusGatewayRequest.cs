using Newtonsoft.Json;

namespace Dji.Cloud.Domain.Manage;

public class StatusGatewayRequest
{
    public string? SerialNumber { get; set; }

    public string? Nonce { get; set; }

    public int Domain { get; set; }
    
    public int Type { get; set; }

    public int Version { get; set; }

    [JsonProperty("sub_type")]
    public int SubType { get; set; }

    [JsonProperty("device_secret")]
    public string? DeviceSecret { get; set; }

    [JsonProperty("sub_devices")]
    public IEnumerable<StatusSubDeviceReceiver>? SubDevices { get; set; }
}
