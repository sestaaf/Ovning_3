using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3
{
	public class Person
	{
		public Person()
		{
			// Console.WriteLine("Person instance created.");
		}
		public Person(string fName, string lName, int age, int height, int weight): this()
		{
			this.FName = fName;
			this.LName = lName;
			this.Age = age;
			this.Height = height;
			this.Weight = weight;

			Console.WriteLine($"Person: {FName} {LName}, age: {Age} has been instanced.");
		}

		private int age;
		public int Age 
		{	get
			{
				return age; 
			}
			set
			{
				if (value > 0) age = value;
				else
				{
					Console.WriteLine("\nNext Person in the list of adding people:");
					Console.WriteLine($"First Name {fName} has age {value}.");
					throw new ArgumentException("Age must be 1 or more, please fix and Rerun!");
				}
			}
		}
		private string fName;
		public string FName
		{
			get
			{
				return fName;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					Console.WriteLine("\nNext Person in the list of adding people:");
					Console.WriteLine($"First Name is missing.");
					throw new ArgumentException("First Name is obligatory, please fix and Rerun!");
				}
				else if (value.Length < 2 || value.Length > 10)
				{
					Console.WriteLine("\nNext Person in the list of adding people:");
					Console.WriteLine($"First Name {value} has length {value.Length} or is missing.");
					throw new ArgumentException("First Name length must be between 2 and 10, please fix and Rerun!");
				}
				else fName = value;
			}
		}

		private string lName;
		public string LName 
		{	get 
			{ 
				return lName; 
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					Console.WriteLine($"\nLast Name is missing.");
					throw new ArgumentException("Last Name is obligatory, please fix and Rerun!");
				}
				else if (value.Length < 3 || value.Length > 15)
				{
					Console.WriteLine($"\nFirst Name {fName} has Last Name length {value.Length}.");
					throw new ArgumentException("Last Name length must be between 3 and 15, please fix and Rerun!");
				}
				else lName = value;
			}
		}
	
		public int Height { get; set; }
		
		public int Weight { get; set; }


		public string SayHello()
		{
			return $"Hello {FName} {LName}, Age: {Age}, Height: {Height}, Weight: {Weight}.";
		}

	}
}
