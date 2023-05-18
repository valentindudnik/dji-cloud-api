using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Dji.Cloud.Domain.Mqtt.Models;

[Serializable]
public enum StateData
{
    [Display(Name = "FIRMWARE_VERSION", Description = "Firmware version"),
     EnumMember(Value = "firmware_version")]
    FirmwareVersion = 0,

    [Display(Name = "LIVE_CAPACITY", Description = "Live capacity"),
     EnumMember(Value = "live_capacity")]
    LiveCapacity = 1,

    [Display(Name = "PAYLOADS", Description = "Payloads"),
     EnumMember(Value = "payloads")]
    Payloads = 2
}
