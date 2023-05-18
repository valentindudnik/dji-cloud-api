namespace Dji.Cloud.Domain.Wayline;

public class WaylineFileUpload
{
    public string? ObjectKey { get; set; }

    public string? Name { get; set; }

    public WaylineFile? Metadata { get; set; }
}
