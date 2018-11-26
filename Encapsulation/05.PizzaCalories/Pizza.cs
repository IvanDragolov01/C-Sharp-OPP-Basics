using System;
using System.Collections.Generic;
using System.Text;

namespace _05.PizzaCalories
{
	public class Pizza
	{
		private const int minLength = 1;
		private const int maxLength = 15;
		private const int minTopping = 0;
		private const int maxTopping = 10;
		private string name;

		public Pizza()
		{
			this.Toppings = new List<Topping>();
		}

		public Pizza(string name, Dough dough)
			:this()
		{
			this.Name = name;
			this.Dough = dough;
		}

		public string Name
		{
			get { return name; }
			set
			{
				if (string.IsNullOrEmpty(value) || value.Length > maxLength)
				{
					throw new ArgumentException($"Pizza name should be between {minLength} and {maxLength} symbols.");
				}

				name = value;
			}
		}

		public Dough Dough { get; set; }
		public List<Topping> Toppings { get; set; }

		public void AddToping(Topping topping)
		{
			this.Toppings.Add(topping);
			if (this.Toppings.Count > maxTopping)
			{
				throw new ArgumentException($"Number of topping should be in range [{minTopping}..{maxTopping}]");
			}
		}
	}
}
