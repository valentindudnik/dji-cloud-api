using Dji.Cloud.Domain.Wayline;
using Dji.Cloud.Domain;
using Microsoft.AspNetCore.Mvc;
using Dji.Cloud.Application.Abstracts.Interfaces.Wayline;

namespace Dji.Cloud.Api.Host.Controllers.Wayline;

[//Authorize,
 ApiController,
 ApiVersion("1.0"),
 Area("Wayline"),
 Route("[area]/api/v{version:apiVersion}/workspaces")]
public class WaylineJobController : ControllerBase
{
    private readonly IWaylineJobService _service;

    public WaylineJobController(IWaylineJobService service)
    {
        _service = service;
    }

    [HttpPost("{workspaceId}/flight-tasks")]
    public async Task<IActionResult> CreateJobAsync([FromRoute] string workspaceId, [FromBody] CreateJobRequest request)
    {
        // TODO:

        var customClaim = new TokenInfo { WorkspaceId = workspaceId };

        //(CustomClaim)request.getAttribute(TOKEN_CLAIM);

        //customClaim.setWorkspaceId(workspaceId);

        var response = await _service.PublishFlightTaskAsync<CreateJobRequest>(request, customClaim);

        return Ok(response);
    }

    [HttpGet("{workspaceId}/jobs")]
    public async Task<IActionResult> GetJobsAsync([FromRoute] string workspaceId)
    {
        // TODO:

        var response = await _service.GetJobsByWorkspaceIdAsync(workspaceId, 0, 0);

        return Ok();
    }

    [HttpDelete("{workspaceId}/jobs")]
    public async Task<IActionResult> PublishCancelJobAsync([FromRoute] string workspaceId)
    {
        // TODO:

        return Ok();
    }

    [HttpPost("{workspaceId}/jobs/{jobId}/media-highest")]
    public async Task<IActionResult> UploadMediaHighestPriorityAsync([FromRoute] string workspaceId)
    {
        // TODO:

        return Ok();
    }
}
