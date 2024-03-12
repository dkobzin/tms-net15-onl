using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson11
{
    public class Item
    {
        public string name { get; set; }
        public double price { get; set; }
        public int id { get; set; }

        public void PrintItemInfo()
        {
            Console.WriteLine($"Name: {name}, Price: {price}, ID: {id}");
        }
    }
}
