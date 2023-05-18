namespace Dji.Cloud.Application.Abstracts.Requests.Media;

public class FileUploadCallbackRequest
{
    public int Result { get; set; }

    public int Progress { get; set; }

    public FileUploadRequest? File { get; set; }
}
