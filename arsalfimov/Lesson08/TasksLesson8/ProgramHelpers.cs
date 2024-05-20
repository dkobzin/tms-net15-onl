using System.Text.RegularExpressions;

namespace TasksLesson8;
public static partial class ProgramHelpers
{
    private static readonly Regex NameRegex = new(@"[\d\W]");

    public static string AskForName()
    {
        string? name;

        do
        {
            Console.Write("Enter the animal's name: ");
            name = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                PrintErrorMessage("Name cannot be empty.");
                continue;
            }

            if (ContainsSpecialCharacters(name))
            {
                PrintErrorMessage("Name cannot contain digits or special characters.");
            }
        } while (string.IsNullOrWhiteSpace(name) || ContainsSpecialCharacters(name));

        return name;
    }

    private static void PrintErrorMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    private static bool ContainsSpecialCharacters(string name)
    {
        return NameRegex.IsMatch(name);
    }
}