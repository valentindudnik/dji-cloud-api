namespace Dji.Cloud.Domain.Mqtt.Models;

[Serializable]
public enum EventsResultStatus
{
    //SENT("sent", false),
    Sent = 0,
    
    //IN_PROGRESS("in_progress", false),
    InProgress = 1,

    //OK("ok", true),
    Ok = 2,

    //PAUSED("paused", false),
    Paused = 3,

    //REJECTED("rejected", true),
    Rejected = 4,

    //FAILED("failed", true),
    Failed = 5,

    //CANCELED("canceled", true),
    Canceled = 6,

    //TIMEOUT("timeout", true),
    Timeout = 7,

    //PARTIALLY_DONE("partially_done", true),
    PartiallyDone = 8,

    //UNKNOWN("unknown", false);
    Unknown = 9
}
