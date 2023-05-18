using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Dji.Cloud.Domain.Enums;

[Serializable]
public enum ElementTypeEnum
{
    [Display(Name = "UNKNOWN"),
     EnumMember(Value = "UNKNOWN")]
    Unknown = -1,

    [Display(Name = "POINT"),
     EnumMember(Value = "POINT")]
    Point = 0,

    [Display(Name = "LINE_STRING"),
     EnumMember(Value = "LINE_STRING")]
    LineString = 1,

    [Display(Name = "POLYGON"),
     EnumMember(Value = "POLYGON")]
    Polygon = 2
}
