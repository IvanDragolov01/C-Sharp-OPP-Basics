using System;
using System.Reflection;

namespace _07.Speed_Racing
{
	class Program
	{
		static void Main(string[] args)
		{
			MethodInfo addMemberMethod = typeof(Car).GetMethod("AddMember");

			if (addMemberMethod == null)
			{
				throw new Exception();
			}

			Car car = new Car();

			string N;

			while ((N = Console.ReadLine()) != "End")
			{
				string[] carData = Console.ReadLine().Split();
				AddingCar member = new AddingCar(carData[0], int.Parse(carData[1]));
				
			}
		}
	}
}
