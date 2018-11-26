using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Opinion_Poll
{
	public class Person
	{
		private string _name;
		private int _age;

		public Person(string name, int age)
		{
			this._name = name;
			this._age = age;
		}

		public string Name
		{
			get { return _name; }
		}

		public int Age
		{
			get { return _age; }
		}
	}
}
