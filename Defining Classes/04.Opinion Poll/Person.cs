using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Opinion_Poll
{
	public class Person
	{
		private string name;
		private int age;

		public Person(string name, int age)
		{
			this.name = name;
			this.age = age;
		}

		public string Name
		{
			get { return name; }
		}

		public int Age
		{
			get { return age; }
		}

	}
}
