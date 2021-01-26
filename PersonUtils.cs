using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3
{
	class PersonUtils
    {
        private List<Person> personUtils;

        public PersonUtils()
        {
            personUtils = new List<Person>();
        }

        public Person[] GetPersons()
        {
            return personUtils.ToArray();
        }

        internal void AddPerson(string fName, string Lname, int age, int height, int weight)
        {
            personUtils.Add(new Person(fName, Lname, age, height, weight));
        }
    }
}
