using System;

namespace _03.AnimalFarms
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());
			Chicken chicken = new Chicken(name, age);

			if (chicken.Name == " ")
			{
				Console.WriteLine("Name cannot be empty.");
				return;
			}

			if (chicken.ProductPerDay == 0.75)
			{
				Console.WriteLine("Age should be between 0 and 15.");
				return;
			}

			string chickName = chicken.Name;
			int chickAge = chicken.Age;
			double chickProductPerDay = chicken.ProductPerDay;
			Console.WriteLine(
				"Chicken {0} (age {1}) can produce {2} eggs per day.",
				chickName,
				chickAge,
				chickProductPerDay);
		}
	}
}
