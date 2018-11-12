using System;

namespace _02.Creating_Constructors
{
	class Person
	{
		static void Main(string[] args)
		{
			StartUp nameAndAge1 = new StartUp();
			nameAndAge1.Name = "Pesho";
			nameAndAge1.Age = 20;
			StartUp nameAndAge2 = new StartUp();
			nameAndAge2.Name = "Gosho";
			nameAndAge2.Age = 18;
			StartUp nameAndAge3 = new StartUp();
			nameAndAge3.Name = "Stamat";
			nameAndAge3.Age = 43;

			string result1 = nameAndAge1.PrintNameAndAge();
			string result2 = nameAndAge2.PrintNameAndAge();
			string result3 = nameAndAge3.PrintNameAndAge();

			Console.WriteLine(result1);
			Console.WriteLine(result2);
			Console.WriteLine(result3);

			string secondresult1 = nameAndAge1.ChangeFirstNameAndAge();
			string secondresult2 = nameAndAge2.ChangeSecondNameAndAge(nameAndAge2.Age);
			string secondresult3 = nameAndAge3.ChangeThirdNameAndAge(nameAndAge3.Name, nameAndAge3.Age);

			Console.WriteLine(secondresult1);
			Console.WriteLine(secondresult2);
			Console.WriteLine(secondresult3);
		}
	}
}
