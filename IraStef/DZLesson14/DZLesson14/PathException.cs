using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZLesson14
{
    internal class PathException: Exception
    {
        public PathException() 
            :base() {}
        public PathException (string massage)
            :base(massage) { }
    }
}
