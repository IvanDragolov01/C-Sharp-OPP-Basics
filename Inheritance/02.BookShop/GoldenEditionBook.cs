namespace _02.BookShop
{
	public class GoldenEditionBook : Book
	{
		private const double PriceIncreaseMultiplier = 1.3;
		public GoldenEditionBook(string author, string title, double price)
			:base(author, title, price) { }

		public override double Price
		{
			get => base.Price;
			set => base.Price = value * PriceIncreaseMultiplier;
		}
	}
}
