namespace Dji.Cloud.Domain.Mqtt.Models;

public class MqttClientOptions
{
    public MqttProtocolEnum Protocol { get; set; }

    public string? Host { get; set; }

    public int Port { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? ClientId { get; set; }

    public string? Path { get; set; }

    public string? InboundTopic { get; set; }
}
