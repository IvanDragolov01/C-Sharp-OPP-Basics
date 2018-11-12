using System;

namespace _01.Define_a_Class_Person
{
	public class Person
	{
		int age;
		string name;

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
