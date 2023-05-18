namespace Dji.Cloud.Domain.Mqtt.Models;

[Serializable]
public enum EventsMethod
{
    //FLIGHT_TASK_PROGRESS("flighttask_progress", ChannelName.INBOUND_EVENTS_FLIGHT_TASK_PROGRESS),
    FlightTaskProgress = 0,

    //FILE_UPLOAD_CALLBACK("file_upload_callback", ChannelName.INBOUND_EVENTS_FILE_UPLOAD_CALLBACK),
    FileUploadCallback = 1,

    //HMS("hms", ChannelName.INBOUND_EVENTS_HMS),
    Hms = 2,

    //DEVICE_REBOOT("device_reboot", ChannelName.INBOUND_EVENTS_CONTROL_PROGRESS),
    DeviceReboot = 3,

    //DRONE_OPEN("drone_open", ChannelName.INBOUND_EVENTS_CONTROL_PROGRESS),
    DroneOpen = 4,

    //DRONE_CLOSE("drone_close", ChannelName.INBOUND_EVENTS_CONTROL_PROGRESS),
    DroneClose = 5,

    //DEVICE_CHECK("device_check", ChannelName.INBOUND_EVENTS_CONTROL_PROGRESS),
    DeviceCheck = 6,

    //DRONE_FORMAT("drone_format", ChannelName.INBOUND_EVENTS_CONTROL_PROGRESS),
    DroneFormat = 7,

    //DEVICE_FORMAT("device_format", ChannelName.INBOUND_EVENTS_CONTROL_PROGRESS),
    DeviceFormat = 8,

    //COVER_OPEN("cover_open", ChannelName.INBOUND_EVENTS_CONTROL_PROGRESS),
    CoverOpen = 9,

    //COVER_CLOSE("cover_close", ChannelName.INBOUND_EVENTS_CONTROL_PROGRESS),
    CoverClose = 10,

    //PUTTER_OPEN("putter_open", ChannelName.INBOUND_EVENTS_CONTROL_PROGRESS),
    PutterOpen = 11,

    //PUTTER_CLOSE("putter_close", ChannelName.INBOUND_EVENTS_CONTROL_PROGRESS),
    PutterClose = 12,

    //CHARGE_OPEN("charge_open", ChannelName.INBOUND_EVENTS_CONTROL_PROGRESS),
    ChargeOpen = 13,

    //CHARGE_CLOSE("charge_close", ChannelName.INBOUND_EVENTS_CONTROL_PROGRESS),
    ChargeClose = 14,

    //OTA_PROGRESS("ota_progress", ChannelName.INBOUND_EVENTS_OTA_PROGRESS),
    OtaProgress = 15,

    //FILE_UPLOAD_PROGRESS("fileupload_progress", ChannelName.INBOUND_EVENTS_FILE_UPLOAD_PROGRESS),
    FileUploadProgress = 16,

    //HIGHEST_PRIORITY_UPLOAD_FLIGHT_TASK_MEDIA("highest_priority_upload_flighttask_media", ChannelName.INBOUND_EVENTS_HIGHEST_PRIORITY_UPLOAD_FLIGHT_TASK_MEDIA),
    HighestPriorityUploadFlightTaskMedia = 17,

    //UNKNOWN("Unknown", ChannelName.DEFAULT);
    Unknown = 18
}
