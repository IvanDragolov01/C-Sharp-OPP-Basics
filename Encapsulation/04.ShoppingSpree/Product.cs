namespace _04.ShoppingSpree
{
	public class Product
	{
		private string _name;
		private decimal _price;

		public Product(string productName, decimal productPrice)
		{
			_name = productName;
			_price = productPrice;
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				Validator.ValidateName(value);
				_name = value;
			}
		}

		public decimal Price
		{
			get
			{
				return _price;
			}
			set
			{
				Validator.ValidateMoney(value);
				_price = value;
			}
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
