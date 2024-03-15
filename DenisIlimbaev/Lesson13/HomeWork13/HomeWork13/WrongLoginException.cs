using System;
namespace HomeWork13
{
    internal class WrongLoginException : Exception
    {
        internal WrongLoginException(string str) : base(str) { }
        internal WrongLoginException() { }

    }
}
