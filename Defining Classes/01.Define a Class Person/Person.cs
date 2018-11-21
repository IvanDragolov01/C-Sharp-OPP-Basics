
using System;

namespace DefiningClasses
{
	public class Person
	{
		private int age;
		private string name;

		private Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public string Name { get => name; set => name = value; }

		public int Age { get => age; set => age = value; }

		string fullNameAndAge;

		public Person()
		{
			fullNameAndAge = age + name;
		}

		public string PrintNameAndAge()
		{
			return $"{this.name} {this.age}";
		}
	}
}
