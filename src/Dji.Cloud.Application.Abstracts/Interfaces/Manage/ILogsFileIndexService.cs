using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface ILogsFileIndexService
{
    /// <summary>
    /// Insert the index of the device logs.
    /// </summary>
    /// <param name="file">file</param>
    /// <param name="deviceSerialNumber">device serial number</param>
    /// <param name="domain">domain</param>
    /// <param name="fileId">file id</param>
    /// <returns></returns>
    Task<bool> InsertFileIndexAsync(LogsFile file, string deviceSerialNumber, int domain, string fileId);

    /// <summary>
    /// Query logs file upload information based on the file id.
    /// </summary>
    /// <param name="fileId">file id</param>
    /// <returns></returns>
    Task<LogsFileUpload> GetFileIndexByFileIdAsync(string fileId);

    /// <summary>
    /// Batch query logs file upload information.
    /// </summary>
    /// <param name="fileIds"></param>
    /// <returns></returns>
    Task<LogsFileUpload> GetFileIndexByFileIdsAsync(IEnumerable<LogsFile> fileIds);

    /// <summary>
    /// Delete log index data based on file id.
    /// </summary>
    /// <param name="fileIds"></param>
    /// <returns></returns>
    Task DeleteFileIndexByFileIdsAsync(IEnumerable<string> fileIds);
}
