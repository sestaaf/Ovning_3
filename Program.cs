using System;
using System.Collections.Generic;

namespace Övning_3
{
	class Program
	{
		static PersonUtils personUtils = new PersonUtils();


		static void Main(string[] args)
		{
			SeedData();

		}
		private static void SeedData()
		{
			personUtils.AddPerson("Sven-Erik", "Staaf", 62, 181, 101);
			personUtils.AddPerson("Kalle", "Anka", 120, 120, 45);
			personUtils.AddPerson("Janne", "Långben", 123, 190, 80);
		}
	}
}
