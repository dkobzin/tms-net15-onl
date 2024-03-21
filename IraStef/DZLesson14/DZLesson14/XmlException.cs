using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZLesson14
{
    internal class XmlException:Exception
    {
        public XmlException()
            : base() { }
        public XmlException(string message)
            : base(message) { }

    }
}
