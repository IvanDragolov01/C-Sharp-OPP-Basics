using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PizzaCalories
{
	public class Dough
	{
		private const int minWeight = 1;
		private const int maxWeight = 200;
		private const int defaultMultiplier = 2;

		private Dictionary<string, double> validFlourTypes = new Dictionary<string, double>
		{
			["white"] = 1.5,
			["wholegrain"] = 1.0,
		};

		private Dictionary<string, double> validBakingTechnique = new Dictionary<string, double>
		{
			["crispy"] = 0.9,
			["chewy"] = 1.1,
			["homemade"] = 1.0,
		};

		private double weight;
		private string flourType;
		private string bakingTechnique;

		public Dough(string flourType, string bakingTechnique, double weight)
		{
			FlourType = flourType;
			BakingTechnique = bakingTechnique;
			Weight = weight;
		}

		private double FlourMultiplier => validFlourTypes[FlourType];

		private double BakingTechniqueMultiplier => validBakingTechnique[BakingTechnique];

		public double Calories =>
			defaultMultiplier * Weight * FlourMultiplier * BakingTechniqueMultiplier;

		public double Weight
		{
			get
			{
				return weight;
			}
			set
			{
				if (value < minWeight || value > maxWeight)
				{
					throw new ArgumentException($"Dough weight should be in the range [{minWeight}..{maxWeight}].");
				}

				weight = value;
			}
		}

		public string FlourType
		{
			get
			{
				return flourType;
			}
			set
			{
				ValidateTypes(value, validFlourTypes);
				flourType = value.ToLower();
			}
		}

		public string BakingTechnique
		{
			get
			{
				return bakingTechnique;
			}
			set
			{
				ValidateTypes(value, validBakingTechnique);
				bakingTechnique = value.ToLower();
			}
		}

		private static void ValidateTypes(string type, Dictionary<string, double> dictionary)
		{
			if (!dictionary.Any(f => f.Key == type.ToLower()))
			{
				throw new ArgumentException("Invalid type of dough.");
			}
		}
	}
}
