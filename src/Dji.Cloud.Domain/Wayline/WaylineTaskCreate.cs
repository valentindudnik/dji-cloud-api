namespace Dji.Cloud.Domain.Wayline;

public class WaylineTaskCreate
{
    public string? FlightId { get; set; }

    public int TaskType { get; set; }

    public int WaylineType { get; set; }

    public long? ExecuteTime { get; set; }

    public WaylineTaskFile? File { get; set; }

    public int RthAltitude { get; set; }

    public int OutOfControlAction { get; set; }
}
