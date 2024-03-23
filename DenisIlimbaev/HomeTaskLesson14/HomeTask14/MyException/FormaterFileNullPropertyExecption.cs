using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask14.MyException
{
    internal class FormaterFileNullPropertyExecption : Exception
    {
        internal FormaterFileNullPropertyExecption(string nameNullValue) : base($"Value: {nameNullValue} was NULL ") { }
    }
}
