using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PokemonTrainer
{
	class Trainer
	{
		private string _name;
		private int _badges;
		private Stack<Pokemon> _pokemons;

		public Trainer(string name)
		{
			this.Name = name;
			this._badges = 0;
			this._pokemons = new Stack<Pokemon>();
		}

		public Stack<Pokemon> Pokemons { get { return this._pokemons; } }

		public string Name
		{
			get
			{
				return this._name;
			}

			private set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Name can not be empty.");
				}

				this._name = value;
			}
		}

		public int Badges { get { return this._badges; } }

		public void AddABadge()
		{
			this._badges++;
		}

		internal void ClearDeadPokemons()
		{
			if (this._pokemons.Count > 0 && this._pokemons.Where(p => p.Health <= 0).FirstOrDefault() != null)
			{
				this._pokemons = new Stack<Pokemon>(this._pokemons.Where(p => p.Health > 0));
			}
		}
	}
}
