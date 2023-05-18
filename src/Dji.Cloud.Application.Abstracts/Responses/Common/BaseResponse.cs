using Dji.Cloud.Application.Abstracts.Interfaces.Common;
using System.Net;

namespace Dji.Cloud.Application.Abstracts.Responses.Common;

public class BaseResponse<TEntity> where TEntity : class
{
    public int Code { get; set; }

    public TEntity? Data { get; set; }

    public string? Message { get; set; }

    public static BaseResponse<TEntity> Success()
    {
        var response = new BaseResponse<TEntity>
        {
            Code = (int)HttpStatusCode.OK,
            Message = nameof(HttpStatusCode.OK)
        };

        return response;
    }

    public static BaseResponse<TEntity> Success(TEntity data)
    {
        var response = new BaseResponse<TEntity>
        {
            Code = (int)HttpStatusCode.OK,
            Message = nameof(HttpStatusCode.OK),
            Data = data
        };

        return response;
    }

    public static BaseResponse<TEntity> Error()
    {
        var response = new BaseResponse<TEntity>
        {
            Code = (int)HttpStatusCode.BadRequest,
            Message = nameof(HttpStatusCode.BadRequest)
        };

        return response;
    }

    public static BaseResponse<TEntity> Error(string message)
    {
        var response = new BaseResponse<TEntity>
        {
            Code = (int)HttpStatusCode.InternalServerError,
            Message = message
        };

        return response;
    }

    public static BaseResponse<TEntity> Error(int code, string message)
    {
        var response = new BaseResponse<TEntity>
        {
            Code = code,
            Message = message
        };

        return response;
    }

    public static BaseResponse<TEntity> Error(ErrorInfo errorInfo)
    {
        var response = new BaseResponse<TEntity>
        {
            Code = errorInfo.Code,
            Message = errorInfo.Message
        };

        return response;
    }
}
