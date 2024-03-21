using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    internal class Product(string name, int price, int productId, int amount)
    {
        public int Price { get; set; } = price;
        public int ProductId { get; set; } = productId;
        public int Amount { get; set; } = amount;
        public string Name { get; set; } = name;
    }
}
