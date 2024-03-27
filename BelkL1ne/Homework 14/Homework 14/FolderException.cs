using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{
    internal class FolderException : Exception
    {
        public FolderException(string message) : base(message) { }
    }
}
