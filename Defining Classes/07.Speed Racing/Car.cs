using System;
using System.Collections.Generic;
using System.Text;

namespace _07.SpeedRacing
{
	public class Car
	{
		private string _model;
		private double _amountOfFuel;
		private double _fuelConsumption;
		private int _distance;

		public Car(string _model, double _amountOfFuel, double _fuelConsumption)
		{
			this.Model = _model;
			this.AmountOfFuel = _amountOfFuel;
			this.FuelConsumption = _fuelConsumption;
			this.Distance = 0;
		}

		public int Distance
		{
			get { return this._distance; }
			set { this._distance = value; }
		}

		public double FuelConsumption
		{
			get { return this._fuelConsumption; }
			set { this._fuelConsumption = value; }
		}

		public double AmountOfFuel
		{
			get { return this._amountOfFuel; }
			set { this._amountOfFuel = value; }
		}

		public string Model
		{
			get { return this._model; }
			set { this._model = value; }
		}

		public void Drive(int distance)
		{
			double neededFuel = distance * this.FuelConsumption;

			if (neededFuel <= this.AmountOfFuel)
			{
				this.AmountOfFuel -= neededFuel;
				this.Distance += distance;
			}
			else
			{
				Console.WriteLine("Insufficient fuel for the drive");
			}
		}

		public override string ToString()
		{
			return $"{this.Model} {this.AmountOfFuel:F2} {this.Distance}";
		}
	}
}
