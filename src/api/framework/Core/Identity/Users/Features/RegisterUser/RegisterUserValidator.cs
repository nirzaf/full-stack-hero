using FluentValidation;

namespace FSH.Framework.Core.Identity.Users.Features.RegisterUser;

public class RegisterUserValidator : AbstractValidator<RegisterUserCommand>
{
    public RegisterUserValidator()
    {
        RuleFor(p => p.FirstName)
            .NotEmpty()
            .WithMessage("First name is required.");

        RuleFor(p => p.LastName)
            .NotEmpty()
            .WithMessage("Last name is required.");

        RuleFor(p => p.Email)
            .NotEmpty()
            .EmailAddress()
            .WithMessage("A valid email is required.");

        RuleFor(p => p.ConfirmEmail)
            .Equal(p => p.Email)
            .WithMessage("Emails do not match.");

        RuleFor(p => p.UserName)
            .NotEmpty()
            .WithMessage("Username is required.");

        RuleFor(p => p.Password)
            .NotEmpty()
            .WithMessage("Password is required.");

        RuleFor(p => p.ConfirmPassword)
            .Equal(p => p.Password)
            .WithMessage("Passwords do not match.");
    }
}
