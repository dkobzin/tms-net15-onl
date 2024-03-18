namespace Authorization;

internal static class Program
{
    private static void Main()
    {
        var user = new User();

        Console.Write("Enter your username: ");
        user.Login = Console.ReadLine()!;

        Console.Write("Enter the password: ");
        user.Password = Console.ReadLine()!;

        Console.Write("Confirm the password: ");
        user.ConfirmPassword = Console.ReadLine()!;

        var validator = new UserValidator();
        var validationResult = validator.Validate(user);

        if (validationResult.IsValid)
        {
            Console.WriteLine("The user's data has been verified successfully.");
        }
        else
        {
            foreach (var error in validationResult.Errors)
                Console.WriteLine($"Error: {error.ErrorMessage}");

            if (validationResult.Errors.Exists(error => error.ErrorCode == nameof(WrongLoginException)))
                throw new WrongLoginException(validationResult.Errors
                    .First(error => error.ErrorCode == nameof(WrongLoginException)).ErrorMessage);

            if (validationResult.Errors.Exists(error => error.ErrorCode == nameof(WrongPasswordException)))
                throw new WrongPasswordException(validationResult.Errors
                    .First(error => error.ErrorCode == nameof(WrongPasswordException)).ErrorMessage);
        }
    }
}