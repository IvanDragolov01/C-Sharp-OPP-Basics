using System;

namespace _03._WildFarm.NewFolder
{
	class Dog : Mammal
	{
		public Dog(string name, double weight, string livingRegion)
			: base(name, weight, livingRegion) { }

		protected override Type[] PreferredFoods => new Type[] { typeof(Meat) };

		protected override double WeightIncreaseMultiplier => 0.40;

		public override string ToString()
		{
			string fromBase = base.ToString();
			string result = string.Format(fromBase, string.Empty);
			return result;
		}

		public override string MakeSound()
		{
			return "Woof!";
		}
	}
}
