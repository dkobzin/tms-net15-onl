using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
     static public class ExecutionManager     
        { 
        static public void SumProducts(this Inventory inventory)
        {
            int sumPriceProducts = inventory.listProducts.Sum(p => p.price * p.count);
            Console.WriteLine($"Price all products: {sumPriceProducts} р. \n");

            int maxPriceProducts = inventory.listProducts.Max(p => p.price);
            Console.WriteLine($"Max price product: {maxPriceProducts} р.\n");

            int minPriceProducts = inventory.listProducts.Min(p => p.price);
            Console.WriteLine($"Min price product: {minPriceProducts} р.\n");

            double avrPriceProducts = inventory.listProducts.Average(p => p.price);
            Console.WriteLine($"Average price product: {avrPriceProducts} р.\n");
        }
    }
}
