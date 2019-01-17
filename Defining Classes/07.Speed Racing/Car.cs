using System;

namespace _07.SpeedRacing
{
	public class Car
	{
		private string _model;
		private double _amountOfFuel;
		private double _fuelConsumption;
		private int _distance;

		public Car(string model, double amountOfFuel, double fuelConsumption)
		{
			_model = model;
			_amountOfFuel = amountOfFuel;
			_fuelConsumption = fuelConsumption;
			_distance = 0;
		}

		public int Distance
		{
			get
			{
				return _distance;
			}
			set
			{
				_distance = value;
			}
		}

		public double FuelConsumption
		{
			get
			{
				return _fuelConsumption;
			}
			set
			{
				_fuelConsumption = value;
			}
		}

		public double AmountOfFuel
		{
			get
			{
				return _amountOfFuel;
			}
			set
			{
				_amountOfFuel = value;
			}
		}

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

		public void Drive(int distance)
		{
			double neededFuel = distance * FuelConsumption;

			if (neededFuel <= AmountOfFuel)
			{
				AmountOfFuel -= neededFuel;
				Distance += distance;
			}
			else
			{
				Console.WriteLine("Insufficient fuel for the drive");
			}
		}

		public override string ToString()
		{
			return $"{Model} {AmountOfFuel:F2} {Distance}";
		}
	}
}
