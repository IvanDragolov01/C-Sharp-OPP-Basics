namespace _05.MordorsCruelPlan
{
	public class FoodFactory
	{
		public static Foods.Food GetFood(string foodName)
		{
			switch (foodName.ToLower())
			{
				case "apple":
					return new Foods.Apple(1);
				case "cram":
					return new Foods.Cram(2);
				case "honeycake":
					return new Foods.HoneyCake(5);
				case "lembas":
					return new Foods.Lembas(3);
				case "melon":
					return new Foods.Melon(1);
				case "mushrooms":
					return new Foods.Mushrooms(-10);
				default:
					return new Foods.OtherFood(-1);
			}
		}
	}
}
