using Newtonsoft.Json;

namespace Dji.Cloud.Domain.Manage;

public class LogsExtFileReceiver
{
    [JsonProperty("module")]
    public string? DeviceModelDomain { get; set; }

    public long Size { get; set; }

    public string? DeviceSerialNumber { get; set; }

    public string? Key { get; set; }

    public string? Fingerprint { get; set; }

    public LogsProgressReceiver? Progress { get; set; }
}
