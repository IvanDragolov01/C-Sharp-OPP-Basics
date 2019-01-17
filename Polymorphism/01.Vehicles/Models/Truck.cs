using System;

namespace _01.Vehicles.Models
{
	public class Truck : Vehicle
	{
		private const double AcConsumption = 1.6;
		private const double UsedFuel = 95;

		public Truck(double fuelQuantity, double fuelConsumption)
			: base(fuelQuantity, fuelConsumption) { }

		public override void Drive(double distance)
		{
			double neededFuel = distance * (FuelConsumption + AcConsumption);

			if (neededFuel <= FuelQuantity)
			{
				FuelQuantity -= neededFuel;
				Console.WriteLine($"Truck travelled {distance} km");
			}
			else
			{
				Console.WriteLine($"Truck needs refueling");
			}
		}

		public override void Refuel(double liters)
		{
			FuelQuantity += liters * UsedFuel / 100.0;
		}
	}
}
