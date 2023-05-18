using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Dji.Cloud.Application.Abstracts.Requests.Manage;

public class GetLatestFirmwareNoteRequest
{
    [JsonProperty("device_name")]
    public IEnumerable<string>? DeviceNames { get; set; }
}
