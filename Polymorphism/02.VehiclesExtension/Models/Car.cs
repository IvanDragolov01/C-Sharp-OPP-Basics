using System;

namespace _02.VehiclesExtension.Models
{
	public class Car : Vehicle
	{
		private const double ACConsumption = 0.9;

		public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
			: base(fuelQuantity, fuelConsumption, tankCapacity)
		{
		}

		public override void Drive(double distance)
		{
			double neededFuel = distance * (FuelConsumption + ACConsumption);

			if (neededFuel <= FuelQuantity)
			{
				base.FuelQuantity -= neededFuel;
				Console.WriteLine($"Car travelled {distance} km");
			}
			else
			{
				Console.WriteLine($"Car needs refueling");
			}
		}

		public override void Refuel(double liters)
		{
			if (liters <= 0)
			{
				Console.WriteLine("Fuel must be a positive number");
			}
			else
			{
				double totalFuel = FuelQuantity + liters;

				if (totalFuel > TankCapacity)
				{
					Console.WriteLine($"Cannot fit {liters} fuel in the tank");
				}
				else
				{
					FuelQuantity += liters;
				}
			}
		}
	}
}
