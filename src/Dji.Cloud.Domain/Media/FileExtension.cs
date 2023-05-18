namespace Dji.Cloud.Domain.Media;

public class FileExtension
{
    public string? DroneModelKey { get; set; }

    public bool IsOriginal { get; set; }

    public string? PayloadModelKey { get; set; }

    public string? TinnyFingerprint { get; set; }

    public string? SerialNumber { get; set; }

    public string? FlightId { get; set; }
}
