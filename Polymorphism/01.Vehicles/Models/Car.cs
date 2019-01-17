using _01.Vehicles.Models;
using System;

namespace _01.Vehicles
{
	public class Car : Vehicle
	{
		private const double AcConsumption = 0.9;

		public Car(double fuelQuantity, double fuelConsumption)
			: base(fuelQuantity, fuelConsumption) { }

		public override void Drive(double distance)
		{
			double neededFuel = distance * (FuelConsumption + AcConsumption);

			if (neededFuel <= FuelQuantity)
			{
				FuelQuantity -= neededFuel;
				Console.WriteLine($"Car travelled {distance} km");
			}
			else
			{
				Console.WriteLine($"Car needs refueling");
			}
		}

		public override void Refuel(double liters)
		{
			FuelQuantity += liters;
		}
	}
}
