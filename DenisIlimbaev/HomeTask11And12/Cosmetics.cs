using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
    enum CategoryCosm
    {
        Man,
        Woman
    }
    internal class Cosmetics : RefProduct
    {
        internal CategoryCosm CategoryCosm { get; set; }
        
        internal Cosmetics(int specialTagForConsole, Product product) : base(product)
        {
            SpecialTagForConsole = specialTagForConsole;
        }  
        
    }
}
