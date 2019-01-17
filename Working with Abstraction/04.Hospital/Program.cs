using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Hospital
{
	class Program
	{
		public static void Main()
		{
			Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
			Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();
			string command = Console.ReadLine();

			while (command != "Output")
			{
				string[] tokens = command.Split();
				string departament = tokens[0];
				string firstName = tokens[1];
				string lastName = tokens[2];
				string patient = tokens[3];
				string fullName = firstName + lastName;
				string firstAndLastName = firstName + lastName;
				bool doctor = doctors.ContainsKey(firstAndLastName);

				if (!doctor)
				{
					doctors[fullName] = new List<string>();
				}

				bool department = departments.ContainsKey(departament);

				if (!department)
				{
					departments[departament] = new List<List<string>>();

					for (int rooms = 0; rooms < 20; rooms++)
					{
						departments[departament].Add(new List<string>());
					}
				}

				List<List<string>> dep = departments[departament];
				IEnumerable<string> dep2 = dep.SelectMany(x => x);
				bool IsAvailable = dep2.Count() < 60;

				if (IsAvailable)
				{
					int room = 0;
					doctors[fullName].Add(patient);
					List<List<string>> deps = departments[departament];

					for (int st = 0; st < deps.Count; st++)
					{
						List<string> depdep = departments[departament][st];

						if (depdep.Count < 3)
						{
							room = st;
							break;
						}
					}

					List<string> deproom = departments[departament][room];
					deproom.Add(patient);
				}

				command = Console.ReadLine();
			}

			command = Console.ReadLine();

			while (command != "End")
			{
				string[] args = command.Split();
				bool trytoParse = int.TryParse(args[1], out int room);
				List<string> department = departments[args[0]][room - 1];
				List<string> doctor = doctors[args[0] + args[1]];

				if (args.Length == 1)
				{
					Console.WriteLine(string
						.Join("\n", departments[args[0]]
						.Where(x => x.Count > 0)
						.SelectMany(x => x)));
				}
				else if (args.Length == 2 && trytoParse)
				{
					Console.WriteLine(string
						.Join("\n",department 
						.OrderBy(x => x)));
				}
				else
				{
					Console.WriteLine(string
						.Join("\n", doctor 
						.OrderBy(x => x)));
				}

				command = Console.ReadLine();
			}
		}
	}
}
