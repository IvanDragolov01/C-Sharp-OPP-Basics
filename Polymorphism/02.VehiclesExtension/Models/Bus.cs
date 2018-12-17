using System;

namespace _02.VehiclesExtension.Models
{
	public class Bus : Vehicle
	{
		private const double ACConsumption = 1.4;

		public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
			: base(fuelQuantity, fuelConsumption, tankCapacity)
		{
		}

		public override void Drive(double distance)
		{
			double neededFuel = distance * (base.FuelConsumption + ACConsumption);

			if (neededFuel <= FuelQuantity)
			{
				FuelQuantity -= neededFuel;
				Console.WriteLine($"Bus travelled {distance} km");
			}
			else
			{
				Console.WriteLine($"Bus needs refueling");
			}
		}

		public void DriveEmpty(double distance)
		{
			double neededFuel = distance * FuelConsumption;

			if (neededFuel <= FuelQuantity)
			{
				FuelQuantity -= neededFuel;
				Console.WriteLine($"Bus travelled {distance} km");
			}
			else
			{
				Console.WriteLine($"Bus needs refueling");
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
