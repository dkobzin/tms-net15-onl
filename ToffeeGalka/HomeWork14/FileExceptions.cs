using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    public class FileExceptions : Exception
    {
        public FileExceptions()
        {
        }
        public FileExceptions(string message) : base(message)
        {
        }
    }
}
