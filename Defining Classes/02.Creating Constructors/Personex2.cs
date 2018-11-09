using System;

public class Personex2
{
	static void Main(string[] args)
	{
		NameAndAge nameAndAge1 = new NameAndAge();
		nameAndAge1.Name = "Pesho";
		nameAndAge1.Age = 20;
		NameAndAge nameAndAge2 = new NameAndAge();
		nameAndAge2.Name = "Gosho";
		nameAndAge2.Age = 18;
		NameAndAge nameAndAge3 = new NameAndAge();
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
		string secondresult3 = nameAndAge3.ChangeThirdNameAndAge(nameAndAge3.Name,nameAndAge3.Age);

		Console.WriteLine(secondresult1);
		Console.WriteLine(secondresult2);
		Console.WriteLine(secondresult3);
		Console.ReadKey();
	}
}

