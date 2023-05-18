using Dji.Cloud.Domain.Media;

namespace Dji.Cloud.Application.Abstracts.Requests.Media;

public class FileUploadRequest
{
    public FileExtension? Ext { get; set; }

    public string? Fingerprint { get; set; }

    public string? Name { get; set; }

    public string? Path { get; set; }

    public FileMetadata? Metadata { get; set; }

    public string? ObjectKey { get; set; }

    public int SubFileType { get; set; }
}
