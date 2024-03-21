using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZLesson14
{
    internal class JsonException: Exception
    {
        public JsonException()
            : base(){ }
        public JsonException(string message) 
            : base(message) { }

    }
}
