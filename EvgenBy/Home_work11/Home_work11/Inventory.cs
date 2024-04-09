using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work11
{
    internal class Inventory
    {
        private List<Product> products;

        public Inventory()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal GetPrice()
        {
            decimal price = 0;

            foreach (var product in products)
            {
                price += product.Price * product.Quantity;
            }
            return price;
        }

        public decimal GetMaxPrice()
        {
            if (products.Count == 0)
                return 0;

            return products.Max(p => p.Price);
        }

        public decimal GetMinPrice()
        {
            if (products.Count == 0)
                return 0;

            return products.Min(p => p.Price);
        }

        public decimal GetAvgPrice()
        {
            if (products.Count == 0)
                return 0;

            return products.Average(p => p.Price);
        }
    }
}
