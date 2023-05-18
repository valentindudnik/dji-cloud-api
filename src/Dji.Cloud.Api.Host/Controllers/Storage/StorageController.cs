using Dji.Cloud.Application.Abstracts.Interfaces.Storage;
using Microsoft.AspNetCore.Mvc;

namespace Dji.Cloud.Api.Host.Controllers.Storage;

[//Authorize,
 ApiController,
 ApiVersion("1.0"),
 Area("Storage"),
 Route("[area]/api/v{version:apiVersion}/workspaces")]
public class StorageController : ControllerBase
{
    private readonly IStorageService _service;

    public StorageController(IStorageService service)
    {
        _service = service;
    }

    /// <summary>
    /// Get temporary credentials for uploading the media and wayline in DJI Pilot.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <returns></returns>
    [HttpPost("{workspaceId}/sts")]
    public async Task<IActionResult> GetStsCredentialsAsync([FromRoute] string workspaceId)
    {
        var response = await _service.GetStsCredentialsAsync(workspaceId);

        return Ok(response);
    }
}
