using System;
using System.Collections.Generic;

namespace _10.ExcplicitInterfaces
{
	class StartUp
	{
		public static void Main()
		{
			List<Human> human = new List<Human>();
			string input = Console.ReadLine();

			while (input != "End")
			{
				string[] inputParts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				Human citizen = new Human(inputParts[0], inputParts[1], int.Parse(inputParts[2]));
				human.Add(citizen);
				input = Console.ReadLine();
			}

			foreach (Human humans in human)
			{
				IPerson person = humans;
				IResident resident = humans;
				person.GetName();
				resident.GetName();
			}
		}
	}
}
