using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3
{
	public class Person
	{
		public Person()
		{
			Console.WriteLine("Person instance created.");
		}
		public Person(string fName, string lName, int age, int height, int weight): this()
		{
			this.FName = fName;
			this.LName = lName;
			this.Age = age;
			this.Height = height;
			this.Weight = weight;

			Console.WriteLine($"Person instance has a name: {FName} {LName}.");
		}


		public int Age { get; set; }

		public string FName { get; set; }

		public string LName { get; set; }
	
		public int Height { get; set; }
		
		public int Weight { get; set; }


		
		public string SayHello()
		{
			return $"Hello {FName} {LName}, Age: {Age}, Height: {Height}, Weight: {Weight}.";
		}

	}
}
