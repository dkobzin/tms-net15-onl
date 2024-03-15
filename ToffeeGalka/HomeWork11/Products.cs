using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class Products : Product
    {
        public string name;
        public Products(int id, int count, int price, string name) : base(id, count, price)
        {
            this.name = name;
        }
    }
}
