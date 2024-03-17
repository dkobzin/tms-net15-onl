using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Password_Lesson13
{
    public class WrongLoginException : Exception
    {
        public WrongLoginException() : base()
        {
        }

        public WrongLoginException(string message) : base(message)
        {
        }
    }
}