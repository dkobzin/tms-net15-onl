using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11WinForm
{
    public delegate string DelegateMessage(string message);
    internal class DelegateClass
    {
        public string PrintMessage(int parameter, DelegateMessage callback)
        {
            return callback.Invoke($"Calling delegate {nameof(DelegateMessage)} with parameter {parameter} ");
        }
        
        public string AnotherPrintMessage(int parameter, DelegateMessage callback)
        {
            return callback.Invoke($"Calling another delegate {nameof(DelegateMessage)} with parameter {parameter} ");
        }
    }
}
