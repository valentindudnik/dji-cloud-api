using Dji.Cloud.Application.Abstracts.Interfaces.Media;
using Microsoft.AspNetCore.Mvc;
using Dji.Cloud.Application.Abstracts.Requests.Media;
using Dji.Cloud.Application.Abstracts.Responses.Common;

namespace Dji.Cloud.Api.Host.Controllers.Media;

[//Authorize,
 ApiController,
 ApiVersion("1.0"),
 Area("Media"),
 Route("[area]/api/v{version:apiVersion}/workspaces")]
public class MediaController : ControllerBase
{
    private readonly IMediaService _service;

    public MediaController(IMediaService service)
    {
        _service = service;
    }

    /// <summary>
    /// Check if the file has been uploaded by the fingerprint.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="request">the request</param>
    /// <returns></returns>
    [HttpPost("{workspaceId}/fast-upload"),
     ProducesResponseType(typeof(string), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> FastUploadAsync([FromRoute] string workspaceId, [FromBody] FileUploadRequest request) 
    {
        var isExists = await _service.FastUploadAsync(workspaceId, request.Fingerprint!);

        var response = isExists ? BaseResponse<string>.Success() : BaseResponse<string>.Error($"{request.Fingerprint} don't exist.");

        return Ok(response);
    }

    /// <summary>
    /// When the file is uploaded to the storage server by pilot,
    /// the basic information of the file is reported through this interface.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="request">the request</param>
    /// <returns></returns>
    [HttpPost("{workspaceId}/upload-callback"),
     ProducesResponseType(typeof(string), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> UploadCallbackAsync([FromRoute] string workspaceId, [FromBody] FileUploadRequest request)
    {
        await _service.SaveMediaFileAsync(workspaceId, request);

        var response = BaseResponse<string>.Success(request.ObjectKey!);

        return Ok(response);
    }

    [HttpPost("{workspaceId}/files/tiny-fingerprints")]
    public async Task<IActionResult> UploadCallbackAsync([FromRoute] string workspaceId)
    {
        // TODO:

        var tinyFingerPrints = new List<string>();

        var result = _service.GetExistTinyFingerprints(workspaceId, null);

        return Ok();
    }

    //    /**
    //     * Query the files that already exist in this workspace based on the workspace id and the collection of tiny fingerprints.
    //     * @param workspaceId
    //     * @param tinyFingerprints  There is only one tiny_fingerprint parameter in the body.
    //     *                          But it is not recommended to use Map to receive the parameter.
    //     * @return
    //     */
    //    @PostMapping("/{workspace_id}/files/tiny-fingerprints")
    //    public ResponseResult<Map<String, List<String>>> uploadCallback(
    //                                @PathVariable(name = "workspace_id") String workspaceId,
    //                               @RequestBody Map<String, List<String>> tinyFingerprints) throws JsonProcessingException
    // {
    //    List<String> existingList = mediaService.getExistTinyFingerprints(workspaceId, tinyFingerprints.get(MapKeyConst.TINY_FINGERPRINTS));
    //    return ResponseResult.success(new ConcurrentHashMap<>(Map.of(MapKeyConst.TINY_FINGERPRINTS, existingList)));
    //    }
    //}
}