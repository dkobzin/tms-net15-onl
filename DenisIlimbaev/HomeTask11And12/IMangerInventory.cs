using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
    internal interface IMangerInventory
    {
        public double MaxPrice();
        public double MinPrice();
        public double MiddlePrice();
    }
}
