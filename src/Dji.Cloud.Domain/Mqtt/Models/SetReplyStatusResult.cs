namespace Dji.Cloud.Domain.Mqtt.Models;

[Serializable]
public enum SetReplyStatusResult
{
    //SUCCESS(0, "success"),
    Success = 0,

    //FAILED(1, "failed"),
    Failed = 1,

    //TIMEOUT(2, "timeout"),
    Timeout = 2,

    //UNKNOWN(-1, "unknown");
    Unknown = 3
}
