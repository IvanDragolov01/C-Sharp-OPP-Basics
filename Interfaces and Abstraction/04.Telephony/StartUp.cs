using System;

namespace _04.Telephony
{
	class Startup
	{
		static void Main()
		{
			Smartphone smartphone = new Smartphone("Nokia");
			string[] phones = Console.ReadLine().Split(' ');

			foreach (string phone in phones)
			{
				Console.WriteLine(smartphone.Call(phone));
			}

			string[] websites = Console.ReadLine().Split(' ');

			foreach (string website in websites)
			{
				Console.WriteLine(smartphone.Browse(website));
			}
		}
	}
}