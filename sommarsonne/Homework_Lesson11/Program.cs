namespace Homework_Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ItemCatalog catalog = new ItemCatalog();
            Inventory inventory = new Inventory();
            ExecutionManager executionManager = new ExecutionManager(catalog);
            
            
            Console.WriteLine($"Информация о товарах:");
            Console.WriteLine();
            catalog.watermelon.PrintItemInfo();
            catalog.apple.PrintItemInfo();
            catalog.banana.PrintItemInfo();


           while (true)
            {
                Console.WriteLine();

                Console.WriteLine("1. Добавить товар в инвентарь");
                Console.WriteLine("2. Посмотреть инвентарь");
                Console.WriteLine("3. Агрегирующие операции");
                Console.WriteLine("4. Выйти");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();
                
               

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите название товара: ");
                        string name = Console.ReadLine();
                        if (name.ToLower() == "яблоко")
                        {
                            inventory.AddItem(catalog.apple);
                        }

                        else if (name.ToLower() == "арбуз")
                        {
                            inventory.AddItem(catalog.watermelon);
                        }

                        else if (name.ToLower() == "банан")
                        {
                            inventory.AddItem(catalog.banana);
                        }

                        else
                        {
                            Console.WriteLine("Неверное значение. Попробуйте снова.");
                        }
                        break;

                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("Инвентарь:");
                        inventory.DisplayInventory();
                        break;

                    case "3":
                        executionManager.Start();
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Неверное значение. Попробуйте снова..");
                        break;
                }
            }
        }
    }
}
