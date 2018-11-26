using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Oldest_Family_Member
{
	class AddingPerson
	{
		private string _name;
		private int _age;

		public AddingPerson(string _name, int _age)
		{
			this._name = _name;
			this._age = _age;
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public int Age
		{
			get { return _age; }
			set { _age = value; }
		}
	}
}
