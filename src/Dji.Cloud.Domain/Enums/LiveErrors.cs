using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Dji.Cloud.Domain.Enums;

[Serializable]
public enum LiveErrors
{
    [Display(Name = "None", Description = "None"),
     EnumMember(Value = "None")]
    None = 0,

    [Display(Name = "NO_AIRCRAFT", Description = "No aircraft."),
     EnumMember(Value = "613001")]
    NoAircraft = 1,

    [Display(Name = "NO_CAMERA", Description = "No camera."),
     EnumMember(Value = "613002")]
    NoCamera = 2,

    [Display(Name = "LIVE_STREAM_ALREADY_STARTED", Description = "The camera has started live streaming."),
     EnumMember(Value = "613003")]
    LiveStreamAlreadyStarted = 3,

    [Display(Name = "FUNCTION_NOT_SUPPORT", Description = "The function is not supported."),
     EnumMember(Value = "613004")]
    FunctionNotSupport = 4,

    [Display(Name = "STRATEGY_NOT_SUPPORT", Description = "The strategy is not supported."),
     EnumMember(Value = "613005")]
    StrategyNotSupport = 5,

    [Display(Name = "NOT_IN_CAMERA_INTERFACE", Description = "The current app is not in the camera interface."),
     EnumMember(Value = "613006")]
    NotInCameraInterface = 6,

    [Display(Name = "NO_FLIGHT_CONTROL", Description = "The remote control has no flight control rights and cannot respond to control commands."),
     EnumMember(Value = "613007")]
    NoFlightControl = 7,

    [Display(Name = "NO_STREAM_DATA", Description = "The current app has no stream data."),
     EnumMember(Value = "613008")]
    NoStreamData = 8,

    [Display(Name = "TOO_FREQUENT", Description = "The operation is too frequent."),
     EnumMember(Value = "613009")]
    TooFrequent = 9,

    [Display(Name = "ENABLE_FAILED", Description = "Please check whether the live stream service is normal."),
     EnumMember(Value = "613010")]
    EnableFailed = 10,

    [Display(Name = "NO_LIVE_STREAM", Description = "There are no live stream currently."),
     EnumMember(Value = "613011")]
    NoLiveStream = 11,

    [Display(Name = "SWITCH_NOT_SUPPORT", Description = "There is already another camera in the live stream. It's not support to switch the stream directly."),
     EnumMember(Value = "613012")]
    SwitchNotSupport = 12,

    [Display(Name = "URL_TYPE_NOT_SUPPORTED", Description = "This url type is not supported."),
     EnumMember(Value = "613013")]
    UrlTypeNotSupported = 13,

    [Display(Name = "ERROR_PARAMETERS", Description = "The live stream parameters are abnormal or incomplete."),
     EnumMember(Value = "613014")]
    ErrorParameters = 14,

    [Display(Name = "NO_REPLY", Description = "No live reply received."),
     EnumMember(Value = "613098")]
    NoReply = 15,

    [Display(Name = "UNKNOWN", Description = "UNKNOWN"),
     EnumMember(Value = "613099")]
    Unknown = 16
}
