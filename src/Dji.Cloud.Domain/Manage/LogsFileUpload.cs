using Newtonsoft.Json;

namespace Dji.Cloud.Domain.Manage;

public class LogsFileUpload
{
    public string? DeviceSerialNumber { get; set; }

    public IEnumerable<LogsFile>? List { get; set; }

    [JsonProperty("module")]
    public string? DeviceModelDomain { get; set; }

    public string? ObjectKey { get; set; }

    public int? Result { get; set; }

    public string? FileId { get; set; }
}
