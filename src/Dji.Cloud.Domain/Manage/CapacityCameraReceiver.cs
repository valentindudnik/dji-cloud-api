using Newtonsoft.Json;

namespace Dji.Cloud.Domain.Manage;

public class CapacityCameraReceiver
{
    public int AvailableVideoNumber { get; set; }

    public int CoexistVideoNumberMax { get; set; }

    public string? CameraIndex { get; set; }

    [JsonProperty("video_list")]
    public IEnumerable<CapacityVideoReceiver>? VideosList { get; set; }
}
