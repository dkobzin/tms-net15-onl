using System;
namespace HomeWork13
{
    internal class WrongPasswordException : Exception
    {
        internal WrongPasswordException(string str) : base(str) { }
        internal WrongPasswordException() { }
    }
}
