using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Map;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Map;

public interface IWorkspaceElementService
{
    /// <summary>
    /// Query all groups in the workspace based on the workspace's id,
    ///  including the information of the elements in the group, and the coordinate information in the elements.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="groupId">group id</param>
    /// <param name="isDistributed">is distributed</param>
    /// <returns></returns>
    Task<IEnumerable<Group>> GetAllGroupsByWorkspaceIdAsync(string workspaceId, string groupId, bool isDistributed);

    /// <summary>
    /// Save all the elements, including the information of the elements in the group,
    /// and the coordinate information in the elements.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="groupId">group id</param>
    /// <param name="elementCreate">element create</param>
    /// <returns></returns>
    Task<BaseResponse<TEntity>> SaveElementAsync<TEntity>(string groupId, ElementCreate elementCreate) where TEntity : class;

    /// <summary>
    /// Update the element information based on the element id,
    /// including the information of the elements in the group, and the coordinate information in the elements.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="elementId">element id</param>
    /// <param name="elementUpdate">element update</param>
    /// <param name="userName">user name</param>
    /// <returns></returns>
    Task<BaseResponse<TEntity>> UpdateElementAsync<TEntity>(string elementId, ElementUpdate elementUpdate, string userName) where TEntity : class;

    /// <summary>
    /// Delete the element information based on the element id,
    /// including the information of the elements in the group, and the coordinate information in the elements.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="elementId">element id</param>
    /// <returns></returns>
    Task<BaseResponse<TEntity>> DeleteElementAsync<TEntity>(string elementId) where TEntity : class;

    /// <summary>
    /// Query an element based on the element id,
    /// including the information of the elements in the group, and the coordinate information in the elements.
    /// </summary>
    /// <param name="elementId">element id</param>
    /// <returns></returns>
    Task<GroupElement> GetElementByElementId(string elementId);

    /// <summary>
    /// Delete all the elements information based on the group id,
    /// including the information of the elements in the group, and the coordinate information in the elements.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="groupId"></param>
    /// <returns></returns>
    Task<BaseResponse<TEntity>> DeleteAllElementByGroupIdAsync<TEntity>(string groupId) where TEntity : class;
}
