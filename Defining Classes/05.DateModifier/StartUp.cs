using System;

namespace _05.DateModifier
{
	class StartUp
	{
		static void Main(string[] args)
		{
			string firstDate = Console.ReadLine();
			string secondDate = Console.ReadLine();
			double dateprint = DateModifier.GetDaysBetweenDates(firstDate, secondDate);
			Console.WriteLine(dateprint);
		}
	}
}
