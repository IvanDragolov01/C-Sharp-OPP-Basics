using System.Collections.Generic;
using System.Linq;

namespace _05.MordorsCruelPlan
{
	public class MoodFactory
	{
		public static Moods.Mood GetMood(List<Foods.Food> foods)
		{
			int totalPoints = foods.Sum(f => f.PointsOfHappiness);

			if (totalPoints < -5)
			{
				return new Moods.Angry();
			}
			else if (totalPoints >= -5 && totalPoints <= 0)
			{
				return new Moods.Sad();
			}
			else if (totalPoints >= 1 && totalPoints < 15)
			{
				return new Moods.Happy();
			}
			else
			{
				return new Moods.JavaScript();
			}
		}
	}
}
