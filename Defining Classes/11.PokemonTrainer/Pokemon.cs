using System;
using System.Collections.Generic;
using System.Text;

namespace _11.PokemonTrainer
{
	class Pokemon
	{
		private string _name;
		private string _element;
		private int _health;

		public Pokemon(string name, string element, int health)
		{
			this._name = name;
			this._element = element;
			this._health = health;
		}

		public int Health { get { return this._health; } }

		public string Element { get { return this._element; } }

		public void ReduceHealth()
		{
			this._health -= 10;
		}
	}
}
