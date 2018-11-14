using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Speed_Racing
{
	class AddingCar
	{
		private List<AddingCar> car;
		string model;
		double fuelAmount;
		double fuelConsumptionForOneKilometer;
		double traveledDistance;

		public AddingCar(string v, int v1)
		{
			car = new List<AddingCar>();
		}

		public List<AddingCar> Car
		{
			get { return car; }
			set { car = value; }
		}

		public void AddCar(AddingCar member)
		{
			car.Add(member);
		}
	}
}
