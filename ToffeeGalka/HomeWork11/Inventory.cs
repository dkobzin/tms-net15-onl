using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{     
    public class Inventory
    {
        public delegate void WriteLine(string mes);
        public event WriteLine? Notify;
       
        public List<Products> listProducts;
        public Inventory()
        {
            listProducts = new List<Products>();
        }
        public void Add(Products obj)
        {
            listProducts.Add(obj);
        }
        public void PrintProducts()
        {
            Console.WriteLine("List products:\n");
            listProducts.ForEach(x => Console.WriteLine($"{x.id} - {x.name}, count: {x.count}, price for 1: {x.price} р."));
        }

        public void AddProduct(WriteLine write)
        {
            write("Add ID product:");
            int id = int.Parse(Console.ReadLine());
            write("Add NAME product:");
            string name = Console.ReadLine();
            write("Add COUNT products:");
            int count = int.Parse(Console.ReadLine());
            write("Add PRICE product:");
            int price = int.Parse(Console.ReadLine());
            listProducts.Add(new Products(id, count, price, name));
        }
           
        public void RemoveProduct(WriteLine write)
        {
            write("Enter ID product:");
            int id = int.Parse(Console.ReadLine());
            if (listProducts.RemoveAll(p => p.id == id) > 0)
                Notify?.Invoke("Selected product removed");
            else
                Notify?.Invoke("There is no product with this id");
           
        }
    }
}
