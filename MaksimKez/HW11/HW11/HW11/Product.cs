using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    internal abstract class Product
    {
        internal double TotalPrice { get; set; }
        internal string Name { get; init; }
        internal string ID { get; init; }
        public abstract override string ToString();
    }
    
}
