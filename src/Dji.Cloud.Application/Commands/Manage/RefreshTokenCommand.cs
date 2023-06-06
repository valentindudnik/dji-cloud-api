using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Manage;
using MediatR;

namespace Dji.Cloud.Application.Commands.Manage;

public class RefreshTokenCommand : IRequest<BaseResponse<User>>
{
    public string? Token { get; set; }
}
