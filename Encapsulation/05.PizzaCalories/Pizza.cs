using System;
using System.Collections.Generic;
using System.Text;

namespace _05.PizzaCalories
{
	public class Pizza
	{
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public Dough Dough { get; set; }
		public List<Topping> Toppings { get; set; }
	}
}
