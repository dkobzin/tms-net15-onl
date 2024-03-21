using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{

    internal class ExecutionManager
    {
        public delegate void ExecutionManagerHandler(string message);
        public event ExecutionManagerHandler? Notify;
        public void GetSum(List<Product> products)
        {
            int sum = 0;
            foreach (var product in products)
            {
                sum = +product.Price * product.Amount;
            }
            Notify?.Invoke($"Sum of all products: {sum}");
        }
        public void GetMaxPrice(List<Product> products) 
        {
            int maxPrice = 0;
            foreach (var product in products)
            {
                if (product.Price > maxPrice)
                    maxPrice = product.Price;
            }
            Notify?.Invoke($"Product with the highest price: {maxPrice}");
        }
        public void GetMinPrice(List<Product> products)
        {
            int minPrice = products[0].Price;
            foreach (var product in products)
            {
                if (product.Price < minPrice)
                    minPrice = product.Price;
            }
            Notify?.Invoke($"Product with the lowest price: {minPrice}");
        }
        public void GetAveragePrice(List<Product> products)
        {
            int sum = 0;
            int amount = 0;
            foreach (var product in products)
            {
                sum = +product.Price * product.Amount;
                amount =+ product.Amount;
            }
            Notify?.Invoke($"Average price of products: {sum / amount}");
        }
    }
}
