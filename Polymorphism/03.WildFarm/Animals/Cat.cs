using System;

namespace _03._WildFarm.NewFolder
{
	class Cat : Feline
	{
		public Cat(string name, double weight, string livingRegion, string breed)
			: base(name, weight, livingRegion, breed) { }

		protected override Type[] PreferredFoods => new Type[] { typeof(Meat), typeof(Vegetable)};
		protected override double WeightIncreaseMultiplier => 0.30;

		public override string MakeSound()
		{
			return "Meow";
		}
	}
}
