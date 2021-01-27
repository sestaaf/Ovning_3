using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3
{
	class PersonUtils
    {
        private List<Person> personList;

        public PersonUtils()
        {
            personList = new List<Person>();
        }

        public Person[] GetPersons()
        {
            return personList.ToArray();
        }

        internal void AddPerson(string fName, string Lname, int age, int height, int weight)
        {
            personList.Add(new Person(fName, Lname, age, height, weight));
        }
    }
}
