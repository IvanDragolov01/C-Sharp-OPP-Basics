using _01.Structure.BusinessLogic;
using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Structure
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string input;
			DraftManager draftmanager = new DraftManager();

			while ((input = Console.ReadLine()) != "Shutdown")
			{
				List<string> arguments = input.Split().ToList();
				string command = arguments[0];
				arguments = arguments.Skip(1).ToList();

				switch (command)
				{
					case "RegisterHarvester":
						Console.WriteLine(draftmanager.RegisterHarvester(arguments));
						break;
					case "RegisterProvider":
						Console.WriteLine(draftmanager.RegisterProvider(arguments));
						break;
					case "Day":
						Console.WriteLine(draftmanager.Day());
						break;
					case "Mode":
						Console.WriteLine(draftmanager.Mode(arguments));
						break;
					case "Check":
						Console.WriteLine(draftmanager.Check(arguments));
						break;
				}
			}

			Console.WriteLine(draftmanager.ShutDown());
		}
	}
}
