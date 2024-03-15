using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask13
{
    internal class WrongPasswordExeption : Exception
    {
        internal WrongPasswordExeption(string ms) : base(ms) { }
        internal WrongPasswordExeption() { }
    }
}
