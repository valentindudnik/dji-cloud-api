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
 Route("[area]/api/v{version:apiVersion}/live")]
public class LiveStreamsController : ControllerBase
{
    private readonly ITokenService _tokenService;
    private readonly ILiveStreamService _liveStreamService;

    public LiveStreamsController(ITokenService tokenService, ILiveStreamService liveStreamService)
    {
        _tokenService = tokenService;
        _liveStreamService = liveStreamService;
    }

    /// <summary>
    /// Get live capability data of all drones in the current user's workspace from the database.
    /// </summary>
    /// <returns>The live capacities</returns>
    [HttpGet("capacity"),
     ProducesResponseType(typeof(IEnumerable<CapacityDevice>), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetLiveCapacityAsync()
    {
        // Get information about the current user.
        var token = Request.Headers.GetToken();

        var tokenInfo = _tokenService.GetTokenInfo(token);

        var liveCapacities = await _liveStreamService.GetLiveCapacityAsync(tokenInfo.WorkspaceId!);

        var response = BaseResponse<IEnumerable<CapacityDevice>>.Success(liveCapacities);

        return Ok(response);
    }

    /// <summary>
    /// Live streaming according to the parameters passed in from the web side.
    /// </summary>
    /// <param name="request">The live request</param>
    /// <returns></returns>
    [HttpPost("streams/start"),
     ProducesResponseType(typeof(Live), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> LiveStartAsync([FromBody] LiveTypeRequest request)
    {
        var response = await _liveStreamService.LiveStartAsync(request);

        return Ok(response);
    }

    /// <summary>
    /// Stop live streaming according to the parameters passed in from the web side.
    /// </summary>
    /// <param name="request">The live request</param>
    /// <returns></returns>
    [HttpPost("streams/stop"), 
     ProducesResponseType(typeof(Device), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> LiveStopAsync([FromBody] LiveTypeRequest request)
    {
        var response = await _liveStreamService.LiveStopAsync(request.VideoId!);

        return Ok(response);
    }

    /// <summary>
    /// Set the quality of the live streaming according to the parameters passed in from the web side.
    /// </summary>
    /// <param name="request">The request</param>
    /// <returns></returns>
    [HttpPost("streams/update"),
     ProducesResponseType(typeof(Device), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> LiveSetQualityAsync([FromBody] LiveTypeRequest request)
    {
        var response = await _liveStreamService.LiveSetQualityAsync(request);

        return Ok(response);
    }

    /// <summary>
    /// Live lens changeing to the parameters passed in from the web side. 
    /// </summary>
    /// <param name="request">The request</param>
    /// <returns></returns>
    [HttpPost("streams/switch"),
     ProducesResponseType(typeof(Device), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> LiveLensChangeAsync([FromBody] LiveTypeRequest request) 
    {
        var response = await _liveStreamService.LiveLensChangeAsync(request);

        return Ok(response);
    }

    //    /**
    //     * Analyze the live streaming capabilities of drones.
    //     * This data is necessary if drones are required for live streaming.
    //     * @param liveCapacity    the capacity of drone and dock
    //     */
    //    @ServiceActivator(inputChannel = ChannelName.INBOUND_STATE_CAPACITY)
    //    public void stateCapacity(LiveCapacityReceiver liveCapacity, MessageHeaders headers)
    //    {
    //        liveStreamService.saveLiveCapacity(liveCapacity, headers.getTimestamp());
    //    }
}
