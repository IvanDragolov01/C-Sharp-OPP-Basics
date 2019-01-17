using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PizzaCalories
{
	public class Dough
	{
		private const int MinWeight = 1;
		private const int MaxWeight = 200;
		private const int DefaultMultiplier = 2;

		private Dictionary<string, double> _validFlourTypes = new Dictionary<string, double>
		{
			["white"] = 1.5,
			["wholegrain"] = 1.0,
		};

		private Dictionary<string, double> _validBakingTechnique = new Dictionary<string, double>
		{
			["crispy"] = 0.9,
			["chewy"] = 1.1,
			["homemade"] = 1.0,
		};

		private double _weight;
		private string _flourType;
		private string _bakingTechnique;

		public Dough(string flourType, string bakingTechnique, double weight)
		{
			FlourType = flourType;
			BakingTechnique = bakingTechnique;
			Weight = weight;
		}

		private double FlourMultiplier => _validFlourTypes[FlourType];

		private double BakingTechniqueMultiplier => _validBakingTechnique[BakingTechnique];

		public double Calories =>
			DefaultMultiplier * Weight * FlourMultiplier * BakingTechniqueMultiplier;

		public double Weight
		{
			get
			{
				return _weight;
			}
			set
			{
				if (value < MinWeight || value > MaxWeight)
				{
					throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
				}

				_weight = value;
			}
		}

		public string FlourType
		{
			get
			{
				return _flourType;
			}
			set
			{
				ValidateTypes(value, _validFlourTypes);
				_flourType = value.ToLower();
			}
		}

		public string BakingTechnique
		{
			get
			{
				return _bakingTechnique;
			}
			set
			{
				ValidateTypes(value, _validBakingTechnique);
				_bakingTechnique = value.ToLower();
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
