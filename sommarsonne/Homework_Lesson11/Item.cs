using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson11
{
    internal class Item
    {
        public string name = "Undefined";
        public int price;
        public int id;
        public int amount = 1;

        public void PrintItemInfo()
        {
            Console.WriteLine($"Наименование: {name} , Цена: {price} , Количество: {amount} , Идентификатор: {id}");
        }
    }
}
