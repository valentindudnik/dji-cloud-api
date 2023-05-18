using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain;
using Dji.Cloud.Domain.Enums;
using Dji.Cloud.Domain.Wayline;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Wayline;

public interface IWaylineJobService
{
    /// <summary>
    /// Create wayline job in the database.
    /// </summary>
    /// <param name="parameters"></param>
    /// <param name="workspaceId">user info</param>
    /// <param name="username">user info</param>
    /// <param name="beginTime">The time the job started.</param>
    /// <param name="endTime">The time the job ended.</param>
    /// <returns></returns>
    Task<WaylineJob> CreateWaylineJobAsync(CreateJobRequest parameters, string workspaceId, string username, long beginTime, long endTime);

    /// <summary>
    /// Create a sub-task based on the information of the parent task.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="parentId">parent id</param>
    /// <returns></returns>
    Task<WaylineJob> CreateWaylineJobByParentAsync(string workspaceId, string parentId);

    /// <summary>
    /// Issue wayline mission to the dock.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="request"></param>
    /// <param name="customClaim">user info</param>
    /// <returns></returns>
    Task<BaseResponse<TEntity>> PublishFlightTaskAsync<TEntity>(CreateJobRequest request, TokenInfo customClaim) where TEntity : class;

    /// <summary>
    /// Execute the task immediately.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="jobId">job id</param>
    /// <returns></returns>
    Task<bool> ExecuteFlightTaskAsync(string workspaceId, string jobId);

    /// <summary>
    /// Cancel the task Base on job Ids.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="jobIds">job ids</param>
    /// <returns></returns>
    Task CancelFlightTaskAsync(string workspaceId, IEnumerable<string> jobIds);

    /// <summary>
    /// Cancel the dock tasks that have been issued but have not yet been executed.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="dockSerialNumber">dock serial number</param>
    /// <param name="jobIds">job ids</param>
    /// <returns></returns>
    Task PublishCancelTaskAsync(string workspaceId, string dockSerialNumber, IEnumerable<string> jobIds);

    /// <summary>
    /// Query wayline jobs based on conditions.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="jobIds">job ids</param>
    /// <param name="status">status</param>
    /// <returns></returns>
    Task<IEnumerable<WaylineJob>> GetJobsByConditionsAsync(string workspaceId, IEnumerable<string> jobIds, WaylineJobStatusEnum status);

    /// <summary>
    /// Query job information based on job id.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="jobId">job id</param>
    /// <returns></returns>
    Task<WaylineJob> GetJobByJobIdAsync(string workspaceId, string jobId);

    /// <summary>
    /// Update job
    /// </summary>
    /// <param name="waylineJob">wayline job</param>
    /// <returns></returns>
    Task<bool> UpdateJobAsync(WaylineJob waylineJob);

    /// <summary>
    /// Get jobs by workspace id
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="page">page</param>
    /// <param name="pageSize">page size</param>
    /// <returns></returns>
    Task<PaginationResponse<WaylineJob>> GetJobsByWorkspaceIdAsync(string workspaceId, long page, long pageSize);

    /// <summary>
    /// Set the media files for this job to upload immediately.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="jobId">job id</param>
    /// <returns></returns>
    Task UploadMediaHighestPriorityAsync(string workspaceId, string jobId);

    ///**
    // * Process to get interface data of flight mission resources.
    // * @param receiver
    // * @param headers
    // */
    //void flightTaskResourceGet(CommonTopicReceiver receiver, MessageHeaders headers);
}
