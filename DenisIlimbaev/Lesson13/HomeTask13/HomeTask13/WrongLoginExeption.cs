using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask13
{
    internal class WrongLoginExeption : Exception
    {
        internal WrongLoginExeption(string ms) : base(ms) { }
        internal WrongLoginExeption() { }
    }

}

