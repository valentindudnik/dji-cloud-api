using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Manage;
using MediatR;

namespace Dji.Cloud.Application.Commands.Manage;

public class UserLoginCommand : IRequest<BaseResponse<User>>
{
    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int Flag { get; set; }
}
