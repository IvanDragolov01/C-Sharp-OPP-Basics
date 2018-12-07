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
		private Car _car;

		public Person(string name)
		{
			_name = name;
			_pokemons = new List<Pokemon>();
			_parents = new List<Parent>();
			_children = new List<Child>();
		}

		public Car Car
		{
			get { return _car; }
			set { _car = value; }
		}

		public List<Child> Children
		{
			get { return _children; }
			set { _children = value; }
		}

		public List<Parent> Parents
		{
			get { return _parents; }
			set { _parents = value; }
		}

		public List<Pokemon> Pokemons
		{
			get { return _pokemons; }
			set { _pokemons = value; }
		}

		public Company Company
		{
			get { return _company; }
			set { _company = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(Name)
				.AppendLine("Company:");

			if (this.Company != null)
			{
				sb.AppendLine(Company.ToString());
			}

			sb.AppendLine("Car:");

			if (Car != null)
			{
				sb.AppendLine(Car.ToString());
			}

			sb.AppendLine("Pokemon:");

			if (Pokemons.Count != 0)
			{
				foreach (Pokemon pokemon in Pokemons)
				{
					sb.AppendLine(pokemon.ToString());
				}
			}

			sb.AppendLine("Parents:");

			if (Parents.Count != 0)
			{
				foreach (Parent parent in Parents)
				{
					sb.AppendLine(parent.ToString());
				}
			}

			sb.AppendLine("Children:");

			if (Children.Count != 0)
			{
				foreach (Child child in Children)
				{
					sb.AppendLine(child.ToString());
				}
			}

			return sb.ToString().Trim();
		}
	}
}
