using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Opinion_Poll
{
	class StartUp
	{
		static void Main(string[] args)
		{
			HashSet<Person> people = GetPeople();
			PrintPeopleOlderThanthirthy(people);
		}

		private static void PrintPeopleOlderThanthirthy(HashSet<Person> people)
		{
			IEnumerable<string> peopleolderThanThirty = people
				.Where(p => p.Age > 30)
				.OrderBy(p => p.Name)
				.Select(p => $"{p.Name} - {p.Age}");

			string print = string.Join(Environment.NewLine, peopleolderThanThirty);
			Console.WriteLine(print);
		}

		private static HashSet<Person> GetPeople()
		{
			HashSet<Person> people = new HashSet<Person>();
			int numberOfPeople = int.Parse(Console.ReadLine());

			while (numberOfPeople > 0)
			{
				string[] personData = Console.ReadLine().Split();
				string name = personData[0];
				int age = int.Parse(personData[1]);
				people.Add(new Person(name,age));
				numberOfPeople--;
			}

			return people;
		}
	}
}