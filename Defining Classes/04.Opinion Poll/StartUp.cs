using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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
			Console.WriteLine(string.Join(Environment.NewLine, people
				.Where(p => p.Age > 30)
				.OrderBy(p => p.Name)
				.Select(p => $"{p.Name} - {p.Age}")));
		}

		private static HashSet<Person> GetPeople()
		{
			HashSet<Person> people = new HashSet<Person>();
			int numberOfPeople = int.Parse(Console.ReadLine());

			while (numberOfPeople > 0)
			{
				string[] personData = Console.ReadLine().Split();
				people.Add(new Person(personData[0], int.Parse(personData[1])));
				numberOfPeople--;
			}

			return people;
		}
	}
}
