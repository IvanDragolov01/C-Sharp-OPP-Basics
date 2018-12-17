namespace _03._WildFarm.NewFolder
{
	abstract class Mammal : Animal
	{
		public Mammal(string name, double weight,string livingRegion)
			: base(name, weight)
		{
			LivingRegion = livingRegion;
		}

		public string LivingRegion
		{
			get;
			set;
		}

		public override string ToString()
		{
			string fromBase = base.ToString();
			string result = string.Format(fromBase, "{0}", $"{LivingRegion}, ");
			return result;
		}
	}
}
