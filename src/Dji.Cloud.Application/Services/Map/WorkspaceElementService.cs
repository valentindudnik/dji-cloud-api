using Dji.Cloud.Application.Abstracts.Interfaces.Map;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Map;
using System;

namespace Dji.Cloud.Application.Services.Map;

public class WorkspaceElementService : IWorkspaceElementService
{
    //@Autowired
    //private IGroupService groupService;

    //@Autowired
    //private IGroupElementService groupElementService;

    //@Autowired
    //private IElementCoordinateService elementCoordinateService;

    //@Override
    //public List<GroupDTO> getAllGroupsByWorkspaceId(String workspaceId, String groupId, Boolean isDistributed)
    //{
    //    List<GroupDTO> groupList = groupService.getAllGroupsByWorkspaceId(workspaceId, groupId, isDistributed);
    //    groupList.forEach(group->group.setElements(
    //            groupElementService.getElementsByGroupId(group.getId())
    //    ));
    //    return groupList;
    //}

    //@Override
    //public ResponseResult saveElement(String groupId, ElementCreateDTO elementCreate)
    //{
    //    boolean saveElement = groupElementService.saveElement(groupId, elementCreate);
    //    if (!saveElement)
    //    {
    //        return ResponseResult.error("Failed to save the element.");
    //    }

    //    // save coordinate
    //    boolean saveCoordinate = elementCoordinateService.saveCoordinate(
    //                    elementCreate.getResource().getContent().getGeometry().convertToList(), elementCreate.getId());

    //    return saveCoordinate ?
    //            ResponseResult.success() : ResponseResult.error("Failed to save the coordinate.");
    //}


    //@Override
    //public ResponseResult updateElement(String elementId, ElementUpdateDTO elementUpdate, String username)
    //{
    //    boolean updElement = groupElementService.updateElement(elementId, elementUpdate, username);
    //    if (!updElement)
    //    {
    //        return ResponseResult.error("Failed to update the element.");
    //    }

    //    // delete all coordinates according to element id.
    //    boolean delCoordinate = elementCoordinateService.deleteCoordinateByElementId(elementId);
    //    // save coordinate
    //    boolean saveCoordinate = elementCoordinateService.saveCoordinate(
    //            elementUpdate.getContent().getGeometry().convertToList(), elementId);

    //    return delCoordinate && saveCoordinate ?
    //            ResponseResult.success() : ResponseResult.error("Failed to update the coordinate.");
    //}

    //@Override
    //public ResponseResult deleteElement(String elementId)
    //{
    //    boolean delElement = groupElementService.deleteElement(elementId);
    //    if (!delElement)
    //    {
    //        return ResponseResult.error("Failed to delete the element.");
    //    }

    //    // delete all coordinates according to element id.
    //    boolean delCoordinate = elementCoordinateService.deleteCoordinateByElementId(elementId);

    //    return delCoordinate ?
    //            ResponseResult.success() : ResponseResult.error("Failed to delete the coordinate.");
    //}

    //@Override
    //public Optional<GroupElementDTO> getElementByElementId(String elementId)
    //{
    //    return groupElementService.getElementByElementId(elementId);
    //}

    //@Override
    //public ResponseResult deleteAllElementByGroupId(String groupId)
    //{
    //    List<GroupElementDTO> groupElementList = groupElementService.getElementsByGroupId(groupId);
    //    for (GroupElementDTO groupElement : groupElementList)
    //    {
    //        ResponseResult response = this.deleteElement(groupElement.getElementId());
    //        if (ResponseResult.CODE_SUCCESS != response.getCode())
    //        {
    //            return response;
    //        }
    //    }
    //    return ResponseResult.success();
    //}
    public Task<BaseResponse<TEntity>> DeleteAllElementByGroupIdAsync<TEntity>(string groupId) where TEntity : class
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<TEntity>> DeleteElementAsync<TEntity>(string elementId) where TEntity : class
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Group>> GetAllGroupsByWorkspaceIdAsync(string workspaceId, string groupId, bool isDistributed)
    {
        throw new NotImplementedException();
    }

    public Task<GroupElement> GetElementByElementId(string elementId)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<TEntity>> SaveElementAsync<TEntity>(string groupId, ElementCreate elementCreate) where TEntity : class
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponse<TEntity>> UpdateElementAsync<TEntity>(string elementId, ElementUpdate elementUpdate, string userName) where TEntity : class
    {
        throw new NotImplementedException();
    }
}
