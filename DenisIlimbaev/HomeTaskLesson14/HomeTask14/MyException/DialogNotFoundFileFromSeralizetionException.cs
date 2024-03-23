using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask14.MyException
{
    internal class DialogNotFoundFileFromSeralizetionException : Exception
    {
        internal DialogNotFoundFileFromSeralizetionException() : base("files not found") { }
    }
}
