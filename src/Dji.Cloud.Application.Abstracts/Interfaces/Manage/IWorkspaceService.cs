using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface IWorkspaceService
{
    /// <summary>
    /// Query the information of a workspace based on its workspace id.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <returns>The workspace</returns>
    Task<Workspace> GetWorkspaceByWorkspaceIdAsync(string workspaceId);

    /// <summary>
    /// Query the workspace of a workspace based on bind code.
    /// </summary>
    /// <param name="bindCode">bind code</param>
    /// <returns></returns>
    Task<Workspace> GetWorkspaceByBindCodeAsync(string bindCode);

    ///**
    // * Handle the request for obtaining the organization information corresponding to the device binding.
    // * Note: If your business does not need to bind the dock to the organization,
    // *       you can directly reply to the successful message without implementing business logic.
    // * @param receiver
    // */
    //void replyOrganizationGet(CommonTopicReceiver receiver, MessageHeaders headers);
}
