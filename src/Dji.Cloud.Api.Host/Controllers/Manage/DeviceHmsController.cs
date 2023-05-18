using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Manage;
using Microsoft.AspNetCore.Mvc;

namespace Dji.Cloud.Api.Host.Controllers.Manage;

[ApiController,
 Area("Manage"),
 Route("[area]/api/v{version:apiVersion}")]
public class DeviceHmsController : ControllerBase
{
    private readonly IDeviceHmsService _service;

    public DeviceHmsController(IDeviceHmsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Page to query the hms information of the device.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="request">the request</param>
    /// <returns></returns>
    [HttpGet("{workspaceId}/devices/hms"),
     ProducesResponseType(typeof(BaseResponse<PaginationResponse<DeviceHms>>), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetHmsInfoAsync([FromRoute] string workspaceId, [FromQuery] DeviceHmsQueryRequest request)
    {
        var devices = await _service.GetDeviceHmsAsync(workspaceId, request);

        var response = BaseResponse<PaginationResponse<DeviceHms>>.Success(devices);

        return Ok(response);
    }

    /// <summary>
    /// Update unread hms messages to read status.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="serialNumber">the serial number</param>
    /// <returns></returns>
    [HttpPut("{workspaceId}/devices/hms/{serialNumber}"),
     ProducesResponseType(typeof(BaseResponse<DeviceHms>), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> UpdateReadHmsByDeviceSerialNumberAsync([FromRoute] string workspaceId, [FromRoute] string serialNumber)
    {
        await _service.UpdateUnreadHmsAsync(serialNumber);

        var response = BaseResponse<DeviceHms>.Success();

        return Ok(response);
    }

    /// <summary>
    /// Get hms messages for a single device.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="serialNumber">the serial number</param>
    /// <returns></returns>
    [HttpGet("{workspaceId}/devices/hms/{serialNumber}"),
     ProducesResponseType(typeof(BaseResponse<PaginationResponse<DeviceHms>>), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetDeviceHmsAsync([FromRoute] string workspaceId, [FromRoute] string serialNumber)
    {
        var request = new DeviceHmsQueryRequest {
            SerialNumber = serialNumber,
            UpdateTime = DateTime.FromBinary(0L)
        };

        var devices = await _service.GetDeviceHmsAsync(workspaceId, request);

        var response = BaseResponse<PaginationResponse<DeviceHms>>.Success(devices);

        return Ok(response);
    }
}
