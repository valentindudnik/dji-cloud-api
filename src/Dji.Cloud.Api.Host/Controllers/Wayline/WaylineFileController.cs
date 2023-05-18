using Dji.Cloud.Application.Abstracts.Interfaces.Wayline;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Wayline;
using Microsoft.AspNetCore.Mvc;

namespace Dji.Cloud.Api.Host.Controllers.Wayline;

[//Authorize,
 ApiController,
 ApiVersion("1.0"),
 Area("Wayline"),
 Route("[area]/api/v{version:apiVersion}/workspaces")]
public class WaylineFileController : ControllerBase
{   
    private readonly IWaylineFileService _service;

    //private readonly IMediatorService _service;

    public WaylineFileController(IWaylineFileService service)
    {
        _service = service;
    }

    /// <summary>
    /// Get waylines
    /// 
    /// Query the basic data of the wayline file according to the query conditions.
    /// The query condition field in pilot is fixed.
    /// 
    /// orderBy   Sorted fields. Spliced at the end of the sql statement.
    /// favorited Whether the wayline file is favorited or not.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="request">request</param>
    /// <returns></returns>
    [HttpGet("{workspaceId}/waylines"),
     ProducesResponseType(typeof(BaseResponse<PaginationResponse<WaylineFile>>), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetWaylinesAsync([FromRoute] string workspaceId, [FromQuery] WaylineQueryRequest request) 
    {
        var response = await _service.GetWaylinesAsync(workspaceId, request);

        return Ok(response);
    }

    /// <summary>
    /// Query the download address of the file according to the wayline file id,
    /// and redirect to this address directly for download.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="waylineId">wayline id</param>
    /// <returns></returns>
    [HttpGet("{workspaceId}/waylines/{waylineId}/url"),
     ProducesResponseType(typeof(string), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetFileUrlAsync([FromRoute] string workspaceId, [FromRoute] string waylineId)
    {
        var response = await _service.GetFileUrlAsync(workspaceId, waylineId);

        return Ok(response);
    }

    /// <summary>
    /// When the wayline file is uploaded to the storage server by pilot,
    /// the basic information of the file is reported through this interface.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="waylineFileUpload">wayline file upload</param>
    /// <returns></returns>
    [HttpPost("{workspace_id}/upload-callback"),
     ProducesResponseType(typeof(string), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> UploadCallBackAsync([FromRoute] string workspaceId, [FromBody] WaylineFileUpload waylineFileUpload)
    {
        // TODO:

        var metadata = waylineFileUpload.Metadata!;
        //metadata.setUsername(customClaim.getUsername());
        //metadata.setObjectKey(uploadFile.getObjectKey());
        //metadata.setName(uploadFile.getName());

        var result = await _service.SaveWaylineFileAsync(workspaceId, waylineFileUpload.Metadata!);

        return Ok(result);
    }
    
    //    /**
    //     * When the wayline file is uploaded to the storage server by pilot,
    //     * the basic information of the file is reported through this interface.
    //     * @param request
    //     * @param workspaceId
    //     * @param uploadFile
    //     * @return
    //     */
    //    @PostMapping("/{workspace_id}/upload-callback")
    //    public ResponseResult uploadCallBack(HttpServletRequest request,
    //                                         @PathVariable(name = "workspace_id") String workspaceId,
    //                                         @RequestBody WaylineFileUploadDTO uploadFile) {

    //    CustomClaim customClaim = (CustomClaim)request.getAttribute(TOKEN_CLAIM);

    //    WaylineFileDTO metadata = uploadFile.getMetadata();
    //    metadata.setUsername(customClaim.getUsername());
    //    metadata.setObjectKey(uploadFile.getObjectKey());
    //    metadata.setName(uploadFile.getName());

    //    int id = waylineFileService.saveWaylineFile(workspaceId, metadata);

    //    return id <= 0 ? ResponseResult.error() : ResponseResult.success();
    //}

    /// <summary>
    /// Favorite the wayline file according to the wayline file id.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="ids">wayline file ids</param>
    /// <returns></returns>
    [HttpPost("{workspaceId}/favorites")]
    public async Task<IActionResult> MarkFavoriteAsync([FromRoute] string workspaceId, [FromQuery] string[] ids)
    {
        const bool isFavorite = true;

        var response = await _service.MarkFavoriteAsync(workspaceId, ids, isFavorite);

        return Ok(response);
    }

    /// <summary>
    /// Delete the favorites of this wayline file based on the wayline file id.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="ids">ids wayline file id</param>
    /// <returns></returns>
    [HttpDelete("{workspaceId}/favorites")]
    public async Task<IActionResult> UnmarkFavoriteAsync([FromRoute] string workspaceId, [FromQuery] string[] ids)
    {
        var response = await _service.MarkFavoriteAsync(workspaceId, ids);

        return Ok(response);
    }

    /// <summary>
    /// Checking whether the name already exists according to the wayline name must ensure the uniqueness of the wayline name.
    /// This interface will be called when uploading waylines and must be available.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="names">names</param>
    /// <returns></returns>
    [HttpGet("{workspace_id}/waylines/duplicate-names")]
    public async Task<IActionResult> CheckDuplicateNamesAsync([FromRoute] string workspaceId, [FromQuery] IEnumerable<string> names)
    {
        var response = await _service.GetDuplicateNamesAsync(workspaceId, names);

        return Ok(response);
    }

    /// <summary>
    /// Delete the wayline file in the workspace according to the wayline id.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="waylineId">wayline id</param>
    /// <returns></returns>
    [HttpDelete("{workspaceId}/waylines/{waylineId}")]
    public async Task<IActionResult> DeleteWaylineAsync([FromRoute] string workspaceId, [FromRoute] string waylineId)
    {
        var response = await _service.DeleteByWaylineIdAsync(workspaceId, waylineId);

        // TODO:

        return Ok();
    }

    /////**
    //// * Delete the wayline file in the workspace according to the wayline id.
    //// * @param workspaceId
    //// * @param waylineId
    //// * @return
    //// */
    ////@DeleteMapping("/{workspace_id}/waylines/{wayline_id}")
    ////    public ResponseResult deleteWayline(@PathVariable(name = "workspace_id") String workspaceId,
    ////                                        @PathVariable(name = "wayline_id") String waylineId) {
    ////    boolean isDel = waylineFileService.deleteByWaylineId(workspaceId, waylineId);
    ////    return isDel ? ResponseResult.success() : ResponseResult.error("Failed to delete wayline.");
    ////}

    [HttpPost("{workspaceId}/waylines/file/upload")]
    public async Task<IActionResult> ImportKmzFileAsync([FromRoute] string workspaceId)
    {
        // TODO:

        return Ok();
    }

    ///**
    // * Import kmz wayline files.
    // * @param file
    // * @return
    // */
    //@PostMapping("/{workspace_id}/waylines/file/upload")
    //    public ResponseResult importKmzFile(HttpServletRequest request, MultipartFile file)
    //{
    //    if (Objects.isNull(file))
    //    {
    //        return ResponseResult.error("No file received.");
    //    }
    //    CustomClaim customClaim = (CustomClaim)request.getAttribute(TOKEN_CLAIM);
    //    String workspaceId = customClaim.getWorkspaceId();
    //    String creator = customClaim.getUsername();
    //    waylineFileService.importKmzFile(file, workspaceId, creator);
    //    return ResponseResult.success();
    //}
}
