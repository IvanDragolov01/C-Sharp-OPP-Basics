﻿using System;
using System.Linq;

namespace _02.CreatingConstructors
{
	public class Person
	{
		private string _name;
		private int _age;

		public Person() : this("No name", 1)
		{

		}

		public Person(int age) : this("No name", age)
		{

		}

		public Person(string name, int age)
		{
			_name = name;
			_age = age;
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
