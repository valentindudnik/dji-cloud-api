namespace Dji.Cloud.Domain.Mqtt.Models;

public static class Topics
{
    public static readonly string BasicPre = "sys/";

    public static readonly string ThingModelPre = "thing/";

    public static readonly string Product = "product/";

    public static readonly string StatusSuf = "/status";

    public static readonly string ReplySuf = "_reply";

    public static readonly string StateSuf = "/state";

    public static readonly string ServicesSuf = "/services";

    public static readonly string OsdSuf = "/osd";

    public static readonly string RequestsSuf = "/requests";

    public static readonly string EventsSuf = "/events";

    public static readonly string PropertySuf = "/property";

    public static readonly string SetSuf = "/set";

    public static readonly string RegexSerialNumber = "[A-Za-z0-9]+";
}
