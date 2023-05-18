namespace Dji.Cloud.Domain.Manage;

public class LogsProgressReceiver
{
    public int CurrentStep { get; set; }

    public int TotalStep { get; set; }

    public int Progress { get; set; }

    public long FinishTime { get; set; }

    public float UploadRate { get; set; }

    public string? Status { get; set; }

    public int Result { get; set; }
}
