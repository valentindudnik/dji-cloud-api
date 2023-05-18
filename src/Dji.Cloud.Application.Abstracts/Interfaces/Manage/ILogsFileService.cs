using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface ILogsFileService
{
    /// <summary>
    /// Query the uploaded log file information based on the log id. 
    /// </summary>
    /// <param name="logsId">logs id</param>
    /// <returns></returns>
    Task<IEnumerable<LogsFile>> GetLogsFileInfoByLogsIdAsync(string logsId);

    /// <summary>
    /// Query the uploaded log file structure information based on the log id.
    /// </summary>
    /// <param name="logsId"></param>
    /// <returns></returns>
    Task<IEnumerable<LogsFileUpload>> GetLogsFileByLogsIdAsync(string logsId);

    /// <summary>
    /// Added logs file.
    /// </summary>
    /// <param name="file">The file</param>
    /// <param name="logsId">logs id</param>
    /// <returns></returns>
    Task<bool> InsertFileAsync(LogsFileUpload file, string logsId);

    /// <summary>
    /// Delete logs files.
    /// </summary>
    /// <param name="logsId"></param>
    /// <returns></returns>
    Task DeleteFilebyLogsIdAsync(string logsId);

    /// <summary>
    /// Update file information.
    /// </summary>
    /// <param name="logsId"></param>
    /// <param name="fileReceiver"></param>
    /// <returns></returns>
    Task UpdateFileAsync(string logsId, LogsExtFileReceiver fileReceiver);

    /// <summary>
    /// Update file upload status.
    /// </summary>
    /// <param name="logsId">logs id</param>
    /// <param name="isUploaded">is uploaded</param>
    /// <returns></returns>
    Task UpdateFileUploadStatusAsync(string logsId, bool isUploaded);

    /// <summary>
    /// Get the file address.
    /// </summary>
    /// <param name="logsId">logs id</param>
    /// <param name="fileId">file id</param>
    /// <returns></returns>
    Task<Uri> GetLogsFileUriAsync(string logsId, string fileId);
}
