using Dji.Cloud.Domain.Enums;

namespace Dji.Cloud.Domain.Redis;

public static class RedisConst
{
    public const int WaylineJobBlockTime = 600;

    public const string Delimiter = ":";

    public const int DeviceAliveSecond = 60;

    public const int WebsocketAliveSecond = 60 * 60 * 24;

    public static string OnlinePrefix = $"online{Delimiter}";

    public static string DeviceOnlinePrefix = $"{OnlinePrefix}{DeviceDomains.SubDevice}{Delimiter}";

    public static string WebsocketPrefix = $"webSocket{Delimiter}";

    public static string WebsocketAll = $"{WebsocketPrefix}all";

    public static string HmsPrefix = $"hms{Delimiter}";

    public static string FirmwareUpgradingPrefix = $"upgrading{Delimiter}";

    public static string StatePayloadPrefix = $"payload{Delimiter}";

    public static string LogsFilePrefix = $"logs_file{Delimiter}";

    public static string WaylineJobTimedExecute = "wayline_job_timed_execute";

    public static string WaylineJobBlockPrefix = $"wayline_job_block{Delimiter}";

    public static string WaylineJobRunningPrefix = $"wayline_job_running{Delimiter}";

    public static string WaylineJobPausedPrefix = $"wayline_job_paused{Delimiter}";

    public static string OsdPrefix = $"osd{Delimiter}";

    public static string MediaFilePrefix = $"media_file{Delimiter}";

    public static string MediaHighestPriorityPrefix = $"media_highest_priority{Delimiter}";

    public const string LiveCapacity = "live_capacity";

    public static string MqttAclPrefix = $"mqtt_acl{Delimiter}";

    public static string FileUploadingPrefix = $"file_uploading{Delimiter}";
}
