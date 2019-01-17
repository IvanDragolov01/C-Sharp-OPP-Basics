using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.MordorsCruelPlan
{
	public class Startup
	{
		public static void Main()
		{
			List<Foods.Food> foods = new List<Foods.Food>();
			string[] inputParts = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string foodName in inputParts)
			{
				Foods.Food food = FoodFactory.GetFood(foodName);
				foods.Add(food);
			}

			Moods.Mood mood = MoodFactory.GetMood(foods);
			Console.WriteLine(foods.Sum(f => f.PointsOfHappiness));
			Console.WriteLine(mood);
		}
	}
}
