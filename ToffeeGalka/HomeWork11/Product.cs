using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
   public abstract class Product
    {
        public int price, id, count;
        public Product(int id, int count, int price)
        {
            this.id = id;
            this.count = count;
            this.price = price;
        }        
    }
}
