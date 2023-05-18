using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface IDeviceLogsService
{
    /// <summary>
    /// Obtain the device upload log list by paging according to the query parameters.
    /// </summary>
    /// <param name="deviceSerialNumber">device serial number</param>
    /// <param name="parameters">parameters</param>
    /// <returns>padination data</returns>
    Task<PaginationResponse<DeviceLogs>> GetUploadedLogsAsync(string deviceSerialNumber, DeviceLogsQueryRequest parameters);

    /// <summary>
    /// Get a list of log files that can be uploaded in real time.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="deviceSerialNumber">device serial number</param>
    /// <param name="domains">domains</param>
    /// <returns>real-time logs</returns>
    Task<BaseResponse<TEntity>> GetRealTimeLogsAsync<TEntity>(string deviceSerialNumber, IEnumerable<string> domains) where TEntity : class;

    /// <summary>
    /// Add device logs.
    /// </summary>
    /// <param name="bid">bid</param>
    /// <param name="userName">user name</param>
    /// <param name="deviceSerialNumber">device serial number</param>
    /// <param name="parameters">parameters</param>
    /// <returns></returns>
    Task<string> InsertDeviceLogsAsync(string bid, string userName, string deviceSerialNumber, DeviceLogsCreateRequest parameters);

    /// <summary>
    /// Initiate a log upload request to the gateway.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="userName">user name</param>
    /// <param name="deviceSerialNumber">device serail number</param>
    /// <param name="parameters">parameters</param>
    /// <returns>file</returns>
    Task<BaseResponse<TEntity>> PushFileUploadAsync<TEntity>(string userName, string deviceSerialNumber, DeviceLogsCreateRequest request) where TEntity : class;

    /// <summary>
    /// Push a request to modify the  status of the logs file.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="deviceSerialNumber">device serial number</param>
    /// <param name="request">parameters</param>
    /// <returns>file</returns>
    Task<BaseResponse<TEntity>> PushUpdateFileAsync<TEntity>(string deviceSerialNumber, LogsFileUpdateRequest request) where TEntity : class;

    /// <summary>
    /// Delete log records.
    /// </summary>
    /// <param name="deviceSerialNumber">device serial number</param>
    /// <param name="logsId">logs id</param>
    /// <returns></returns>
    Task DeleteLogsAsync(string deviceSerialNumber, string logsId);

    /// <summary>
    ///  Update status, which is updated when the logs upload succeeds or fails.
    /// </summary>
    /// <param name="logsId">logs id</param>
    /// <param name="value">value</param>
    /// <returns></returns>
    Task UpdateLogsStatusAsync(string logsId, int value);

    /// <summary>
    /// Get the file address.
    /// </summary>
    /// <param name="logsId">logs id</param>
    /// <param name="fileId">file id</param>
    /// <returns></returns>
    Task<Uri> GetLogsFileUriAsync(string logsId, string fileId);

    ///**
    // * Handle logs file upload progress.
    // * @param receiver
    // * @param headers
    // */
    //void handleFileUploadProgress(CommonTopicReceiver receiver, MessageHeaders headers);
}
