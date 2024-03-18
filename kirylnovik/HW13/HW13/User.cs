namespace HW13;

public class User(string login, string password, string confirmPassword)
{
    public string Login { get; } = login;
    public string Password { get; } = password;
    public string ConfirmPassword { get; } = confirmPassword;

    public static void ValidateLogin(string login)
    {
        if (login.Length >= 20 || login.Contains(' '))
        {
            throw new WrongLoginException("Login должен быть меньше 20 символов и не содержать пробелов!");
        }
    }

    public static void ValidatePassword(string password, string confirmPassword)
    {
        if (password.Length >= 20 || password.Contains(' ') || !password.Any(char.IsDigit))
        {
            throw new WrongPasswordException(
                "Password должен быть менее 20 символов, не содержать пробелы и должен содержать хотя бы одну цифру!");
        }

        if (password != confirmPassword)
        {
            throw new WrongPasswordException("Password и ConfirmPassword должны совпадать!");
        }
    }
}

