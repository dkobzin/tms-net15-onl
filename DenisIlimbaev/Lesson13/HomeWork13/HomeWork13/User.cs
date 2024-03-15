using System;
using FluentValidation;
using FluentValidation.Validators;
namespace HomeWork13
{
    internal class User
    {
        internal string? Login {  get; set; }
        internal string? Password { get; set; }
        internal string? ConfirmPassword { get; set; }
    }
    internal class UserValidator : AbstractValidator<User>
    {
        internal const string LoginSetName = "LoginSet";
        internal const string PasswordSetName = "PasswordSet";
        internal UserValidator(string confirmPassword)
        {
            RuleSet(LoginSetName, () => {
                RuleFor(valid => valid.Login).NotEmpty().NotNull();
                RuleFor(valid => valid.Login!.Length).LessThan(20);
                RuleForEach(valid => valid.Login!).NotEqual(' ');
                });
            RuleSet(PasswordSetName, () =>
            {
                RuleFor(valid => valid.Password!.Length).LessThan(20); ;
                RuleFor(valid => valid.Password).NotEmpty().NotNull(); ;
                RuleForEach(valid => valid.Password!).NotEqual(' ');
                RuleFor(valid => valid.Password!).Equal(confirmPassword);

            });
       
        }
       
    }
}
