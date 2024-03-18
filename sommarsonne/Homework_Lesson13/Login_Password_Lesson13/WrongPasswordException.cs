﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Login_Password_Lesson13
{
    public class WrongPasswordException : Exception
    {
        public WrongPasswordException() : base()
        {
        }

        public WrongPasswordException(string message) : base(message)
        {
        }
    }
}