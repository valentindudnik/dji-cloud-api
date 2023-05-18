using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Dji.Cloud.Domain.Enums;

[Serializable]
public enum CommonErrors
{
    [Display(Name = "None", Description = "None"),
     EnumMember(Value = "None")]
    None = 0,

    [Display(Name = "ILLEGAL_ARGUMENT", Description = "Illegal argument."),
     EnumMember(Value = "200001")]
    IllegalArgument = 1,

    [Display(Name = "REDIS_DATA_NOT_FOUND", Description = "Redis data does not exist."),
     EnumMember(Value = "201404")]
    RedisDataNotFound = 2,

    [Display(Name = "DEVICE_OFFLINE", Description = "Device is offline."), 
     EnumMember(Value = "212015")]
    DeviceOffline = 3,

    [Display(Name = "GET_ORGANIZATION_FAILED", Description = "Failed to get organization."),
     EnumMember(Value = "210230")]
    GetOrganizationFailed = 4,

    [Display(Name = "DEVICE_BINDING_FAILED", Description = "Failed to bind device."),
     EnumMember(Value = "210231")]
    DeviceBindingFailed = 5,

    [Display(Name = "NON_REPEATABLE_BINDING", Description = "The device has been bound to another organization and can't be bound repeatedly."),
     EnumMember(Value = "210232")]
    NonRepeatableBinding = 6,

    [Display(Name = "GET_DEVICE_BINDING_STATUS_FAILED", Description = "Failed to get device binding status."),
     EnumMember(Value = "210233")]
    GetDeviceBindingStatusFailed = 7,

    [Display(Name = "SYSTEM_ERROR", Description = "System error."),
     EnumMember(Value = "600500")]
    SystemError = 8,

    [Display(Name = "SECRET_INVALID", Description = "Secret invalid."),
     EnumMember(Value = "600100")]
    SecretInvalid = 10,

    [Display(Name = "NO_TOKEN", Description = "Token is null."),
     EnumMember(Value = "600101")]
    NoToken = 11,

    [Display(Name = "TOKEN_EXPIRED", Description = "Token is expired."),
     EnumMember(Value = "600102")]
    TokenExpired = 12,

    [Display(Name = "TOKEN_INVALID", Description = "Token invalid."),
     EnumMember(Value = "600103")]
    TokenInvalid = 13,

    [Display(Name = "SIGN_INVALID", Description = "Sign invalid."),
     EnumMember(Value = "600104")]
    SignInvalid = 14
}
