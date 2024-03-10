using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    internal interface IPricePerWeight
    {
        public double Weight { get; set; }
        public double PricePerKilo { get; set; }
        public double CalculatePrice();
    }
}
