using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    internal class Inventory ()
    {
        public void GetName(List<Product> products)
        {
            foreach (var productNames in products)
            {
                Console.WriteLine(productNames.Name);
            }
        }
        public void DeleteProduct(List<Product> products)
        {
            Console.WriteLine("Введите id позции, которую хотите удалить.");
            int positionId = Convert.ToInt32(Console.ReadLine()) + 1;
            products.RemoveAt(positionId);
        }
        public void AddProduct (List<Product> products)
        {
            int productId = 1;

            Console.WriteLine("Введите название, цену и количество продукта");
            string? name = Console.ReadLine();
            int price = Convert.ToInt32(Console.ReadLine());
            int amount = Convert.ToInt32(Console.ReadLine());

            Product product = new Product(name, price, productId++, amount);
            products.Add(product);
        }
    }
}
