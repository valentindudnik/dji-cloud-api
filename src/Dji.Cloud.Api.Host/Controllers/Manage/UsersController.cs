using Dji.Cloud.Application.Abstracts.Interfaces.Common;
using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Application.Abstracts.Requests.Common;
using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Manage;
using Dji.Cloud.Infrastructure.Host.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Dji.Cloud.Api.Host.Controllers.Manage;

[ApiController,
 Area("Manage"),
 Route("[area]/api/v{version:apiVersion}/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly ITokenService _tokenService;

    public UsersController(IUserService userService, ITokenService tokenService)
    {
        _userService = userService;
        _tokenService = tokenService;
    }

    /// <summary>
    /// Query the information of the current user.
    /// </summary>
    /// <returns>the user</returns>
    [HttpGet("current"),
     ProducesResponseType(typeof(PaginationResponse<User>), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetCurrentUserInfoAsync()
    {
        var tokenInfo = _tokenService.GetTokenInfo(Request.Headers.GetToken());

        var response = await _userService.GetUserByUserNameAsync(tokenInfo.UserName!, tokenInfo.WorkspaceId!);

        return Ok(response);
    }

    /// <summary>
    /// Paging to query all users in a workspace.
    /// </summary>
    /// <param name="workspaceId"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpGet("{workspaceId}/users"),
     ProducesResponseType(typeof(PaginationResponse<UserInfo>), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetUsersAsync([FromRoute] string workspaceId, [FromQuery] PaginationRequest request)
    {
        var response = await _userService.GetUsersByWorkspaceIdAsync(workspaceId, request);

        return Ok(response);
    }

    /// <summary>
    /// Modify user information. Only mqtt account information is included, nothing else can be modified.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="userId">the user id</param>
    /// <param name="request">the request</param>
    /// <returns>The status of user update</returns>
    [HttpPut("{workspaceId}/users/{userId}"),
     ProducesResponseType(typeof(BaseResponse<object>), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> UpdateUserAsync([FromRoute] string workspaceId, [FromRoute] string userId, [FromBody] UserRequest request)
    {
        var status = await _userService.UpdateUserAsync(workspaceId, userId, request);

        var response = BaseResponse<object>.Success(status);

        return Ok(response);
    }
}
