using System;
using System.Collections.Generic;
using System.Text;

namespace _12.Google
{
	class Pokemon
	{
		private string _name;
		private string _type;

		public Pokemon(string name, string type)
		{
			this.Name = name;
			this.Type = type;
		}

		public string Type
		{
			get { return this._type; }
			set { this._type = value; }
		}

		public string Name
		{
			get { return this._name; }
			set { this._name = value; }
		}

		public override string ToString()
		{
			return $"{this.Name} {this.Type}";
		}
	}
}
