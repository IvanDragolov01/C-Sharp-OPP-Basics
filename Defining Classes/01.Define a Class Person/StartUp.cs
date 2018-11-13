using DefiningClasses;
using System;

namespace DefiningClasses
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			Person nameAndAge1 = new Person();
			nameAndAge1.Name = "Pesho";
			nameAndAge1.Age = 20;
			Person nameAndAge2 = new Person();
			nameAndAge2.Name = "Gosho";
			nameAndAge2.Age = 18;
			Person nameAndAge3 = new Person();
			nameAndAge3.Name = "Stamat";
			nameAndAge3.Age = 43;

			string result1 = nameAndAge1.PrintNameAndAge();
			string result2 = nameAndAge2.PrintNameAndAge();
			string result3 = nameAndAge3.PrintNameAndAge();

			Console.WriteLine(result1);
			Console.WriteLine(result2);
			Console.WriteLine(result3);
		}
	}
}