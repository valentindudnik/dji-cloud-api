using System.Runtime.Serialization;

namespace Dji.Cloud.Application.Abstracts.Enums;

[Serializable]
public enum RemoteControlMethods
{
    None = 0,

    Unknown = 1,
    // debug_mode_open
    DebugModeOpen = 2,
    // debug_mode_close
    DebugModeClose = 3,
    // supplement_light_open
    SupplementLightOpen = 4,
    // supplement_light_close
    SupplementLightClose = 5,
    // return_home
    ReturnHome = 6,
    // device_reboot
    DeviceReboot = 7,
    // drone_open
    DroneOpen = 8,
    // drone_close
    DroneClose = 9,
    // device_check
    DeviceCheck = 10,
    // drone_format
    DroneFormat = 11,
    // device_format
    DeviceFormat = 12,
    // cover_open
    CoverOpen = 13,
    // cover_close
    CoverClose = 14,
    // putter_open
    PutterOpen = 15,
    // putter_close
    PutterClose = 16,
    // charge_open
    ChargeOpen = 17,
    // charge_close
    ChargeClose = 18,




    //CHARGE_CLOSE("charge_close", true, null),

    //BATTERY_MAINTENANCE_SWITCH("battery_maintenance_switch", true, AlarmState.class),

    //ALARM_STATE_SWITCH("alarm_state_switch", true, AlarmState.class),

    //BATTERY_STORE_MODE_SWITCH("battery_store_mode_switch", true, BatteryStoreMode.class),

    //SDR_WORK_MODE_SWITCH("sdr_workmode_switch", false, LinkWorkMode.class),

    //UNKNOWN("unknown", false, null);

    //    private String method;

    //    private Boolean progress;

    //    private Class<? extends BasicDeviceProperty> clazz;

    //    RemoteControlMethodEnum(String method, Boolean progress, Class<? extends BasicDeviceProperty> clazz)
    //    {
    //        this.method = method;
    //        this.progress = progress;
    //        this.clazz = clazz;
    //    }

    //    public static RemoteControlMethodEnum find(String method)
    //    {
    //        return Arrays.stream(RemoteControlMethodEnum.values())
    //                .filter(methodEnum->methodEnum.method.equals(method))
    //                .findAny()
    //                .orElse(UNKNOWN);
    //    }
}
