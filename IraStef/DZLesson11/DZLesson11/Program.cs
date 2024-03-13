using System.Diagnostics;
using System.Xml.Linq;

namespace DZLesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory(() => { Console.WriteLine("Product has been removed"); });
            inventory.Add(new Store(1, 10, 50, "Pineapple"));
            inventory.Add(new Store(2, 35, 15, "Profiteroles"));
            inventory.Add(new Store(3, 50, 7, "Celery"));
            inventory.Add(new Store(4, 13, 6, "Teraflu"));
            inventory.Add(new Store(5, 22, 3, "Patch"));
            inventory.Add(new Store(6, 10, 2, "Thermometer"));
            inventory.Add(new Store(7, 2, 1500, "Vacuum cleaner"));
            inventory.Add(new Store(8, 5, 1000, "Blender"));
            inventory.Add(new Store(9, 4, 500, "Headphones"));
            while (true)
            {

                while (true)
                {
                    Console.WriteLine("Select an action by pressing the number from 1 to 4: \n" +
                        "1 - List all products \n" +
                        "2 - Derive aggregation operations \n" +
                        "3 - Add products \n" +
                        "4 - Delete products \n");
                    string action = Console.ReadLine();

                    switch (action)
                    {
                        case "1":
                            inventory.PrintStore();
                            
                            break;

                        case "2":
                            inventory.SumStore();                        
                            break;

                        case "3":
                            inventory.AddProduct(() =>
                            {
                                Console.WriteLine("Enter id:");
                                int id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter name:");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter quantity:");
                                int count = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter price:");
                                int price = int.Parse(Console.ReadLine());
                                return new Store(id, count, price, name);

                            });
                            break;

                        case "4":
                            inventory.RemoveProduct();                            
                            break;

                        default:
                            Console.WriteLine("You have chosen an unknown action");
                            break;
                    }


                    Console.WriteLine("Enter e, to leave the program");
                    string enteredText = Console.ReadLine();
                    switch (enteredText)
                    {
                        case "e":
                            Console.WriteLine("EXIT");
                            return;

                        default:
                            Console.WriteLine("CONTINUE");
                            break;
                    }
                }
            }

        }
    }
}
