
using System;

namespace DefiningClasses
{
	public class Person
	{
		private int _age;
		private string _name;

		private Person(string _name, int _age)
		{
			Name = _name;
			Age = _age;
		}

		public string Name { get => _name; set => _name = value; }

		public int Age { get => _age; set => _age = value; }

		string fullNameAndAge;

		public Person()
		{
			fullNameAndAge = _age + _name;
		}

		public string PrintNameAndAge()
		{
			return $"{this._name} {this._age}";
		}
	}
}
