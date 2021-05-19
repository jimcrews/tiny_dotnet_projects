using System;
using System.Collections.Generic;

namespace WorkingWithSerialization.lib
{
    public class Person
    {
        public Person(decimal initialSalary)
        {
            Salary = initialSalary;
        }

        // This constructor does not need to do anything, but it must exist so that the 
        // XmlSerializer can call it to instantiate new Person instances during the deserialization process.
        public Person() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public HashSet<Person> Children { get; set; }
        protected decimal Salary { get; set; }
    }
}