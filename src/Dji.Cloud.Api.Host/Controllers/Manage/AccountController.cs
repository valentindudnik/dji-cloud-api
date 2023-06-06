using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Infrastructure.Host.Extensions;
using Dji.Cloud.Domain.Manage;
using Microsoft.AspNetCore.Mvc;
using Dji.Cloud.Application.Abstracts.Interfaces.Common;
using Dji.Cloud.Application.Commands.Manage;

namespace Dji.Cloud.Api.Host.Controllers.Manage;

[ApiController,
 Area("Manage"),
 Route("[area]/api/v{version:apiVersion}")]
public class AccountController : ControllerBase
{
    private readonly IMediatorService _service;

    public AccountController(IMediatorService service)
    {
        _service = service;
    }

    /// <summary>
    /// Login
    /// </summary>
    /// <param name="request">the user login request</param>
    /// <returns>token</returns>
    [HttpPost("login"),
     ProducesResponseType(typeof(BaseResponse<User>), StatusCodes.Status200OK)]
    public async Task<IActionResult> LoginAsync([FromBody] UserLoginRequest request)
    { 
        var response = await _service.SendAsync<UserLoginRequest, UserLoginCommand, BaseResponse<User>>(request);

        return Ok(response);
    }

    /// <summary>
    /// Refresh token
    /// </summary> 
    /// <returns>token</returns>
    [HttpPost("token/refresh"),
     ProducesResponseType(typeof(BaseResponse<User>), StatusCodes.Status200OK)]
    public async Task<IActionResult> RefreshTokenAsync()
    {
        var token = Request.Headers.GetToken();

        var command = new RefreshTokenCommand { Token = token };

        var response = await _service.SendAsync<RefreshTokenCommand, BaseResponse<User>>(command);

        return Ok(response);
    }
}
