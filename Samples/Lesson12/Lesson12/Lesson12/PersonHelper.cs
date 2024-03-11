using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    internal class PersonHelper<T>(ICollection<Person> persons)
        where T : ICollection<Person>
    {
        private ICollection<Person> Persons { get; } = persons 
                                                       ?? throw new ArgumentNullException(nameof(persons));
    }
}
