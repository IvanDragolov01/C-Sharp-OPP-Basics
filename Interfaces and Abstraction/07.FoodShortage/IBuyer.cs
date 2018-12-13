namespace _07.FoodShortage
{
	interface IBuyer : IHuman
	{
		int Food
		{
			get;
		}

		void BuyFood();
	}
}
