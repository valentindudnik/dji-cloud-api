namespace Dji.Cloud.Domain.Mqtt.Models;

[Serializable]
public enum MqttProtocolEnum
{
    // MQTT("tcp")
    Mqtt = 0,

    // MQTTS("tcp"),
    Mqtts = 1,

    // WS("ws"),
    Ws = 2,

    // WSS("wss");
    Wss = 3
}
