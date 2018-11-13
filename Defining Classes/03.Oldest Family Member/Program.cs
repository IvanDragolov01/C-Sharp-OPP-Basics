using System;
using System.Reflection;

namespace _03.Oldest_Family_Member
{
	class Program
	{
		static void Main(string[] args)
		{
			MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
			MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
			Family family = new Family();
			int membersNumber = int.Parse(Console.ReadLine());

			while (membersNumber > 0)
			{
				string[] personData = Console.ReadLine().Split();
				AddingPerson member = new AddingPerson(personData[0], int.Parse(personData[1]));
				family.AddMember(member);
				membersNumber--;
			}

			AddingPerson oldestMember = family.GetOldestMember();

			Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
		}
	}
}
