using System;

namespace _03.Ferrari
{
	public class Car : ICar
	{
		private string _driver;
		private string _model;

		public string Model
		{
			get
			{
				return _model;
			}
			set
			{
				_model = value;
			}
		}

		public string Driver
		{
			get
			{
				return _driver;
			}
			set
			{
				_driver = value;
			}
		}

		public void Break()
		{
			Console.Write("Brakes!");
		}

		public void GasPedal()
		{
			Console.Write("/Zadu6avam sA!/");
		}
	}
}
