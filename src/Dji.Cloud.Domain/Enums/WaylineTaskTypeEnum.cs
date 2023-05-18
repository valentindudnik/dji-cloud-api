using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Dji.Cloud.Domain.Enums;

[Serializable]
public enum WaylineTaskTypeEnum
{
    [Display(Name = "IMMEDIATE"),
     EnumMember(Value = "IMMEDIATE")]
    Immediate = 0,

    [Display(Name = "TIMED"),
     EnumMember(Value = "TIMED")]    
    Timed = 1
}
