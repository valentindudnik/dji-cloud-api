namespace Dji.Cloud.Domain.Mqtt.Models;

public class EventsReceiver<T>
{
    public int Result { get; set; }

    public T? Output { get; set; }

    public string? Bid { get; set; }

    public string? SerialNumber { get; set; }
}
