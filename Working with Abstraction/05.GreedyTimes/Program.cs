using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.GreedyTimes
{
	public class Program 
	{
		static void Main(string[] args)
		{
			long bagCapacity = long.Parse(Console.ReadLine());
			string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			Dictionary<string, Dictionary<string, long>> bag = new Dictionary<string, Dictionary<string, long>>();
			long gold = 0;
			long gem = 0;
			long cash = 0;

			for (int i = 0; i < input.Length; i += 2)
			{
				string name = input[i];
				long count = long.Parse(input[i + 1]);
				string type = string.Empty;

				Dictionary<string, Dictionary<string, long>>.ValueCollection sum = bag.Values;
				IEnumerable<long> sum2 = sum.Select(x => x.Values.Sum());
				long sum3 = sum2.Sum();


				if (name.Length == 3)
				{
					type = "Cash";
				}
				else if (name.ToLower().EndsWith("gem"))
				{
					type = "Gem";
				}
				else if (name.ToLower() == "gold")
				{
					type = "Gold";
				}

				if (type == "")
				{
					continue;
				}
				
				else if (bagCapacity < sum3 + count)
				{
					continue;
				}

				switch (type)
				{
					case "Gem":
						if (!bag.ContainsKey(type))
						{
							if (bag.ContainsKey("Gold"))
							{
								if (count > bag["Gold"].Values.Sum())
								{
									continue;
								}
							}
							else
							{
								continue;
							}
						}
						else if (bag[type].Values.Sum() + count > bag["Gold"].Values.Sum())
						{
							continue;
						}
						break;
					case "Cash":
						if (!bag.ContainsKey(type))
						{
							if (bag.ContainsKey("Gem"))
							{
								if (count > bag["Gem"].Values.Sum())
								{
									continue;
								}
							}
							else
							{
								continue;
							}
						}
						else if (bag[type].Values.Sum() + count > bag["Gem"].Values.Sum())
						{
							continue;
						}

						break;
				}

				if (!bag.ContainsKey(type))
				{
					bag[type] = new Dictionary<string, long>();
				}

				if (!bag[type].ContainsKey(name))
				{
					bag[type][name] = 0;
				}

				bag[type][name] += count;

				if (type == "Gold")
				{
					gold += count;
				}
				else if (type == "Gem")
				{
					gem += count;
				}
				else if (type == "Cash")
				{
					cash += count;
				}
			}

			foreach (KeyValuePair<string, Dictionary<string, long>> x in bag)
			{
				string printKey = x.Key;
				Dictionary<string, long>.ValueCollection printValue = x.Value.Values;
				long printValueSum = printValue.Sum();
				Console.WriteLine($"<{printKey}> ${printValueSum}");
				Dictionary<string, long> x1 = x.Value;
				IOrderedEnumerable<KeyValuePair<string, long>> x2 = x1.OrderByDescending(y => y.Key);
				IOrderedEnumerable<KeyValuePair<string, long>> x3 = x2.ThenBy(y => y.Value);

				foreach (KeyValuePair<string, long> item in x3)
				{
					Console.WriteLine($"##{item.Key} - {item.Value}");
				}
			}
		}
	}
}