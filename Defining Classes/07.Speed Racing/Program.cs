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
			int membersNumber = int.Parse(Console.ReadLine());

			while (membersNumber > 0)
			{
				string[] carData = Console.ReadLine().Split();
				AddingCar member = new AddingCar(carData[0], int.Parse(carData[1]));
				//car.AddCar(member);
				membersNumber--;
			}
		}
	}
}
