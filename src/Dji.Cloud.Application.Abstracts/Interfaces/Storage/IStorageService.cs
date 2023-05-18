using Dji.Cloud.Domain.Media;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Storage;

public interface IStorageService
{
    /// <summary>
    /// Get custom temporary credentials object for uploading the media and wayline. 
    /// </summary>
    /// <returns>temporary credentials object</returns>
    Task<StsCredentials> GetStsCredentialsAsync(string workspaceId);

//    /**
//     * Handles requests from the dock to obtain temporary credentials.
//     * @param receiver
//     * @param headers
//     */
//    void replyConfigGet(CommonTopicReceiver receiver, MessageHeaders headers);
}
