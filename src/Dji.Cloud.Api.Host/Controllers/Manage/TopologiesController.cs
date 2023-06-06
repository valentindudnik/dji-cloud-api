using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Manage;
using Microsoft.AspNetCore.Mvc;

namespace Dji.Cloud.Api.Host.Controllers.Manage;

[ApiController,
 Area("Manage"),
 Route("[area]/api/v{version:apiVersion}/workspaces")]
public class TopologiesController : ControllerBase
{
    private readonly ITopologyService _service;

    public TopologiesController(ITopologyService service)
    {
        _service = service;
    }

    /// <summary>
    /// Get the topology list of all devices in the current user workspace for pilot display.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <returns>the list of topologies</returns>
    [HttpGet("{workspaceId}/devices/topologies"),
     ProducesResponseType(typeof(IEnumerable<Topology>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetDevicesTopologiesForPilotAsync([FromRoute] string workspaceId) 
    {
        var deviceTopologies = await _service.GetDeviceTopologiesAsync(workspaceId);

        var response = BaseResponse<IEnumerable<Topology>>.Success(deviceTopologies);

        return Ok(response);
    }
}
