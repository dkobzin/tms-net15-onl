using System;

public class Program
{
    public static bool Login(User user)
    {
        if (user.Login.Length >= 20 || user.Login.Contains(" "))
        {
            throw new WrongLoginException("Wrong login format.");
        }

        if (user.Password.Length >= 20 || user.Password.Contains(" ") || !ContainsDigit(user.Password))
        {
            throw new WrongPasswordException("Wrong password format.");
        }

        if (user.Password != user.ConfirmPassword)
        {
            throw new WrongPasswordException("Passwords do not match.");
        }

        return true;
    }

    private static bool ContainsDigit(string input)
    {
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }
}