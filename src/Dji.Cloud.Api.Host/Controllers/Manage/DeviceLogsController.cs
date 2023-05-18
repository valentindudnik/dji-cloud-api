using Dji.Cloud.Application.Abstracts.Interfaces.Common;
using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Manage;
using Dji.Cloud.Infrastructure.Host.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Dji.Cloud.Api.Host.Controllers.Manage;

[ApiController,
 Area("Manage"),
 Route("[area]/api/v{version:apiVersion}/[controller]")]
public class DeviceLogsController : ControllerBase
{
    private readonly ITokenService _tokenService;
    private readonly IDeviceLogsService _deviceLogsService;
    
    private readonly ILogger<DeviceLogsController> _logger;

    public DeviceLogsController(ITokenService tokenService, 
                                IDeviceLogsService deviceLogsService, 
                                ILogger<DeviceLogsController> logger)
    {
        _tokenService = tokenService;
        _deviceLogsService = deviceLogsService;

        _logger = logger;
    }

    /// <summary>
    /// Obtain the device upload log list by paging according to the query parameters.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="serialNumber">the serial number</param>
    /// <param name="request">the request</param>
    /// <returns></returns>
    [HttpGet("{workspaceId}/devices/{serialNumber}/logs-uploaded"),
     ProducesResponseType(typeof(BaseResponse<PaginationResponse<DeviceLogs>>), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetUploadedLogsAsync([FromRoute] string workspaceId, [FromRoute] string serialNumber, [FromQuery] DeviceLogsQueryRequest request)
    {
        var paginationResponse = await _deviceLogsService.GetUploadedLogsAsync(serialNumber, request);

        var response = BaseResponse<PaginationResponse<DeviceLogs>>.Success(paginationResponse);

        return Ok(response);
    }

    ///**
    // * Get a list of log files that can be uploaded in real time.
    // * @param workspaceId
    // * @param deviceSn
    // * @param domainList
    // * @return
    // */
    //@GetMapping("/{workspace_id}/devices/{device_sn}/logs")
    //    public ResponseResult getLogsBySn(@PathVariable("workspace_id") String workspaceId,
    //                                      @PathVariable("device_sn") String deviceSn,
    //                                      @RequestParam("domain_list") List<String> domainList) {
    //        return deviceLogsService.getRealTimeLogs(deviceSn, domainList);
    //    }

    [HttpGet("{workspaceId}/devices/{serialNumber}/logs"),
     ProducesResponseType(typeof(BaseResponse<PaginationResponse<DeviceLogs>>), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetLogsBySerialNumberAsync([FromRoute] string workspaceId, [FromRoute] string serialNumber)
    {
        // TODO:

        //_service.GetRealTimeLogsAsync(serialNumber)

        return Ok();
    }

    //    /**
    //     * Initiate a log upload request to the gateway.
    //     * @return
    //     */
    //    @PostMapping("/{workspace_id}/devices/{device_sn}/logs")
    //    public ResponseResult uploadLogs(@PathVariable("workspace_id") String workspaceId,
    //                                     @PathVariable("device_sn") String deviceSn,
    //                                     HttpServletRequest request, @RequestBody DeviceLogsCreateParam param) {

    //    CustomClaim customClaim = (CustomClaim)request.getAttribute(TOKEN_CLAIM);

    //    return deviceLogsService.pushFileUpload(customClaim.getUsername(), deviceSn, param);
    //}

    [HttpPost("{workspaceId}/devices/{serialNumber}/logs")]
    public async Task<IActionResult> UploadLogsAsync([FromRoute] string workspaceId, [FromRoute] string serialNumber, [FromBody] DeviceLogsCreateRequest request)
    {
        var tokenInfo = _tokenService.GetTokenInfo(Request.Headers.GetToken());

        // var response = await _deviceLogsService.PushFileUploadAsync(tokenInfo.UserName, serialNumber, request);

        // TODO:

        return Ok();
    }

    ///**
    // * Cancel logs file upload.
    // * @return
    // */
    //@DeleteMapping("/{workspace_id}/devices/{device_sn}/logs")
    //    public ResponseResult cancelUploadedLogs(@PathVariable("workspace_id") String workspaceId,
    //                                             @PathVariable("device_sn") String deviceSn,
    //                                             @RequestBody LogsFileUpdateParam param) {

    //    return deviceLogsService.pushUpdateFile(deviceSn, param);
    //}

    ///**
    // * Delete upload history.
    // * @return
    // */
    //@DeleteMapping("/{workspace_id}/devices/{device_sn}/logs/{logs_id}")
    //    public ResponseResult deleteUploadedLogs(@PathVariable("workspace_id") String workspaceId,
    //                                             @PathVariable("device_sn") String deviceSn,
    //                                             @PathVariable("logs_id") String logsId) {
    //    deviceLogsService.deleteLogs(deviceSn, logsId);
    //    return ResponseResult.success();
    //}

    [HttpGet("{workspaceId}/logs/{logsId}/url/{fileId}")]
    public async Task<IActionResult> GetFileUrlAsync([FromRoute] string workspaceId, [FromRoute] string logsId, [FromRoute] string fileId)
    {
        const string message = "Failed to get the logs file download address.";

        BaseResponse<Uri> response;

        try
        {
            var uri = await _deviceLogsService.GetLogsFileUriAsync(logsId, fileId);

            response = BaseResponse<Uri>.Success(uri);

            return Ok(response);
        }
        catch (Exception exc)
        {
            _logger.LogError(exc, message);
            response = BaseResponse<Uri>.Error(message);

            return BadRequest(response);
        }
    }

    ///**
    // * Query the download address of the file according to the wayline file id,
    // * and redirect to this address directly for download.
    // * @param workspaceId
    // * @param fileId
    // * @param logsId
    // * @param response
    // */
    //@GetMapping("/{workspace_id}/logs/{logs_id}/url/{file_id}")
    //    public ResponseResult getFileUrl(@PathVariable(name = "workspace_id") String workspaceId,
    //                            @PathVariable(name = "file_id") String fileId,
    //                           @PathVariable(name = "logs_id") String logsId, HttpServletResponse response) {

    //    try
    //    {
    //        URL url = deviceLogsService.getLogsFileUrl(logsId, fileId);
    //        return ResponseResult.success(url.toString());
    //    }
    //    catch (Exception e)
    //    {
    //        log.error("Failed to get the logs file download address.");
    //        e.printStackTrace();
    //    }
    //    return ResponseResult.error("Failed to get the logs file download address.");
    //}
}
