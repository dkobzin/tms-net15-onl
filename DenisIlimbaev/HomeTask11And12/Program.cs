using HomeTask11;
using System.Net.Http.Headers;

sealed class Work
{
    public static void Main()
    {
        var inventory = new Inventory<RefProduct>(
            new Food(1, new Product() { NameProduct = "Вода", Quantity = 1200, Price = 30}) { CategoryFood = CategoryFood.Drinks},
            new Cosmetics(2, new Product() { NameProduct = "Салфетки", Quantity = 100, Price = 90}){ CategoryCosm = CategoryCosm.Man}
         );
       

        UserInventory <RefProduct> program = new UserInventory<RefProduct>(inventory);
        ExecutionManager<RefProduct> manager = new ExecutionManager<RefProduct>(program);
        Food food = new Food(1, new Product() { NameProduct = "Вода", Quantity = 1200, Price = 30 }) { CategoryFood = CategoryFood.Drinks };
        Food food1 = new Food(1, new Product() { NameProduct = "Вод", Quantity = 120, Price = 0 }) { CategoryFood = CategoryFood.Drinks };
        Console.WriteLine(food.CompareTo(food1));
        while (true)
        {
            try
            {
                program.Start();
                if (inventory.OpovistatorEvent() == true)
                {
                    manager.inventory = program;
                }
                Console.WriteLine(manager.MinPrice());
                Console.WriteLine(manager.MaxPrice());
                Console.WriteLine(manager.MiddlePrice());

            }
            catch
            {
                Console.WriteLine("Error");
                break;
            }
        }

    }
}