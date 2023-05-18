using Dji.Cloud.Domain.Map;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Map;

public interface IGroupService
{
    /// <summary>
    /// Query all groups in the workspace based on the workspace's id.
    /// If the group id does not exist, do not add this filter condition.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="groupId">group id</param>
    /// <param name="isDistributed">is distributed</param>
    /// <returns></returns>
    Task<IEnumerable<Group>> GetAllGroupsByWorkspaceIdAsync(string workspaceId, string groupId, bool isDistributed);
}
