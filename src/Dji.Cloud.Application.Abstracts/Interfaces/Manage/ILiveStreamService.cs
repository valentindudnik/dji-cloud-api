using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface ILiveStreamService
{
    /// <summary>
    /// Get all the drone data that can be broadcast live in this workspace.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <returns></returns>
    Task<IEnumerable<CapacityDevice>> GetLiveCapacityAsync(string workspaceId);

    /// <summary>
    /// Save live capability data.
    /// </summary>
    /// <param name="liveCapacityReceiver">live capacity receiver</param>
    /// <param name="timestamp">timestamp</param>
    /// <returns></returns>
    Task SaveLiveCapacityAsync(LiveCapacityReceiver liveCapacityReceiver, long timestamp);

    /// <summary>
    /// Initiate a live streaming by publishing mqtt message.
    /// </summary>
    /// <param name="request">liveParam Parameters needed for on-demand.</param>
    /// <returns></returns>
    Task<BaseResponse<Live>> LiveStartAsync(LiveTypeRequest request);

    /// <summary>
    /// Stop the live streaming by publishing mqtt message.
    /// </summary>
    /// <param name="videoId">video id</param>
    /// <returns></returns>
    Task<BaseResponse<Device>> LiveStopAsync(string videoId);

    /// <summary>
    /// Readjust the clarity of the live streaming by publishing mqtt messages.
    /// </summary>
    /// <param name="request">request</param>
    /// <returns></returns>
    Task<BaseResponse<Device>> LiveSetQualityAsync(LiveTypeRequest request);

    /// <summary>
    /// Switches the lens of the device during the live streaming.
    /// </summary>
    /// <param name="request">request</param>
    /// <returns></returns>
    Task<BaseResponse<Device>> LiveLensChangeAsync(LiveTypeRequest request);
}
