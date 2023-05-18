using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Dji.Cloud.Domain.Enums;

[Serializable]
public enum BatteryStoreModes
{
    [Display(Name = "None", Description = "None"),
     EnumMember(Value = "None")]
    None = 0,

    [Display(Name = "PLAN", Description = "Plan"),
     EnumMember(Value = "PLAN")]
    Plan = 1,
    
    [Display(Name = "EMERGENCY", Description = "Emergency"),
     EnumMember(Value = "EMERGENCY")]
    Emergency = 2
}
