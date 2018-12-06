using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Ferrari
{
	public class Car : ICar
	{
		private string driver;
		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public string Driver
		{
			get { return driver; }
			set { driver = value; }
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
