namespace Forum.App.Controllers
{
	using System.Linq;
	using Forum.App.Controllers.Contracts;
	using Forum.App.UserInterface.Contracts;
	using Forum.App.Views;
	using WorkShop.Controllers.Services;

	public class CategoriesController : IController, IPaginationController
	{
		public const int PageOffset = 10;
		private const int CommandCount = PageOffset + 3;

		public CategoriesController()
		{
			CurrentPage = 0;
			LoadCategories();
		}

		public int CurrentPage
		{
			get;
			set;
		}

		public string[] AllCategoriesName
		{
			get;
			set;
		}

		public string[] CurrentPageCategories
		{
			get;
			set;
		}
		

		private int LastPage => AllCategoriesName.Length / (PageOffset + 1);

		private bool IsFirstPage => CurrentPage == 0;

		private bool IsLastPage => CurrentPage == LastPage;

		private enum Command
		{
			Back = 0,
			ViewCategory = 1,
			PreviousPage = 11,
			NextPage = 12
		}

		public MenuState ExecuteCommand(int index)
		{
			if (index > 1 && index < 11)
			{
				index = 1;
			}

			switch ((Command)index)
			{
				case Command.Back:
					return MenuState.Back;
				case Command.ViewCategory:
					return MenuState.OpenCategory;
				case Command.PreviousPage:
					ChangePage(false);
					return MenuState.Rerender;
				case Command.NextPage:
					ChangePage();
					return MenuState.Rerender;
			}

			throw new InvalidCommandException();
		}

		public IView GetView(string userName)
		{
			LoadCategories();
			return new CategoriesView(CurrentPageCategories, IsFirstPage, IsLastPage);
		}

		private void ChangePage(bool forward = true)
		{
			CurrentPage += forward ? 1 : -1;
		}

		private void LoadCategories()
		{
			AllCategoriesName = PostService.GetAllCategoryNames();
			CurrentPageCategories = AllCategoriesName
				.Skip(CurrentPage * PageOffset)
				.Take(PageOffset)
				.ToArray();
		}
	}
}
