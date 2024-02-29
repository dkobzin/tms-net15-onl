using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08
{
    internal abstract class Person
    {
        internal abstract string FirstName { get; set; }
        internal abstract string LastName { get; set; }
        internal abstract DateTime DateOfBirth { get; set; }

        internal abstract string GetInfo();

        protected Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
    }
}
