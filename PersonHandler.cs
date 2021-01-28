using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3
{
	public class PersonHandler
	{
		private readonly IEnumerable<Person> personList;

		public PersonHandler(IEnumerable<Person> personList)
		{
			this.personList = personList;
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
