using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddInterfaces
{
    internal class Person:ICloneable//IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        //public Company Work { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
           // Work = work;
        }
        public object Clone()
        {
          //  return new Person(Name,Age);
          return new Person(Name,Age);
        }


        //public int CompareTo(Person? person)
        //{
        //    if (person is null) throw 
        //            new ArgumentException("Ошибка");
        //    return Age-person.Age;
        //}
        //public int CompareTo(Person? obj)
        //{
        //    if (obj is Person person) 
        //        return Name.CompareTo(person.Name);
        //    else throw
        //            new ArgumentException("Некоректное значение");
        //}

    }
    
}
