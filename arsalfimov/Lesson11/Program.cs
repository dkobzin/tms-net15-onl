using static Lesson11.ProductHandler;
namespace Lesson11;


public static class Program
{
    static void Main()
    {
        Inventory inventory = new();

        InitialDataLoader dataLoader = new("inventory.json");
        dataLoader.LoadInitialData(inventory);

        bool exit = false;

        while (!exit)
        {
            string choice = MenuHandler.ShowMainMenuAndGetChoice();

            switch (choice)
            {
                case "1":
                    AddProduct(inventory);
                    break;
                case "2":
                    RemoveProduct(inventory);
                    break;
                case "3":
                    PrintAllProducts(inventory);
                    break;
                case "4":
                    PrintTotalValue(inventory);
                    break;
                case "5":
                    PrintMaxPrice(inventory);
                    break;
                case "6":
                    PrintMinPrice(inventory);
                    break;
                case "7":
                    PrintAveragePrice(inventory);
                    break;
                case "8":
                    inventory.SaveToFile("inventory.json");
                    Console.WriteLine("The inventory is saved to a file.");
                    break;
                case "9":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Wrong choice. Try again.");
                    break;
            }
        }
    }
}