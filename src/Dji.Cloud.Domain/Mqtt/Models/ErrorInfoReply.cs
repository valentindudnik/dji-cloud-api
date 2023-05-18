namespace Dji.Cloud.Domain.Mqtt.Models;

public class ErrorInfoReply
{
    public string? SerialNumber { get; set; }

    public int ErrCode { get; set; }

    public static ErrorInfoReply Success(string serialNumber)
    {
        return new ErrorInfoReply { SerialNumber = serialNumber };
    }
}
