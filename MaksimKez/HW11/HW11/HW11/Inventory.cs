using System;
using System.Collections.Generic;

namespace HW11
{
    internal class Inventory
    {
        public List<Product> Products { get; set; }
        public Inventory()
        {
            Products = new List<Product>(10);
            string choice = "";
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Сколько продуктов добавить? (потом можно будет добавить еще)");
                if (!int.TryParse(Console.ReadLine(), out int numOfProducts) || numOfProducts < 1) continue;
                for (int i = 0; i < numOfProducts; i++)
                {
                    while (true)
                    {
                        Console.WriteLine("Продукт надо взвесмить?(да/нет)");
                        choice = Console.ReadLine().ToLower();
                        if (string.IsNullOrEmpty(choice)) continue;
                        break;
                    }

                    if (choice == "да")
                    {
                        Products.Add(new ProductWeight());
                    }
                    else
                    {
                        Console.WriteLine();
                        Products.Append(new ProductUnit());
                        Console.WriteLine();
                    }
                }
                break;
            }
        }
        public void AddProducts()
        {
            string choice = "";
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Сколько продуктов добавить?");
                if (!int.TryParse(Console.ReadLine(), out int numOfProducts) || numOfProducts < 1) continue;
                for (int i = 0; i < numOfProducts; i++)
                {
                    while (true)
                    {
                        Console.WriteLine("Продукт надо взвесмить?(да/нет)");
                        choice = Console.ReadLine().ToLower();
                        if (string.IsNullOrEmpty(choice)) continue;
                        break;
                    }

                    if (choice == "да")
                    {
                        Products.Append(new ProductWeight());
                    }
                    else
                    {
                        Console.WriteLine();
                        Products.Append(new ProductUnit());
                        Console.WriteLine();
                    }
                }
                break;
            }
        }
        public void RemoveProduct()
        {
            Console.WriteLine();
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Введите ID продукта, чтобы его удалить");
                string IDtoDelete = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(IDtoDelete)) continue;
                foreach (Product product in Products)
                {
                    if (product.ID == IDtoDelete)
                    {
                        Console.WriteLine();
                        Products.Remove(product);
                        Console.WriteLine("Продукт успешно удален");
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine($"Продукт по ID {IDtoDelete} не найден");
                Console.WriteLine();
            }
        }
        public void Print()
        {
            foreach (Product p in Products)
            {
                Console.WriteLine(p.ToString());
                Console.WriteLine(p.TotalPrice);
            }
        }
        public double SumOfProsucts()
        {
            double sum = 0;
            foreach (var p in Products)
            {
                sum += p.TotalPrice;
            }
            return sum;
        }
    }
}
