using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Dji.Cloud.Domain.Enums;

[Serializable]
public enum WaylineMethods
{
    [Display(Name = "FLIGHT_TASK_PREPARE"),
     EnumMember(Value = "flighttask_prepare")]
    FlightTaskPrepare = 0,

    [Display(Name = "FLIGHT_TASK_EXECUTE"),
     EnumMember(Value = "flighttask_execute")]
    FlightTaskExecute = 1,

    [Display(Name = "FLIGHT_TASK_CANCEL"),
     EnumMember(Value = "flighttask_undo")]
    FlightTaskUndo = 2
}
