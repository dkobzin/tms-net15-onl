namespace HW13;

internal static class Program
{
	private static void Main()
	{
		var firstUser = new User("FirstUser", "password123", "password123");
		var loggedIn = Login(firstUser);
		Console.WriteLine(loggedIn + "\n");
		
		var secondUser = new User("User ", "password123", "password123");
		loggedIn = Login(secondUser);
		Console.WriteLine(loggedIn + "\n");
		
		var thirdUser = new User("User", "password1", "password123");
		loggedIn = Login(thirdUser);
		Console.WriteLine(loggedIn);
	}

	private static bool Login(User user)
	{
		try
		{
			User.ValidateLogin(user.Login);
			User.ValidatePassword(user.Password, user.ConfirmPassword);
			return true;
		}
		catch (WrongLoginException ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
		catch (WrongPasswordException ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}
}