namespace Dji.Cloud.Domain.Wayline;

public class WaylineJob
{
    public string? JobId { get; set; }

    public string? JobName { get; set; }

    public string? FileId { get; set; }

    public string? FileName { get; set; }

    public string? DockSerialNumber { get; set; }

    public string? DockName { get; set; }

    public string? WorkspaceId { get; set; }

    public int WaylineType { get; set; }

    public int TaskType { get; set; }

    public DateTime ExecuteTime { get; set; }

    public DateTime BeginTime { get; set; }

    public DateTime EndTime { get; set; }

    public DateTime CompletedTime { get; set; }

    public int Status { get; set; }

    public int Progress { get; set; }

    public string? UserName { get; set; }

    public int Code { get; set; }

    public int RthAltitude { get; set; }

    public int OutOfControlAction { get; set; }

    public int MediaCount { get; set; }

    public int UploadedCount { get; set; }

    public bool Uploading { get; set; }

    public string? ParentId { get; set; }
}
