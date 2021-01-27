using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3
{
	public class PersonHandler
	{
		private IEnumerable<Person> personList;

		public void SetAge(Person pers, int age)
		{
			foreach (Person p in personList)
			{
				Console.WriteLine($"{p.FName} {p.LName} has age {p.Age}.");
				Console.WriteLine("Do you want to change that? (Y/N)");
				string answer = System.Console.ReadLine();
				if (answer.ToUpper() == "Y")
				{
					Console.Write("Enter New Age: ");
					string newAnswer = Console.ReadLine();
					double newAge = double.Parse(newAnswer);
					p.Age = (int)newAge;
				}
				else if (answer.ToUpper() == "N")
				{
				}
			}
		}
	}
}
