using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Oldest_Family_Member
{
	class Family
	{
		static void Main(string[] args)
		{
			int numberofperson = int.Parse(Console.ReadLine());
			NameAndAge person = new NameAndAge();

			for (int i = 0; i < numberofperson; i++)
			{
				person.Name = Console.ReadLine();
				person.Age = int.Parse(Console.ReadLine());
				
			}

			string getOldesetMember = person.GetOldestMemberOfFamily(person.Name,person.Age);
			Console.WriteLine(getOldesetMember);
		}
	}
}
