using Dji.Cloud.Domain.Map;
using Microsoft.AspNetCore.Mvc;

namespace Dji.Cloud.Api.Host.Controllers.Map;

[ApiController,
 Route("[controller]")]
public class WorkspaceElementController : ControllerBase
{
    [HttpGet("{workspaceId}/element-groups"),
     ProducesResponseType(typeof(IEnumerable<Group>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetElementsAsync([FromRoute] string workspaceId)
    {
        // TODO:

        return Ok();
    }

    [HttpPost("{workspaceId}/element-groups/{groupId}/elements")]
    public async Task<IActionResult> SaveElementAsync([FromRoute] string workspaceId, [FromRoute] string groupId) 
    {
        // TODO:

        return Ok();
    }

    [HttpPut("{workspaceId}/elements/{elementId}")]
    public async Task<IActionResult> UpdateElementAsync([FromRoute] string workspaceId, [FromRoute] string elementId)
    {
        // TODO:

        return Ok();
    }

    [HttpDelete("{workspaceId}/elements/{elementId}")]
    public async Task<IActionResult> DeleteElementAsync([FromRoute] string workspaceId, [FromRoute] string elementId)
    {
        // TODO:

        return NoContent();
    }

    /// <summary>
    /// Delete all the element information in this group based on the group id.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="groupId">the group id</param>
    /// <returns></returns>
    [HttpDelete("{workspaceId}/element-groups/{groupId}/elements")]
    public async Task<IActionResult> DeleteElementsAsync([FromRoute] string workspaceId, [FromRoute] string groupId)
    {
        // TODO:

        return Ok();
    }

//        @Autowired
//    private IWorkspaceElementService elementService;

    //        @Autowired
    //    private ISendMessageService sendMessageService;

    //        @Autowired
    //    private IWebSocketManageService webSocketManageService;

    //        /**
    //         * In the first connection, pilot will send out this http request to obtain the group element list.
    //         * Also, if pilot receives a group refresh instruction from WebSocket,
    //         * it needs the same interface to request the group element list.
    //         * @param workspaceId
    //         * @param groupId
    //         * @param isDistributed
    //         * @return
    //         */
    //        @GetMapping("/{workspace_id}/element-groups")
    //    public ResponseResult<List<GroupDTO>> getAllElements(@PathVariable(name = "workspace_id") String workspaceId,
    //                               @RequestParam(name = "group_id", required = false) String groupId,
    //                               @RequestParam(name = "is_distributed", required = false) Boolean isDistributed) {
    //        List<GroupDTO> groupsList = elementService.getAllGroupsByWorkspaceId(workspaceId, groupId, isDistributed);
    //        return ResponseResult.success(groupsList);
    //    }

    //    /**
    //     * When user draws a point, line or polygon on the PILOT/Web side.
    //     * Save the element information to the database.
    //     * @param request
    //     * @param workspaceId
    //     * @param groupId
    //     * @param elementCreate
    //     * @return
    //     */
    //    @PostMapping("/{workspace_id}/element-groups/{group_id}/elements")
    //    public ResponseResult saveElement(HttpServletRequest request,
    //                            @PathVariable(name = "workspace_id") String workspaceId,
    //                            @PathVariable(name = "group_id") String groupId,
    //                            @RequestBody ElementCreateDTO elementCreate) {
    //        CustomClaim claims = (CustomClaim)request.getAttribute(TOKEN_CLAIM);
    //    // Set the creator of the element
    //    elementCreate.getResource().setUsername(claims.getUsername());

    //    ResponseResult response = elementService.saveElement(groupId, elementCreate);
    //        if (response.getCode() != ResponseResult.CODE_SUCCESS) {
    //            return response;
    //        }

    //// Notify all WebSocket connections in this workspace to be updated when an element is created.
    //elementService.getElementByElementId(elementCreate.getId())
    //        .ifPresent(groupElement->
    //                sendMessageService.sendBatch(
    //                        webSocketManageService.getValueWithWorkspace(workspaceId),
    //                        CustomWebSocketMessage.< GroupElementDTO > builder()
    //                                .timestamp(System.currentTimeMillis())
    //                                .bizCode(BizCodeEnum.MAP_ELEMENT_CREATE.getCode())
    //                                .data(groupElement)
    //                                .build()));

    //return ResponseResult.success(new ConcurrentHashMap<>(Map.of("id", elementCreate.getId())));
    //    }

    //    /**
    //     * When user edits a point, line or polygon on the PILOT/Web side.
    //     * Update the element information to the database.
    //     * @param request
    //     * @param workspaceId
    //     * @param elementId
    //     * @param elementUpdate
    //     * @return
    //     */
    //    @PutMapping("/{workspace_id}/elements/{element_id}")
    //    public ResponseResult updateElement(HttpServletRequest request,
    //                              @PathVariable(name = "workspace_id") String workspaceId,
    //                              @PathVariable(name = "element_id") String elementId,
    //                              @RequestBody ElementUpdateDTO elementUpdate) {

    //    CustomClaim claims = (CustomClaim)request.getAttribute(TOKEN_CLAIM);

    //    ResponseResult response = elementService.updateElement(elementId, elementUpdate, claims.getUsername());
    //    if (response.getCode() != ResponseResult.CODE_SUCCESS)
    //    {
    //        return response;
    //    }

    //    // Notify all WebSocket connections in this workspace to update when there is an element update.
    //    elementService.getElementByElementId(elementId)
    //            .ifPresent(groupElement->
    //                    sendMessageService.sendBatch(
    //                            webSocketManageService.getValueWithWorkspace(workspaceId),
    //                            CustomWebSocketMessage.< GroupElementDTO > builder()
    //                                    .timestamp(System.currentTimeMillis())
    //                                    .bizCode(BizCodeEnum.MAP_ELEMENT_UPDATE.getCode())
    //                                    .data(groupElement)
    //                                    .build()));
    //    return response;
    //}

    ///**
    // * When user delete a point, line or polygon on the PILOT/Web side,
    // * Delete the element information in the database.
    // * @param workspaceId
    // * @param elementId
    // * @return
    // */
    //@DeleteMapping("/{workspace_id}/elements/{element_id}")
    //    public ResponseResult deleteElement(@PathVariable(name = "workspace_id") String workspaceId,
    //                              @PathVariable(name = "element_id") String elementId) {

    //    Optional<GroupElementDTO> elementOpt = elementService.getElementByElementId(elementId);

    //    ResponseResult response = elementService.deleteElement(elementId);

    //    // Notify all WebSocket connections in this workspace to update when an element is deleted.
    //    if (ResponseResult.CODE_SUCCESS == response.getCode())
    //    {
    //        elementOpt.ifPresent(element->
    //                sendMessageService.sendBatch(
    //                webSocketManageService.getValueWithWorkspace(workspaceId),
    //                        CustomWebSocketMessage.< WebSocketElementDelDTO > builder()
    //                                .timestamp(System.currentTimeMillis())
    //                                .bizCode(BizCodeEnum.MAP_ELEMENT_DELETE.getCode())
    //                                .data(WebSocketElementDelDTO.builder()
    //                                        .elementId(elementId)
    //                                        .groupId(element.getGroupId())
    //                                        .build())
    //                                .build()));
    //    }
    //    return response;
    //}

    ///**
    // * Delete all the element information in this group based on the group id.
    // * @param workspaceId
    // * @param groupId
    // * @return
    // */
    //@DeleteMapping("/{workspace_id}/element-groups/{group_id}/elements")
    //    public ResponseResult deleteAllElementByGroupId(@PathVariable(name = "workspace_id") String workspaceId,
    //                                          @PathVariable(name = "group_id") String groupId) {

    //    ResponseResult response = elementService.deleteAllElementByGroupId(groupId);

    //    // Notify all WebSocket connections in this workspace to update when elements are deleted.
    //    if (ResponseResult.CODE_SUCCESS == response.getCode())
    //    {

    //        sendMessageService.sendBatch(
    //                webSocketManageService.getValueWithWorkspace(workspaceId),
    //                CustomWebSocketMessage.builder()
    //                        .timestamp(System.currentTimeMillis())
    //                        .bizCode(BizCodeEnum.MAP_GROUP_REFRESH.getCode())
    //        // Group ids that need to re-request data
    //                        .data(new ConcurrentHashMap<String, String[]>(Map.of("ids", new String[] { groupId })))
    //                        .build());
    //    }
    //    return response;
    //}
}
