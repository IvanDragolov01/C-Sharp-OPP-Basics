	using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Family_Tree
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<Person> familyTree = new List<Person>();
			string mainpersonInput = Console.ReadLine();
			Person mainPerson = Person.CreatePerson(mainpersonInput);

			familyTree.Add(mainPerson);
			string command;

			while ((command = Console.ReadLine()) != "End")
			{
				string[] tokens = command.Split(" - ");

				if (tokens.Length > 1)
				{
					string firstPerson = tokens[0];
					string secondPesron = tokens[1];

					Person currentPerson = familyTree
						.FirstOrDefault(p => p.Birthday == firstPerson || p.FullName == firstPerson);

					if (currentPerson == null)
					{
						currentPerson = Person.CreatePerson(firstPerson);
						familyTree.Add(currentPerson);
					}

					SetChild(familyTree, currentPerson, secondPesron);
				}
				else
				{
					tokens = tokens[0].Split();
					string name = $"{tokens[0]} {tokens[1]}";
					string birthday = tokens[2];
					Person person = familyTree.FirstOrDefault(p => p.FullName == name || p.Birthday == birthday);

					if (person == null)
					{
						person = new Person();
						familyTree.Add(person);
					}

					person.FullName = name;
					person.Birthday = birthday;

					int index = familyTree.IndexOf(person) + 1;
					int count = familyTree.Count - index;

					Person[] copy = new Person[count];
					familyTree.CopyTo(index, copy, 0, count);

					Person copyPerson = copy.FirstOrDefault(p => p.FullName == name || p.Birthday == birthday);

					if (copyPerson != null)
					{
						familyTree.Remove(copyPerson);
						person.Parents.AddRange(copyPerson.Parents);
						person.Parents = person.Parents.Distinct().ToList();

						foreach (Person parent in copyPerson.Parents)
						{
							Person copyPerInd = parent;
							List<Person> copyPerInd2 = copyPerInd.Children;
							int copyPersonIndex = copyPerInd2.IndexOf(copyPerson);

							if (copyPersonIndex > -1)
							{
								parent.Children[copyPersonIndex] = person;
							}
							else
							{
								parent.Children.Add(person);
							}
						}

						List<Person> per = person.Children;
						per.AddRange(copyPerson.Children);
						List<Person> persAndChild = person.Children;
						IEnumerable<Person> persAndChild2 = persAndChild.Distinct();
						person.Children = persAndChild2.ToList();

						foreach (Person child in copyPerson.Children)
						{
							Person copyPerInd = child;
							List<Person> copyPerInd2 = copyPerInd.Parents;
							int copyPersonIndex = copyPerInd2.IndexOf(copyPerson);

							if (copyPersonIndex > -1)
							{
								child.Parents[copyPersonIndex] = person;
							}
							else
							{
								child.Parents.Add(person);
							}
						}
					}
				}
			}

			Console.WriteLine(mainPerson);
			Console.WriteLine("Parents:");
			List<Person> mainPer = mainPerson.Parents;

			foreach (Person p in mainPer)
			{
				Console.WriteLine(p);
			}

			Console.WriteLine("Children:");
			List<Person> mainPerAndChild = mainPerson.Children;

			foreach (Person c in mainPerAndChild)
			{
				Console.WriteLine(c);
			}
		}

		private static void SetChild(List<Person> familyTree, Person parent, string childInput)
		{
			Person child = familyTree.FirstOrDefault(c => c.FullName == childInput || c.Birthday == childInput);

			if (child == null)
			{
				child = Person.CreatePerson(childInput);
				familyTree.Add(child);
			}

			parent.Children.Add(child);
			child.Parents.Add(parent);
		}
	}
}
