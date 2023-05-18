using Dji.Cloud.Application.Abstracts.Constants;
using Dji.Cloud.Application.Abstracts.Interfaces.Common;
using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Manage;
using Dji.Cloud.Infrastructure.Host.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Dji.Cloud.Api.Host.Controllers.Manage;

[ApiController,
 Area("Manage"),
 Route("[area]/api/v{version:apiVersion}/workspaces")]
public class DeviceFirmwareController : ControllerBase
{
    private readonly ITokenService _tokenService;
    private readonly IDeviceFirmwareService _deviceFirmwareService;

    public DeviceFirmwareController(ITokenService tokenService, IDeviceFirmwareService deviceFirmwareService)
    {
        _tokenService = tokenService;
        _deviceFirmwareService = deviceFirmwareService;
    }

    /// <summary>
    /// Get the latest firmware version information for this device model.
    /// </summary>
    /// <returns></returns>
    [HttpGet("firmware-release-notes/latest"),
     ProducesResponseType(typeof(BaseResponse<IEnumerable<string>>), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetLatestFirmwareNoteAsync([FromQuery] GetLatestFirmwareNoteRequest request)
    {
        var releaseNotes = new List<DeviceFirmwareNote>();

        foreach (var deviceName in request.DeviceNames!)
        {
            var releaseNote = await _deviceFirmwareService.GetLatestFirmwareReleaseNoteAsync(deviceName);
            if (releaseNote != null)
            {
                releaseNotes.Add(releaseNote);
            }
        }

        var deviceNames = releaseNotes.Select(entity => entity.DeviceName)
                                      .ToArray();

        var response = BaseResponse<IEnumerable<string>>.Success(deviceNames!);

        return Ok(response);
    }

    /// <summary>
    /// Query firmware information based on request.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="request">the request</param>
    /// <returns></returns>
    [HttpGet("{workspaceId}/firmwares"),
     ProducesResponseType(typeof(BaseResponse<PaginationResponse<DeviceFirmware>>), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetFirmwaresAsync([FromRoute] string workspaceId, [FromQuery] DeviceFirmwareQueryRequest request)
    {
        var devices = await _deviceFirmwareService.GetFirmwaresAsync(workspaceId, request);

        var response = BaseResponse<PaginationResponse<DeviceFirmware>>.Success(devices);

        return Ok(response);
    }

    /// <summary>
    /// Import firmware file for device upgrades.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="request">the request</param>
    /// <returns></returns>
    [HttpPost("{workspaceId}/firmwares/file/upload"),
     ProducesResponseType(typeof(BaseResponse<DeviceFirmware>), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> ImportFirmwareFileAsync([FromRoute] string workspaceId, [FromForm] DeviceFirmwareUpdateRequest request)
    {
        var response = BaseResponse<DeviceFirmware>.Success();

        foreach (var file in Request.Form.Files)
        {
            if (!file.FileName.EndsWith(FirmwareFileProperties.FirmwareFileSuffix))
            {
                var message = "The file format is incorrect.";
                response = BaseResponse<DeviceFirmware>.Error(message);

                return BadRequest(response);
            }

            var tokenInfo = _tokenService.GetTokenInfo(Request.Headers.GetToken());

            using var stream = file.OpenReadStream();
            await _deviceFirmwareService.ImportFirmwareFileAsync(workspaceId, tokenInfo.UserName!, request, file.FileName, stream);
        }

        return Ok(response);
    }

    /// <summary>
    /// Change the firmware availability status.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="firmwareId">the firmware id</param>
    /// <param name="request">the request</param>
    /// <returns></returns>
    [HttpPut("{workspaceId}/firmwares/{firmwareId}"),
     ProducesResponseType(typeof(BaseResponse<DeviceFirmware>), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> ChangeFirmwareStatusAsync([FromRoute] string workspaceId, [FromRoute] string firmwareId, [FromBody] DeviceFirmwareUpdateRequest request)
    {
        await _deviceFirmwareService.UpdateFirmwareInfoAsync(workspaceId, firmwareId, request);

        var response = BaseResponse<DeviceFirmware>.Success();

        return Ok(response);
    }
}
