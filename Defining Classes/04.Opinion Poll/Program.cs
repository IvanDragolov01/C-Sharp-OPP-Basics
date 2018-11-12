using System;
using System.Reflection;

namespace _04.Opinion_Poll
{
	class Program
	{
		static void Main(string[] args)
		{
			MethodInfo GetAllАgesMoreThanMemberMethod = typeof(PrintingPersons).GetMethod("GetAllАgesMoreThanMember");
			MethodInfo addMemberMethod = typeof(PrintingPersons).GetMethod("AddMember");

			if (GetAllАgesMoreThanMemberMethod == null || addMemberMethod == null)
			{
				throw new Exception();
			}

			PrintingPersons family = new PrintingPersons();
			int membersNumber = int.Parse(Console.ReadLine());

			while (membersNumber > 0)
			{
				string[] personData = Console.ReadLine().Split();
				Person member = new Person(personData[0], int.Parse(personData[1]));
				family.AddMember(member);
				membersNumber--;
			}

			Person allwithagesmorethanthirty = family.GetAllАgesMoreThanMember();
			Console.WriteLine();
			Console.WriteLine($"{allwithagesmorethanthirty.Name} {allwithagesmorethanthirty.Age}");
		}
	}
}
