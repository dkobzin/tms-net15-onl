using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Password_Lesson13
{
    public class WrongLoginException : Exception
    {
        public WrongLoginException(string message) : base(message)
        {

        }

        public static bool CheckSpaces(string login)
        {
            return login.Contains(" ");
        }

        public static bool CheckLength(string login, int maxLength)
        {
            return login.Length > maxLength;
        }
    }
}
