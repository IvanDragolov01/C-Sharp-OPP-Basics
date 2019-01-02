namespace _05.MordorsCruelPlan.Foods
{
	public abstract class Food
	{
		protected Food(int pointsOfHappiness)
		{
			PointsOfHappiness = pointsOfHappiness;
		}

		public int PointsOfHappiness
		{
			get;
			set;
		}
	}
}
