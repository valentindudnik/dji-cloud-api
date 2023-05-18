using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Dji.Cloud.Domain.Enums;

[Serializable]
public enum DeviceDomains
{
    [Display(Name = "SUB_DEVICE"),
     EnumMember(Value = "SUB_DEVICE")]
    SubDevice = 0,
    
    [Display(Name = "GATEWAY"),
     EnumMember(Value = "GATEWAY")]
    Gateway = 1,

    [Display(Name = "PAYLOAD"),
     EnumMember(Value = "PAYLOAD")]
    Payload = 2,

    [Display(Name = "DOCK"),
     EnumMember(Value = "DOCK")]
    Dock = 3
}
