using Dji.Cloud.Application.Abstracts.Interfaces.Control;
using Dji.Cloud.Application.Abstracts.Requests.Control;
using Microsoft.AspNetCore.Mvc;

namespace Dji.Cloud.Api.Host.Controllers.Control;

[ApiController,
 Route("[controller]")]
public class DockController : ControllerBase
{
    private readonly IControlService _service;

    public DockController(IControlService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create control job
    /// </summary>
    /// <param name="serialNumber">serial number</param>
    /// <param name="serviceIdentifier">service identifier</param>
    /// <param name="request">request</param>
    /// <returns></returns>
    [HttpPost("devices/{serialNumber}/jobs/{serviceIdentifier}")]
    public async Task<IActionResult> ControlDockAsync([FromRoute] string serialNumber, [FromRoute] string serviceIdentifier, [FromBody] RemoteDebugRequest request)
    {
        var response = await _service.ControlDockAsync(serialNumber, serviceIdentifier, request);

        return Ok(response);
    }
}
