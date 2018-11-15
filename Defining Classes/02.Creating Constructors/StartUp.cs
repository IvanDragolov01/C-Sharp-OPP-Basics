using System;
using System.Reflection;

namespace _02.CreatingConstructors
{
	public class StartUp
	{
		public static void Main()
		{
			Person person = new Person("Ivan", 20);
			Console.WriteLine($"{person.Name} {person.Age}");
		}
	}
}