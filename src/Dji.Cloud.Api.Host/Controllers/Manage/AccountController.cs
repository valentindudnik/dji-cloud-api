using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Infrastructure.Host.Extensions;
using Dji.Cloud.Domain.Enums;
using Dji.Cloud.Domain.Manage;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Dji.Cloud.Api.Host.Controllers.Manage;

[ApiController,
 Area("Manage"),
 Route("[area]/api/v{version:apiVersion}")]
public class AccountController : ControllerBase
{
    private readonly IUserService _service;

    public AccountController(IUserService service)
    {
        _service = service;
    }

    /// <summary>
    /// Login
    /// </summary>
    /// <param name="request">the user login request</param>
    /// <returns>token</returns>
    [HttpPost("login"),
     ProducesResponseType(typeof(BaseResponse<User>), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> LoginAsync([FromBody] UserLoginRequest request)
    {
        var response = await _service.LoginAsync(request);

        return Ok(response);
    }

    /// <summary>
    /// Refresh token
    /// </summary>
    /// <returns>token</returns>
    [HttpPost("token/refresh"),
     ProducesResponseType(typeof(BaseResponse<User>), StatusCodes.Status200OK),
     ProducesResponseType(StatusCodes.Status400BadRequest),
     ProducesResponseType(StatusCodes.Status404NotFound),
     ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> RefreshTokenAsync()
    {
        BaseResponse<User> response;

        var token = Request.Headers.GetToken();

        var user = await _service.RefreshTokenAsync(token);

        response = !string.IsNullOrEmpty(user.AccessToken) ? BaseResponse<User>.Success(user)
                                                           : BaseResponse<User>.Error((int)HttpStatusCode.Unauthorized, CommonErrors.NoToken.GetDescription());

        return Ok(response);
    }
}
