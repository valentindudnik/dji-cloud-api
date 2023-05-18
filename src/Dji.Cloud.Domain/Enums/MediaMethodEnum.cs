using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Dji.Cloud.Domain.Enums;

[Serializable]
public enum MediaMethodEnum
{
    [Display(Name = "NONE"),
     EnumMember(Value = "None")]
    None = 0,

    [Display(Name = "UPLOAD_FLIGHT_TASK_MEDIA_PRIORITIZE"),
     EnumMember(Value = "upload_flighttask_media_prioritize")]
    UploadFlightTaskMediaPrioritize = 1,
}
