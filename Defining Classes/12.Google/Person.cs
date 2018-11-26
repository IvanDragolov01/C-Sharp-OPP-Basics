using System;
using System.Collections.Generic;
using System.Text;

namespace _12.Google
{
	class Person
	{
		private string _name;
		private Company _company;
		private List<Pokemon> _pokemons;
		private List<Parent> _parents;
		private List<Child> _children;
		private Car car;

		public Person(string name)
		{
			this.Name = name;
			this.Pokemons = new List<Pokemon>();
			this.Parents = new List<Parent>();
			this.Children = new List<Child>();
		}

		public Car Car
		{
			get { return this.car; }
			set { this.car = value; }
		}

		public List<Child> Children
		{
			get { return this._children; }
			set { this._children = value; }
		}

		public List<Parent> Parents
		{
			get { return this._parents; }
			set { this._parents = value; }
		}

		public List<Pokemon> Pokemons
		{
			get { return this._pokemons; }
			set { this._pokemons = value; }
		}

		public Company Company
		{
			get { return this._company; }
			set { this._company = value; }
		}

		public string Name
		{
			get { return this._name; }
			set { this._name = value; }
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(this.Name)
				.AppendLine("Company:");

			if (this.Company != null)
			{
				sb.AppendLine(this.Company.ToString());
			}

			sb.AppendLine("Car:");

			if (this.Car != null)
			{
				sb.AppendLine(this.Car.ToString());
			}

			sb.AppendLine("Pokemon:");

			if (this.Pokemons.Count != 0)
			{
				foreach (Pokemon pokemon in this.Pokemons)
				{
					sb.AppendLine(pokemon.ToString());
				}
			}

			sb.AppendLine("Parents:");

			if (this.Parents.Count != 0)
			{
				foreach (Parent parent in this.Parents)
				{
					sb.AppendLine(parent.ToString());
				}
			}

			sb.AppendLine("Children:");

			if (this.Children.Count != 0)
			{
				foreach (Child child in this.Children)
				{
					sb.AppendLine(child.ToString());
				}
			}

			return sb.ToString().Trim();
		}
	}
}
