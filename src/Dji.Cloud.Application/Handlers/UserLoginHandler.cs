using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Application.Commands.Manage;
using Dji.Cloud.Domain.Manage;
using MediatR;

namespace Dji.Cloud.Application.Handlers;

public class UserLoginHandler : IRequestHandler<UserLoginCommand, BaseResponse<User>>
{
    private readonly IUserService _service;

    public UserLoginHandler(IUserService service)
    {
        _service = service;
    }

    /// <summary>
    /// Handle login of user
    /// </summary>
    /// <param name="command">the request</param>
    /// <param name="cancellationToken">the cancellation token</param>
    /// <returns></returns>
    public async Task<BaseResponse<User>> Handle(UserLoginCommand command, CancellationToken cancellationToken)
    {
        var response = await _service.LoginAsync(command.UserName!, command.Password!, command.Flag);

        return response;
    }
}
