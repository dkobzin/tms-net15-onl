using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    internal interface IPricePerUnit
    {
        public int Quantity { get; set; }
        public double PricePerUnit { get; set; }
        public double CalculatePrice();
    }
}
