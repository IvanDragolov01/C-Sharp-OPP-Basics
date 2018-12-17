namespace _03._WildFarm.NewFolder
{
	abstract public class Bird : Animal
	{
		public Bird(string name, double weight, double wingSize)
			: base(name, weight)
		{
			WingSize = wingSize;
		}

		protected double WingSize
		{
			get;
			set;
		}

		public override string ToString()
		{
			string fromBase = base.ToString();
			string result = string.Format(fromBase, $"{WingSize}, ", string.Empty);
			return result;
		}
	}
}
