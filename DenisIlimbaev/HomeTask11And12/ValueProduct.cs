using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
    internal struct ValueProduct
    {
        internal uint Quantity { get; set; }
        internal double Price { get; set; }
        internal string? NameProduct { get; set; }
        internal string? Identity { get; init; }
        public ValueProduct()
        {
            const int MaxValueIDCode = 10;
            foreach (int i in Enumerable.Range(0, MaxValueIDCode)) Identity += new Random().Next(0, 9).ToString();
        }
        public static implicit operator RefProduct(ValueProduct val)
        {
            RefProduct obj = new RefProduct(val.Quantity,
                val.Price,
                val.NameProduct ?? throw new NullReferenceException(),
                val.Identity ?? throw new NullReferenceException()
                );
            return obj;
        }

    }
}
