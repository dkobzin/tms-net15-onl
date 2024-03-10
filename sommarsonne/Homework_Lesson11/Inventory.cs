using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson11
{
    public class Inventory
    {
        private List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine();
            Console.WriteLine("Товар добавлен в инвентарь.");
        }

        public int CountItems()
        {
            return items.Count;
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (Item item in items)
            {
                totalPrice += item.price;
            }
            return totalPrice;
        }

        public void DisplayInventory()
        {
            foreach (Item item in items)
            {
                Console.WriteLine($"Наименование: {item.name}, Цена: {item.price}");
            }
            Console.WriteLine($"Общее количество товаров: {CountItems()}, Общая цена: {CalculateTotalPrice()}.");
        }
    }
}
