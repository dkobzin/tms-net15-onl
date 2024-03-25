using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZLesson11
{
    public class Store : Product
    {
        public string name;
        public Store(int id, int count, int price, string name) : base(id, count, price)
        {
            this.name = name;
        }
    }
}
