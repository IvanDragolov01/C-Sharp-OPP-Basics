namespace Forum.App.Controllers
{
	using Forum.App.Controllers.Contracts;
	using Forum.App.UserInterface;
	using Forum.App.UserInterface.Contracts;
	using Forum.App.Views;
	using UserInterface.ViewModels;
	using WorkShop.Controllers.Services;

	public class PostDetailsController : IController, IUserRestrictedController
	{
		public bool LoggedInUser
		{
			get;
			set;
		}

		public int PostId
		{
			get;
			private set;
		}

		private enum Command
		{
			Back,
			AddReply,
		}

		public MenuState ExecuteCommand(int index)
		{
			switch ((Command)index)
			{
				case Command.AddReply:
					return MenuState.AddReplyToPost;
				case Command.Back:
					ForumViewEngine.ResetBuffer();
					return MenuState.Back;
				default:
					throw new InvalidCommandException();
			}
		}

		public IView GetView(string userName)
		{
			PostViewModel postViewModel = PostService.GetPostViewModel(PostId);
			return new PostDetailsView(postViewModel, LoggedInUser);
		}

		public void UserLogIn()
		{
			LoggedInUser = true;
		}

		public void UserLogOut()
		{
			LoggedInUser = false;
		}

		public void SetPostId(int postId)
		{
			PostId = postId;
		}
	}
}
