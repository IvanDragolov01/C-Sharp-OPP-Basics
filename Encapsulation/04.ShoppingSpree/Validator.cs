using System;

namespace _04.ShoppingSpree
{
	public static class Validator
	{
		public static void ValidateName(string name)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentException("Name cannot be empty");
			}
		}

		public static void ValidateMoney(decimal value)
		{
			if (value < 0)
			{
				throw new ArgumentException("Money cannot be negative");
			}
		}		
	}
}
