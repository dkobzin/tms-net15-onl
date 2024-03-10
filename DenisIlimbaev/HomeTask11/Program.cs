using HomeTask11;
/*
 * 1. ДЗ - Взять ДЗ к занятию 7. - 10 мин.
a) Добавить к нему класс ExecutionManager, который будет проводить инвентаризацию продукции.
b) Добавить возможность проводить различные агрегирующие операции по получению суммы, максимальной  и минимальной цены, средней цены продукции.
 */
sealed class Work
{
    public static void Main()
    {
        Inventory<Product> inventory = new Inventory<Product>(
            new Product() { }, 
            new Product() { }
            );

        UserInventory <Product> program = new UserInventory<Product>(inventory);
        ExecutionManager<Product> manager = new ExecutionManager<Product>(program);

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