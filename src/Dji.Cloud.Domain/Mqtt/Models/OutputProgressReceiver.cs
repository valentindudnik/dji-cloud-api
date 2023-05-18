namespace Dji.Cloud.Domain.Mqtt.Models;

public class OutputProgressReceiver
{
    public int Percent { get; set; }

    public string? StepKey { get; set; }

    public int StepResult { get; set; }
}
