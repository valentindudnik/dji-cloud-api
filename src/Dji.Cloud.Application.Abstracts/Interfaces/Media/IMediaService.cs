using Dji.Cloud.Application.Abstracts.Requests.Media;
using Dji.Cloud.Domain.Mqtt.Models;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Media;

public interface IMediaService
{
    /// <summary>
    /// Check if the file has been uploaded by the fingerprint.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="fingerprint">fingerprint</param>
    /// <returns></returns>
    Task<bool> FastUploadAsync(string workspaceId, string fingerprint);

    /// <summary>
    /// Save the basic information of the file to the database.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="file">file</param>
    /// <returns></returns>
    Task<int> SaveMediaFileAsync(string workspaceId, FileUploadRequest request);

    /// <summary>
    /// Query tiny fingerprints about all files in this workspace based on the workspace id.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <returns></returns>
    Task<IEnumerable<string>> GetAllTinyFingerprintsByWorkspaceId(string workspaceId);

    /// <summary>
    /// Query the fingerprints that already exist in it based on the incoming tiny fingerprints data.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="tinyFingerPrints">tiny fingerprints</param>
    /// <returns></returns>
    Task<IEnumerable<string>> GetExistTinyFingerprints(string workspaceId, IEnumerable<string> tinyFingerPrints);

    /// <summary>
    /// Handle media files messages reported by dock.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="receiver">receiver</param>
    /// <returns></returns>
    Task HandleFileUploadCallBackAsync<TEntity>(CommonTopicReceiver<TEntity> receiver) where TEntity : class;

    //   /**
    //    * Handles the highest priority message about media uploads.
    //    * @param receiver
    //    * @param headers
    //    */
    //   void handleHighestPriorityUploadFlightTaskMedia(CommonTopicReceiver receiver, MessageHeaders headers);
}
