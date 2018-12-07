using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RawData
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Car> cars = new List<Car>();
			int lines = int.Parse(Console.ReadLine());

			for (int i = 0; i < lines; i++)
			{
				string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				string model = parameters[0];
				int engineSpeed = int.Parse(parameters[1]);
				int enginePower = int.Parse(parameters[2]);
				int cargoWeight = int.Parse(parameters[3]);
				string cargoType = parameters[4];
				double tireFirstPressure = double.Parse(parameters[5]);
				int tireFirstage = int.Parse(parameters[6]);
				double tireSecondPressure = double.Parse(parameters[7]);
				int tireSecondage = int.Parse(parameters[8]);
				double tireThirdPressure = double.Parse(parameters[9]);
				int tireThirdage = int.Parse(parameters[10]);
				double tireFourthPressure = double.Parse(parameters[11]);
				int tireFourthage = int.Parse(parameters[12]);
				cars.Add(new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tireFirstPressure, tireFirstage, tireSecondPressure, tireSecondage, tireThirdPressure, tireThirdage, tireFourthPressure, tireFourthage));
			}

			string command = Console.ReadLine();

			if (command == "fragile")
			{
				IEnumerable<Car> frag = cars.Where(x => x._cargoType == "fragile" && x.tires.Any(y => y.Key < 1));
				IEnumerable<string> frag2 = frag.Select(x => x._model);
				List<string> fragile = frag2.ToList();
					

				Console.WriteLine(string.Join(Environment.NewLine, fragile));
			}
			else
			{
				IEnumerable<Car> flam =  cars.Where(x => x._cargoType == "flamable" && x._enginePower > 250);
				IEnumerable<string> flam2 = flam.Select(x => x._model);
				List<string> flamable = flam2.ToList();
				Console.WriteLine(string.Join(Environment.NewLine, flamable));
			}
		}
	}
}
