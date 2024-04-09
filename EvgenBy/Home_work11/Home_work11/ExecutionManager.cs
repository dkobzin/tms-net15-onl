using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work11
{
    internal class ExecutionManager
    {
        public static void DoInventory(Inventory inventory)
        {
            Console.WriteLine("Performing inventory...");

            decimal totalValue = inventory.GetPrice();
            decimal maxPrice = inventory.GetMaxPrice();
            decimal minPrice = inventory.GetMinPrice();
            decimal avgPrice = inventory.GetAvgPrice();

            Console.WriteLine($"Total Inventory Value: {totalValue}");
            Console.WriteLine($"Maximum Price: {maxPrice}");
            Console.WriteLine($"Minimum Price: {minPrice}");
            Console.WriteLine($"Average Price: {avgPrice}");
        }
    }
}
