using System;
using System.Collections.Generic;
using System.Text;

namespace _12.Google
{
	class Child
	{
		private string _name;
		private string _birthday;

		public Child(string _name, string birthday)
		{
			this.Name = _name;
			this.Birthday = birthday;
		}

		public string Birthday
		{
			get { return this._birthday; }
			set { this._birthday = value; }
		}

		public string Name
		{
			get { return this._name; }
			set { this._name = value; }
		}

		public override string ToString()
		{
			return $"{this.Name} {this.Birthday}";
		}
	}
}
