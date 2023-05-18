using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Wayline;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Wayline;

public interface IWaylineFileService
{
    /// <summary>
    /// Get waylines
    /// </summary>
    /// <param name="workspaceId">workspace</param>
    /// <param name="request">request</param>
    /// <returns></returns>
    Task<BaseResponse<PaginationResponse<WaylineFile>>> GetWaylinesAsync(string workspaceId, WaylineQueryRequest request);
    
    /// <summary>
    /// Perform paging queries based on query parameters.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="request">parameters</param>
    /// <returns></returns>
    Task<PaginationResponse<WaylineFile>> GetWaylinesByAsync(string workspaceId, WaylineQueryRequest request);

    /// <summary>
    /// Query the information of this wayline file according to the wayline file id.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="waylineId">wayline id</param>
    /// <returns></returns>
    Task<WaylineFile> GetWaylineByWaylineIdAsync(string workspaceId, string waylineId);

    /// <summary>
    /// Get the download address of the file object.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="waylineId">wayline id</param>
    /// <returns></returns>
    Task<Uri> GetFileUrlAsync(string workspaceId, string waylineId);

    /// <summary>
    /// Save the basic information of the wayline file.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="metadata">metadata</param>
    /// <returns></returns>
    Task<int> SaveWaylineFileAsync(string workspaceId, WaylineFile metadata);

    /// <summary>
    /// Updates whether the file is collected or not based on the passed parameters.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="ids">ids</param>
    /// <param name="isFavorite">is favorite</param>
    /// <returns></returns>
    Task<BaseResponse<string>> MarkFavoriteAsync(string workspaceId, IEnumerable<string> ids, bool isFavorite = false);

    /// <summary>
    /// Batch query for duplicate file names in workspace.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="names">names</param>
    /// <returns></returns>
    Task<BaseResponse<IEnumerable<string>>> GetDuplicateNamesAsync(string workspaceId, IEnumerable<string> names);

    /// <summary>
    /// Delete the wayline file based on the wayline id.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="waylineId">wayline id</param>
    /// <returns></returns>
    Task<bool> DeleteByWaylineIdAsync(string workspaceId, string waylineId);

    // /**
    //  * Import kmz wayline file.
    //  * @param file
    //  * @param workspaceId
    //  * @param creator
    //  * @return
    //  */
    // void importKmzFile(MultipartFile file, String workspaceId, String creator);
}
