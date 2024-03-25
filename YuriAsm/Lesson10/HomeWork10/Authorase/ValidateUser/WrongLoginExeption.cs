using System;

namespace HomeWork10.Authorase.ValidateUser
{
    public class WrongLoginExeption : Exception
    {
        public WrongLoginExeption()
        {   
        }
        public WrongLoginExeption(string messege) : base(messege) { }
        
    }
}
