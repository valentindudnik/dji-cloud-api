namespace Dji.Cloud.Domain.Mqtt.Models;

public class ServiceReply<T>
{
    public int Result { get; set; }

    public T? Info { get; set; }

    public T? Output { get; set; }
}
