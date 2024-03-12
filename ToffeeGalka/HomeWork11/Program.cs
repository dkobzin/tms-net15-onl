using HomeWork11;

internal class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
      
        inventory.Add(new Products(1, 2, 500, "яблоко"));
        inventory.Add(new Products(2, 4, 750, "груша"));
        inventory.Add(new Products(3, 10, 220, "киви"));
       
        while (true)
        {
            int menu;
            while (true)
            {
                Console.WriteLine("Select a menu item: \n" +
                    "1 - List all products \n" +
                    "2 - Aggregation operations \n" +
                    "3 - Add product \n" +
                    "4 - Delete product \n");
                if (int.TryParse(Console.ReadLine(), out menu))
                {
                    if (menu != 1 & menu != 2 & menu != 3 & menu != 4)
                    {
                        Console.WriteLine("Select a menu item from 1 to 4!");
                        continue;
                    }
                    break;
                }
                continue;
            }

            if (menu == 1)
            {
                inventory.PrintProducts();
            }
            if (menu == 2)
            {
                inventory.SumProducts();
            }
            if (menu == 3)
            {
                inventory.AddProduct(mes => {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(mes);
                    Console.ForegroundColor = ConsoleColor.White;
                });
            }
            if (menu == 4)
            {
                inventory.RemoveProduct(mes => {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(mes);
                    Console.ForegroundColor = ConsoleColor.White;
                    inventory.Notify += Console.WriteLine;
                });
                inventory.Notify -= Console.WriteLine;
            }
            Console.WriteLine("\n CONTINUE? Y:");
            if (char.TryParse(Console.ReadLine(), out char cancel))
            {
                if (cancel != 'Y')
                {
                    break;
                }
                continue;
            }

        }

    }

    private static void Inventory_Notify(string mes)
    {
        throw new NotImplementedException();
    }
}