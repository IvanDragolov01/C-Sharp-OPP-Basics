using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.FamilyTree
{
	class Program
	{
		static void Main(string[] args)
		{
			var familyTree = new List<Person>();
			string personInput = Console.ReadLine();
			Person mainPerson = new Person();

			if (IsBirthday(personInput))
			{
				mainPerson.Birthday = personInput;
			}
			else
			{
				mainPerson.FullName = personInput;
			}

			string command = Console.ReadLine();

			while (command != "End")
			{
				string[] tokens = command.Split("-");

				if (tokens.Length > 1)
				{
					string firstPerson = tokens[0];
					string secondPesron = tokens[1];

					Person currentPerson;

					if (IsBirthday(firstPerson))
					{
						currentPerson = familyTree.FirstOrDefault(p => p.Birthday == firstPerson);

						if (currentPerson == null)
						{
							currentPerson = new Person();
							currentPerson.Birthday = firstPerson;
							familyTree.Add(currentPerson);
						}

						SetChild(familyTree, currentPerson, secondPesron);
					}
					else
					{
						currentPerson = familyTree.FirstOrDefault(p => p.FullName == firstPerson);

						if (currentPerson == null)
						{
							currentPerson = new Person();
							currentPerson.FullName = firstPerson;
							familyTree.Add(currentPerson);
						}

						SetChild(familyTree, currentPerson, secondPesron);
					}
				}

				else
				{
					tokens = tokens[0].Split(" ");
				}

				command = Console.ReadLine();
			}
		}

		private static void SetChild(List<Person> familyTree, Person parentPerson, string child)
		{
			Person childPerson = new Person();

			if (IsBirthday(child))
			{
				if (!familyTree.Any(p => p.Birthday == child))
				{
					childPerson.Birthday = child;
				}
				else
				{
					childPerson = familyTree.First(p => p.Birthday == child);
				}
			}
			else
			{
				if (!familyTree.Any(p => p.FullName == child))
				{
					childPerson.FullName = child;
				}
				else
				{
					childPerson = familyTree.First(p => p.FullName == child);
				}
			}

			parentPerson.Children.Add(childPerson);
			familyTree.Add(childPerson);
		}

		static bool IsBirthday(string input)
		{
			return Char.IsDigit(input[0]);
		}
	}
}
