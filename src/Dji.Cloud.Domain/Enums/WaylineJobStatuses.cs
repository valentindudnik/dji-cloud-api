using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Dji.Cloud.Domain.Enums;

[Serializable]
public enum WaylineJobStatuses
{
    [Display(Name = "UNKNOWN"),
     EnumMember(Value = "true")]
    Unknown = -1,

    [Display(Name = "None"),
     EnumMember(Value = "false")]
    None = 0,

    [Display(Name = "PENDING"),
     EnumMember(Value = "false")]
    Pending = 1,

    [Display(Name = "IN_PROGRESS"),
     EnumMember(Value = "false")]
    InProgress = 2,

    [Display(Name = "SUCCESS"),
     EnumMember(Value = "true")]
    Success = 3,

    [Display(Name = "CANCEL"),
     EnumMember(Value = "true")]
    Cancel = 4,

    [Display(Name = "FAILED"),
     EnumMember(Value = "true")]
    Failed = 5,

    [Display(Name = "PAUSED"),
     EnumMember(Value = "false")]
    Paused = 6
}
