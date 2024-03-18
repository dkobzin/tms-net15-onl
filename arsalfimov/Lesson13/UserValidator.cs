using FluentValidation;

namespace Authorization;

internal class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(user => user.Login)
            .NotEmpty().WithMessage("Login cannot be empty.")
            .MaximumLength(20).WithMessage("Login length must be less than 20 characters.")
            .Must(login => !login.Contains(' ')).WithMessage("Login must not contain spaces.");

        RuleFor(user => user.Password)
            .NotEmpty().WithMessage("Password cannot be empty.")
            .MaximumLength(20).WithMessage("Password length must be less than 20 characters.")
            .Must(password => !password.Contains(' ')).WithMessage("Password must not contain spaces.")
            .Must(password => password.Any(char.IsDigit)).WithMessage("Password must contain at least one digit.");

        RuleFor(user => user.ConfirmPassword)
            .Equal(user => user.Password).WithMessage("Password and confirmation password must match.");
    }
}