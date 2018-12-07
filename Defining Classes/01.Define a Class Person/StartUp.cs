using System;

namespace DefiningClasses
{
	class StartUp
	{
		static void Main(string[] args)
		{
			Person nameAndAge1 = new Person("Pesho", 20);
			Person nameAndAge2 = new Person("Pesho", 18);
			Person nameAndAge3 = new Person("Pesho", 15);

			Console.WriteLine(nameAndAge1.FullName);
			Console.WriteLine(nameAndAge2.FullName);
			Console.WriteLine(nameAndAge3.FullName);
		}
	}
}