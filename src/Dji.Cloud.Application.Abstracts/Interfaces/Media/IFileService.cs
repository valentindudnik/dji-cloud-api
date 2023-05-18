using Dji.Cloud.Application.Abstracts.Requests.Media;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Media;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Media;

public interface IFileService
{
    /// <summary>
    /// Query if the file already exists based on the workspace id and the fingerprint of the file.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="fingerprint">fingerprint</param>
    /// <returns></returns>
    Task<bool> CheckExistAsync(string workspaceId, string fingerprint);

    /// <summary>
    /// Save the basic information of the file to the database.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="request">request</param>
    /// <returns></returns>
    Task<int> SaveFileAsync(string workspaceId, FileUploadRequest request);

    /// <summary>
    /// Query information about all files in this workspace based on the workspace id.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <returns></returns>
    Task<IEnumerable<MediaFile>> GetAllFilesByWorkspaceIdAsync(string workspaceId);

    /// <summary>
    /// Paginate through all media files in this workspace.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="page">page</param>
    /// <param name="pageSize">page size</param>
    /// <returns></returns>
    Task<PaginationResponse<MediaFile>> GetMediaFilesPaginationByWorkspaceIdAsync(string workspaceId, long page, long pageSize);

    /// <summary>
    /// Get the download address of the file.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="fileId">file id</param>
    /// <returns></returns>
    Task<Uri> GetObjectUriAsync(string workspaceId, string fileId);

    /// <summary>
    /// Query all media files of a job.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="jobId">job id</param>
    /// <returns></returns>
    Task<IEnumerable<MediaFile>> GetFilesByWorkspaceAndJobIdAsync(string workspaceId, string jobId);
}
