using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PizzaCalories
{
	public class Topping
	{
		private const int MinWeight = 1;
		private const int MaxWeight = 50;
		private const int DefaultMultiplier = 2;

		private Dictionary<string, double> validTypes = new Dictionary<string, double>
		{
			["meat"] = 1.2,
			["veggies"] = 0.8,
			["cheese"] = 1.1,
			["sauce"] = 0.9,
		};

		private string _type;
		private double _weight;

		public Topping(string type, double weight)
		{
			Type = type;
			ValidateWeight(type ,weight);
			Weight = weight;
		}

		private double TypeMultiplier => validTypes[_type];
		public double Calories => DefaultMultiplier * Weight * TypeMultiplier;

		private void ValidateWeight(string type, double weight)
		{
			if (weight < MinWeight || weight > MaxWeight)
			{
				throw new ArgumentException($"{type} weight should be in the range [{MinWeight}..{MaxWeight}].");
			}
		}

		public string Type
		{
			get
			{
				return _type;
			}
			set
			{
				if (!validTypes.Any(t => t.Key == value.ToLower()))
				{
					throw new ArgumentException($"Cannot place {value} on top of your pizza.");
				}

				_type = value.ToLower();
			}
		}

		public double Weight
		{
			get
			{
				return _weight;
			}
			set
			{
				_weight = value;
			}
		}
	}
}
