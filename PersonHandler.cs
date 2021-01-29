using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3
{
	public class PersonHandler
	{
		private List<Person> personList;

		public PersonHandler()
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

		public void SetAge(Person pers, int age)
		{
			pers.Age = age;
		}

		//public Person CreatePerson(int age, string fname,
		//	string lname, double height, double weight)
		//{

		//}


	}
}
