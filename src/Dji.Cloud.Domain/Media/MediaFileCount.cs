namespace Dji.Cloud.Domain.Media;

public class MediaFileCount
{
    public string? Tid { get; set; }

    public string? Bid { get; set; }

    public string? PreJobId { get; set; }

    public string? JobId { get; set; }

    public int MediaCount { get; set; }

    public int UploadedCount { get; set; }
}
