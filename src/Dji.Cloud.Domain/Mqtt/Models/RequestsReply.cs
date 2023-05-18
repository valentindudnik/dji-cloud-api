namespace Dji.Cloud.Domain.Mqtt.Models;

public class RequestsReply<T>
{
    public int Result { get; set; }

    public T? Output { get; set; }

    //public static RequestsReply error(IErrorInfo errorInfo)
    //{
    //    return RequestsReply.builder()
    //            .result(errorInfo.getErrorCode())
    //            .output(errorInfo.getErrorMsg())
    //            .build();
    //}

    //public static <T> RequestsReply success(T data)
    //{
    //    return RequestsReply.builder()
    //            .result(ResponseResult.CODE_SUCCESS)
    //            .output(data)
    //            .build();
    //}
    //public static RequestsReply success()
    //{
    //    return RequestsReply.builder()
    //            .result(ResponseResult.CODE_SUCCESS)
    //            .build();
    //}
}
