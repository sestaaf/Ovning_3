using System;
using System.Collections.Generic;

namespace Övning_3
{
	class Program
	{
		static PersonHandler personUtils = new PersonHandler();

		static void Main(string[] args)
		{
			try
			{
				//AddPersons();
				Person person1 = new Person();
				personUtils.SetAge(person1, 55);
				Console.WriteLine($"Person {person1.FName} ålder är {person1.Age}");

			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.WriteLine("\nTryck valfri tangent för att avsluta.");
			Console.ReadLine();
		}

		private static void AddPersons()
		{
			personUtils.AddPerson("Kajsa", "Anka", 120, 115, 40);
			personUtils.AddPerson("Kalle", "Anka", 120, 120, 45);
			personUtils.AddPerson("Janne", "Långben", 123, 190, 80);
			// Nedan testperson med alla 3 fel (stannar på första).
			// personUtils.AddPerson("", "", -1, 190, 80);
		}
	}
}
