using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
    enum CategoryFood
    {
        Dairy,
        Meat,
        FastFood,
        Drinks
    }
    enum Package
    {
        Carton,
        Paper,
        Bottle,
        Metal
    }
    internal class Food : RefProduct
    {
        internal CategoryFood CategoryFood { get; set; }
        internal Package Package { get; set; }
        internal Food(int specialTagForConsole, Product product) : base(product)
        {
            SpecialTagForConsole = specialTagForConsole;
        }
    }
}
