using System;

namespace _03.Ferrari
{
	class Program
	{
		static void Main(string[] args)
		{
			string driverName = Console.ReadLine();
			Car ferrari = new Car();
			ferrari.Driver = driverName;
			ferrari.Model = "488-Spider";
			Console.Write($"{ferrari.Model}/");
			ferrari.Break();
			ferrari.GasPedal();
			Console.Write($"{ferrari.Driver}");
			Console.WriteLine();
		}
	}
}
