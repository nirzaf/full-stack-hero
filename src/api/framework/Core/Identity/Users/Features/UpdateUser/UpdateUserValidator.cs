using FluentValidation;

namespace FSH.Framework.Core.Identity.Users.Features.UpdateUser;

public class UpdateUserValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserValidator()
    {
        RuleFor(p => p.Email)
            .NotEmpty()
            .EmailAddress()
            .WithMessage("A valid email is required.");

        RuleFor(p => p.ConfirmEmail)
            .Equal(p => p.Email)
            .WithMessage("Emails do not match.");
    }
}
