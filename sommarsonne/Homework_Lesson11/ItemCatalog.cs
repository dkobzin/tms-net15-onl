using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson11
{
    public class ItemCatalog
    {
        public Item apple { get; set; }
        public Item watermelon { get; set; }
        public Item banana { get; set; }

        //printItemName??

        public ItemCatalog()
        {
            apple = new Item
            {
                name = "Яблоко",
                price = 2,
                id = 1
            };

            watermelon = new Item
            {
                name = "Арбуз",
                price = 10,
                id = 2
            };

            banana = new Item
            {
                name = "Банан",
                price = 5,
                id = 3
            };
        }
    }
}
