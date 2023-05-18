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
public class WorkspacesController : ControllerBase
{
    private readonly ITokenService _tokenService;
    private readonly IWorkspaceService _workspaceService;
    
    public WorkspacesController(ITokenService tokenService, IWorkspaceService workspaceService)
    {
        _tokenService = tokenService;
        _workspaceService = workspaceService;
    }

    /// <summary>
    /// Gets information about the workspace that the current user is in.
    /// </summary>
    /// <returns>the workspace</returns>
    [HttpGet("current"),
     ProducesResponseType(typeof(Workspace), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetWorkspaceAsync()
    {
        var tokenInfo = _tokenService.GetTokenInfo(Request.Headers.GetToken());

        var workspace = await _workspaceService.GetWorkspaceByWorkspaceIdAsync(tokenInfo.WorkspaceId!);

        var response = workspace != null ? BaseResponse<Workspace>.Success(workspace) : BaseResponse<Workspace>.Error();

        return Ok(response);
    }
}
