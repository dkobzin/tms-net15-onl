using System.Collections.Generic;

namespace HW11
{
    internal class Inventory
    {
        public List<Product> Products { get; set; }
        public Inventory()
        {
            Products = new List<Product>();
            string choice = "";
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("How many products do u want to add? (later you can do it again)");
                if (!int.TryParse(Console.ReadLine(), out int numOfProducts) || numOfProducts < 1) continue;
                for (int i = 0; i < numOfProducts; i++)
                {
                    while (true)
                    {
                        Console.WriteLine("Does the product need to be weighed? (yes/no)");
                        choice = Console.ReadLine().ToLower();
                        if (string.IsNullOrEmpty(choice)) continue;
                        break;
                    }

                    if (choice.ToLower() == "yes" || choice.ToLower() == "да")
                    {
                        Products.Add(new ProductWeight());
                    }
                    else
                    {
                        Console.WriteLine();
                        Products.Add(new ProductUnit());
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
                Console.WriteLine("How many products should I add?");
                if (!int.TryParse(Console.ReadLine(), out int numOfProducts) || numOfProducts < 1) continue;
                for (int i = 0; i < numOfProducts; i++)
                {
                    while (true)
                    {
                        Console.WriteLine("Does the product need to be weighed? (yes/no)");
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
                        Products.Add(new ProductUnit());
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
                Console.WriteLine("Enter the product ID to remove it");
                string IDtoDelete = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(IDtoDelete)) continue;
                foreach (Product product in Products)
                {
                    if (product.ID == IDtoDelete)
                    {
                        Console.WriteLine();
                        Products.Remove(product);
                        Console.WriteLine("Product removed successfully");
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine($"Product ID {IDtoDelete} not found");
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
