using Homework_7;
using System.Collections.Generic;


internal class Program
{
    private static void Main(string[] args)
    {
        void DisplayMessage(string message) => Console.WriteLine(message);
        Inventory inventory = new Inventory();
        ExecutionManager executionManager = new ExecutionManager();
        executionManager.Notify += DisplayMessage;
        List<Product> products = new List<Product>();
        while (true)
        {
            Console.WriteLine("1 - Add product, 2 - Delete product by ID," +
            "3 - Display list of all products, 4 - Get sum of all products," +
            "5 - Get product with the highest price, 6 - Get product with the highest price," +
            "7 - Get average price of all products, 8 - Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    inventory.AddProduct(products);
                    break;
                case 2:
                    inventory.DeleteProduct(products);
                    break;
                case 3:
                    inventory.GetName(products);
                    break;
                case 4:
                    executionManager.GetSum(products);
                    break;
                case 5:
                    executionManager.GetMaxPrice(products);
                    break;
                case 6:
                    executionManager.GetMinPrice(products);
                    break;
                case 7:
                    executionManager.GetAveragePrice(products);
                    break;
                case 8:
                    Environment.Exit(0);
                    break;
                default: Console.WriteLine("Invalid input"); break;
            }
        }
    }
}