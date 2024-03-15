using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    internal class PersonHelper<T>(ICollection<T> persons)
        where T : Person
    {
        private ICollection<T> Persons { get; } = persons 
                                                       ?? throw new ArgumentNullException(nameof(persons));

        public T FindWithMaxAge(int maxAge)
        {
            return persons.FirstOrDefault(p => p.Age >= maxAge);
        }
    }
}
