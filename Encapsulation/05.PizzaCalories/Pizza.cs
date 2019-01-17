using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PizzaCalories
{
	public class Pizza
	{
		private const int MinLength = 1;
		private const int MaxLength = 15;
		private const int MinTopping = 0;
		private const int MaxTopping = 10;
		private string _name;

		public Pizza()
		{
			Toppings = new List<Topping>();
		}

		public Pizza(string name)
			: this()
		{
			Name = name;
		}

		private double ToppingsCalories
		{
			get
			{
				if (Toppings.Count == 0)
				{
					return 0;
				}

				return Toppings.Select(t => t.Calories).Sum();
			}
		}

		private double Calories => Dough.Calories + ToppingsCalories;

		private string Name
		{
			get
			{
				return _name;
			}
			set
			{
				bool valueNull = string.IsNullOrEmpty(value);
				bool valueLength = value.Length > MaxLength;

				if (valueNull || valueLength)
				{
					throw new ArgumentException($"Pizza name should be between {MinLength} and {MaxLength} symbols.");
				}

				_name = value;
			}
		}

		private Dough Dough
		{
			get;
			set;
		}
		private List<Topping> Toppings
		{
			get;
			set;
		}

		public void SetDough(Dough dough)
		{
			Dough = dough;
		}

		public void AddToping(Topping topping)
		{
			Toppings.Add(topping);
			int toppingscount = Toppings.Count;

			if (toppingscount > MaxTopping)
			{
				throw new ArgumentException($"Number of toppings should be in range [{MinTopping}..{MaxTopping}].");
			}
		}

		public override string ToString()
		{
			return $"{Name} - {Calories:f2} Calories.";
		}
	}
}
