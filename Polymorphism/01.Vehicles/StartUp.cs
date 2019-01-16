using _01.Vehicles.Models;
using System;

namespace _01.Vehicles
{
	public class Startup
	{
		private static Car car;
		private static Truck truck;

		public static void Main()
		{
			ParseInput();
			int numberOfCommands = int.Parse(Console.ReadLine());
			ParseCommand(numberOfCommands);
			Console.WriteLine(car);
			Console.WriteLine(truck);
		}

		private static void ParseInput()
		{
			string[] carParts = Console.ReadLine().Split(' ');
			string[] truckParts = Console.ReadLine().Split(' ');

			car = new Car(double.Parse(carParts[1]), double.Parse(carParts[2]));
			truck = new Truck(double.Parse(truckParts[1]), double.Parse(truckParts[2]));
		}

		private static void ParseCommand(int numberOfCommands)
		{
			for (int i = 0; i < numberOfCommands; i++)
			{
				string[] commandParts = Console.ReadLine().Split(' ');
				string command = commandParts[0];

				switch (command)
				{
					case "Drive":
						DriveCommand(commandParts);
						break;
					case "Refuel":
						RefuelCommand(commandParts);
						break;
				}
			}
		}

		private static void RefuelCommand(string[] commandParts)
		{
			string vehicle = commandParts[1];

			switch (vehicle)
			{
				case "Car":
					car.Refuel(double.Parse(commandParts[2]));
					break;
				case "Truck":
					truck.Refuel(double.Parse(commandParts[2]));
					break;
			}
		}

		private static void DriveCommand(string[] commandParts)
		{
			string vehicle = commandParts[1];

			switch (vehicle)
			{
				case "Car":
					car.Drive(double.Parse(commandParts[2]));
					break;
				case "Truck":
					truck.Drive(double.Parse(commandParts[2]));
					break;
			}
		}
	}
}
