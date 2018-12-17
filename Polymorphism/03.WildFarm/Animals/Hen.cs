namespace _03._WildFarm.NewFolder
{
	class Hen : Bird
	{
		public Hen(string name, double weight, double wingSize)
			: base(name, weight, wingSize) { }

		protected override double WeightIncreaseMultiplier => 0.35;

		public override string MakeSound()
		{
			return "Cluck";
		}
	}
}
