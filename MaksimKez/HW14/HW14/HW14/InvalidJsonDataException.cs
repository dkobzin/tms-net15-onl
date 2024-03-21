using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14
{
    internal class InvalidJsonDataException : Exception
    {
        public InvalidJsonDataException()
            : base() { }
        public InvalidJsonDataException(string message)
            : base(message) { }
    }
}
