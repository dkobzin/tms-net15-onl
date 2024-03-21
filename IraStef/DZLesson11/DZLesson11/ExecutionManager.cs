using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZLesson11
{
    public static class ExecutionManager
    {
        public static void SumStore(this Inventory executionManager)
        {
            int sumPrice = executionManager.listStore.Sum(i => i.price * i.count);
            Console.WriteLine($"Cost of all products in the store: {sumPrice} р. \n");
            int averagePrice = (int)executionManager.listStore.Average(i => i.price);
            Console.WriteLine($"Average cost of a product in a store: {averagePrice} р. \n");
            int minPrice = executionManager.listStore.Min(i => i.price);
            Console.WriteLine($"Minimum cost of a product in a store: {minPrice} р. \n");
            int maxPrice = executionManager.listStore.Max(i => i.price);
            Console.WriteLine($"Maximum cost of a product in a store: {maxPrice} р. \n");
        }
    }
}
