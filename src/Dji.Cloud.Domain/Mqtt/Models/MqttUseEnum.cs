namespace Dji.Cloud.Domain.Mqtt.Models;

[Serializable]
public enum MqttUseEnum
{
    /// <summary>
    ///The broker is used for basic link. 
    /// </summary>
    Basic = 0,

    /// <summary>
    /// This broker is used for the drc link.
    /// </summary>
    Drc = 1
}
