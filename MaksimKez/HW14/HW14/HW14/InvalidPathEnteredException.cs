using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14
{
    internal class InvalidPathEnteredException : Exception
    {
        public InvalidPathEnteredException()
            : base() { }
        public InvalidPathEnteredException(string message) 
            : base(message) { }
    }
}
