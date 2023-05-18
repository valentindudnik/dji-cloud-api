namespace Dji.Cloud.Domain.Media;

public class FileMetadata
{
    public double AbsoluteAltitude { get; set; }

    public DateTime CreatedTime { get; set; }

    public double GimbalYawDegree { get; set; }

    public Position? PhotoedPosition { get; set; }

    public Position? ShootPosition { get; set; }

    public double RelativeAltitude { get; set; }
}
