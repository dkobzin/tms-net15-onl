namespace Lesson11;

public static class MenuHandler
{
    public static string ShowMainMenuAndGetChoice()
    {
        PrintMainMenu();

        Console.Write("Select an action: ");
        return Console.ReadLine();
    }

    private static void PrintMainMenu()
    {
        Console.WriteLine("\nSelection Menu:\n");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("1. Add a new product");
        Console.WriteLine("2. Delete a product by ID");
        Console.WriteLine("3. Display a list of all products");
        Console.WriteLine("4. Get the sum of all products");
        Console.WriteLine("5. Get the maximum product price");
        Console.WriteLine("6. Get the minimum product price");
        Console.WriteLine("7. Get the average price of the products");
        Console.ResetColor();

        string separator = new('-', 40);
        Console.WriteLine(separator);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("8. Save changes to a file");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("9. Exit the program\n");
        Console.ResetColor();
    }
}

