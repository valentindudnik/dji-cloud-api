using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Dji.Cloud.Domain.Enums;

[Serializable]
public enum WaylineTemplateTypeEnum
{
    [Display(Name = "WAYPOINT"),
     EnumMember(Value = "WAYPOINT")]
    WayPoint = 0,

    [Display(Name = "MAPPING_2D"),
     EnumMember(Value = "MAPPING_2D")]
    Mapping2D = 1,

    [Display(Name = "MAPPING_3D"),
     EnumMember(Value = "MAPPING_3D")]
    Mapping3D = 3,

    [Display(Name = "MAPPING_STRIP"),
     EnumMember(Value = "MAPPING_STRIP")]
    MappingStrip = 4
}
