using System;

namespace _05.DateModifier
{
	class StartUp
	{
		static void Main(string[] args)
		{
			var firstDate = Console.ReadLine();
			var secondDate = Console.ReadLine();
			Console.WriteLine(DateModifier.GetDaysBetweenDates(firstDate, secondDate));
		}
	}
}
