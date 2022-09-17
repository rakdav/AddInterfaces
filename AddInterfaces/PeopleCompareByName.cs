using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddInterfaces
{
    internal class PeopleCompareByName : IComparer<Person>
    {
        public int Compare(Person? person1, Person? person2)
        {
            if (person1 is null || person2 is null)
                throw new ArgumentException("Error");
            return person1.Name.Length - person2.Name.Length;
        }
    }
}
