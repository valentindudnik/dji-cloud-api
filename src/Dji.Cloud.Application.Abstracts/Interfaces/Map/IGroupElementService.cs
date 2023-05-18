using Dji.Cloud.Domain.Map;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Map;

public interface IGroupElementService
{
    /// <summary>
    /// Query all the elements in this group based on the group id.
    /// </summary>
    /// <param name="groupId">group id</param>
    /// <returns></returns>
    Task<IEnumerable<GroupElement>> GetElementsByGroupIdAsync(string groupId);

    /// <summary>
    /// Save all the elements.
    /// </summary>
    /// <param name="groupId">group id</param>
    /// <param name="elementCreate">element create</param>
    /// <returns></returns>
    Task<bool> SaveElementAsync(string groupId, ElementCreate elementCreate);

    /// <summary>
    /// Query the element information based on the element id and update element.
    /// </summary>
    /// <param name="elementId">element id</param>
    /// <param name="elementUpdate">element Update</param>
    /// <param name="userName">user name</param>
    /// <returns></returns>
    Task<bool> UpdateElementAsync(string elementId, ElementUpdate elementUpdate, string userName);

    /// <summary>
    /// Delete the element based on the element id.
    /// </summary>
    /// <param name="elementId">element id</param>
    /// <returns></returns>
    Task<bool> DeleteElementAsync(string elementId);

    /// <summary>
    /// Query an element based on the element id, including the coordinate information in the elements.
    /// </summary>
    /// <param name="elementId">element id</param>
    /// <returns></returns>
    Task<GroupElement> GetElementByElementId(string elementId);
}
