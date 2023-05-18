using Dji.Cloud.Application.Abstracts.Requests.Manage;
using FluentValidation;

namespace Dji.Cloud.Application.Validators;

public class UserLoginRequestValidator : AbstractValidator<UserLoginRequest>
{
    public UserLoginRequestValidator()
    {
        RuleFor(x => x.UserName).NotNull().NotEmpty().WithMessage("User Name is required.");
        RuleFor(x => x.Password).NotNull().NotEmpty().WithMessage("Password is required.");
        RuleFor(x => x.Flag).NotNull().WithMessage("Flag is required.");
    }
}
