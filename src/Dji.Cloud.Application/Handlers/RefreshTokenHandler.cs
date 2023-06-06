using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Application.Commands.Manage;
using Dji.Cloud.Application.Extensions;
using Dji.Cloud.Domain.Enums;
using Dji.Cloud.Domain.Manage;
using MediatR;
using System.Net;

namespace Dji.Cloud.Application.Handlers;

public class RefreshTokenHandler : IRequestHandler<RefreshTokenCommand, BaseResponse<User>>
{
    private readonly IUserService _service;

    public RefreshTokenHandler(IUserService service)
    {
        _service = service;
    }

    public async Task<BaseResponse<User>> Handle(RefreshTokenCommand command, CancellationToken cancellationToken)
    {
        var user = await _service.RefreshTokenAsync(command.Token!);

        var response = !string.IsNullOrEmpty(user.AccessToken) ? BaseResponse<User>.Success(user)
                                                               : BaseResponse<User>.Error((int)HttpStatusCode.Unauthorized, CommonErrors.NoToken.GetDescription());

        return response!;
    }
}
