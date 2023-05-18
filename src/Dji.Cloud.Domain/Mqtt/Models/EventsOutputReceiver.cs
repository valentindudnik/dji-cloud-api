namespace Dji.Cloud.Domain.Mqtt.Models;

public class EventsOutputReceiver
{
    public string? Status { get; set; }

    public OutputProgressReceiver? Progress { get; set; }
}
