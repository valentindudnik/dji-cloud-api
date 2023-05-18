using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Dji.Cloud.Domain.Enums;

[Serializable]
public enum DeviceTopics
{
    // STATUS(Pattern.compile("^" + BASIC_PRE + PRODUCT + REGEX_SN + STATUS_SUF + "$"),

    [Display(Name = "STATUS"),
     EnumMember(Value = "inboundStatus")]
    Status = 0,

    // STATE(Pattern.compile("^" + THING_MODEL_PRE + PRODUCT + REGEX_SN + STATE_SUF + "$"),
    
    [Display(Name = "STATE"),
     EnumMember(Value = "inboundState")]
    State = 1,

    // SERVICE_REPLY(Pattern.compile("^" + THING_MODEL_PRE + PRODUCT + REGEX_SN + SERVICES_SUF + _REPLY_SUF + "$"),
    
    [Display(Name = "SERVICE_REPLY"),
     EnumMember(Value = "inboundStateServiceReply")]
    ServiceReply = 2,

    // OSD(Pattern.compile("^" + THING_MODEL_PRE + PRODUCT + REGEX_SN + OSD_SUF + "$"),
    
    [Display(Name = "OSD"),
     EnumMember(Value = "inboundOsd")]
    Osd = 3,

    // REQUESTS(Pattern.compile("^" + THING_MODEL_PRE + PRODUCT + REGEX_SN + REQUESTS_SUF + "$"),
    
    [Display(Name = "REQUESTS"),
     EnumMember(Value = "inboundRequests")]
    Requests = 4,

    // EVENTS(Pattern.compile("^" + THING_MODEL_PRE + PRODUCT + REGEX_SN + EVENTS_SUF + "$"),
    
    [Display(Name = "EVENTS"),
     EnumMember(Value = "inboundEvents")]
    Events = 5,

    // PROPERTY_SET_REPLY(Pattern.compile("^" + THING_MODEL_PRE + PRODUCT + REGEX_SN + PROPERTY_SUF + SET_SUF + _REPLY_SUF + "$"),
    
    [Display(Name = "PROPERTY_SET_REPLY"),
     EnumMember(Value = "inboundPropertySetReply")]
    PropertySetReply = 6,

    // UNKNOWN(Pattern.compile("^.*$"), ChannelName.DEFAULT);
    [Display(Name = "UNKNOWN"),
     EnumMember(Value = "default")]
    Unknown = 7
}
