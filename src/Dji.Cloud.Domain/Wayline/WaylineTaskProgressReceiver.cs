namespace Dji.Cloud.Domain.Wayline;

public class WaylineTaskProgressReceiver
{
    public WaylineTaskProgressExt? Ext { get; set; }

    public WaylineTaskProgress? Progress { get; set; }

    public string? Status { get; set; }
}
