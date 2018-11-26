using System;
using System.Collections.Generic;
using System.Text;

namespace _04.ShoppingSpree
{
	public class Product
	{
		private string _name;
		private decimal _price;

		public Product(string _productName, decimal _productPrice)
		{
			this.Name = _productName;
			this.Price = _productPrice;
		}

		public string Name
		{
			get { return _name; }
			set
			{
				Validator.ValidateName(value);
				_name = value;
			}
		}

		public decimal Price
		{
			get { return _price; }
			set
			{
				Validator.ValidateMoney(value);
				_price = value;
			}
		}

		public override string ToString()
		{
			return this.Name;
		}
	}
}
