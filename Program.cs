using System;
using System.Collections.Generic;

namespace Övning_3
{
	class Program
	{
		static PersonUtils personUtils = new PersonUtils();


		static void Main(string[] args)
		{
			try
			{
				AddPersons();
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
			personUtils.AddPerson("", "Anka", 120, 115, 40);
			personUtils.AddPerson("Kalle", "Anka", 120, 120, 45);
			personUtils.AddPerson("Janne", "Långben", 123, 190, 80);
		}
	}
}
