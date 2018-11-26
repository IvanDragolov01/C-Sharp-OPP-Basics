using System;
using System.Linq;

namespace _02.CreatingConstructors
{
	public class Person
	{
		private string _name;
		private int _age;

		public Person()
			: this("No name", 1)
		{
		}

		public Person(int age)
			: this("No name", age)
		{
		}

		public Person(string _name, int _age)
		{
			this.Name = _name;
			this.Age = _age;
		}

		public int Age
		{
			get { return this._age; }
			set { this._age = value; }
		}

		public string Name
		{
			get { return this._name; }
			set { this._name = value; }
		}
	}
}
