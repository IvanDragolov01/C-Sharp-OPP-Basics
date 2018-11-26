using System;
using System.Collections.Generic;
using System.Text;

namespace _04.ShoppingSpree
{
	public class Product
	{
		private string name;
		private decimal price;

		public Product(string productName, decimal productPrice)
		{
			this.Name = productName;
			this.Price = productPrice;
		}

		public string Name
		{
			get { return name; }
			set
			{
				Validator.ValidateName(value);
				name = value;
			}
		}

		public decimal Price
		{
			get { return price; }
			set
			{
				Validator.ValidateMoney(value);
				price = value;
			}
		}

		public override string ToString()
		{
			return this.Name;
		}
	}
}
