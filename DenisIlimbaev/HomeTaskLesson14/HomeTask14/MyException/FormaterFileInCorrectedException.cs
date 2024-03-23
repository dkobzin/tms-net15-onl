using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask14.MyException
{
    internal class FormaterFileInCorrectedException : Exception
    {
        internal FormaterFileInCorrectedException() : base("This File is not JSON") { }
    }
}
