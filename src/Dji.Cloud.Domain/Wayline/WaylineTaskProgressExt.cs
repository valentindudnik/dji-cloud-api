namespace Dji.Cloud.Domain.Wayline;

public class WaylineTaskProgressExt
{
    public int CurrentWaypointIndex { get; set; }

    public int MediaCount { get; set; }

    public string? FlightId { get; set; }

    public string? TrackId { get; set; }
}
