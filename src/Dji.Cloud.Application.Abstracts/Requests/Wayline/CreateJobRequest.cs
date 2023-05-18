namespace Dji.Cloud.Domain.Wayline;

public class CreateJobRequest
{
    public string? Name { get; set; }

    public string? FieldId { get; set; }

    public string? DockSerialNumber { get; set; }

    public int WaylineType { get; set; }

    public int TaskType { get; set; }

    public long ExecuteTime { get; set; }

    public int RthAltitude { get; set; }

    public int OutOfControlAction { get; set; }
}
