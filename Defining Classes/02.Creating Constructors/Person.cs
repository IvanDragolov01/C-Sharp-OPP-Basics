using System;

namespace DefiningClasses
{
	class Person
	{
		static void Main(string[] args)
		{
			StartUp nameAndAge1 = new StartUp();
			string[] information = Console.ReadLine().Split();
			nameAndAge1.Name = information[0];
			nameAndAge1.Age = int.Parse(information[1]);
			string result1 = nameAndAge1.PrintNameAndAge();

			Console.WriteLine(result1);

			string secondresult1 = nameAndAge1.ChangeFirstNameAndAge();
			string secondresult2 = nameAndAge1.ChangeSecondNameAndAge(nameAndAge1.Age);
			string secondresult3 = nameAndAge1.ChangeThirdNameAndAge(nameAndAge1.Name, nameAndAge1.Age);

			Console.WriteLine(secondresult1);
			Console.WriteLine(secondresult2);
			Console.WriteLine(secondresult3);
		}
	}
}
