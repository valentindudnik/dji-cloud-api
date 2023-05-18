using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Dji.Cloud.Domain.Enums;

[Serializable]
public enum LinkWorkModes
{
    [Display(Name = "SDR_ONLY", Description = "Sdr only"),
     EnumMember(Value = "SDR_ONLY")]
    SdrOnly = 0,

    [Display(Name = "SDR_WITH_4G", Description = "Sdr with 4G"),
     EnumMember(Value = "SDR_WITH_4G")]
    SdrWith4G = 1
}
