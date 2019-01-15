namespace Forum.App.Controllers
{
	using Forum.App.Controllers.Contracts;
	using Forum.App.UserInterface.Contracts;
	using Forum.App.UserInterface.Input;
	using Forum.App.UserInterface.ViewModels;
	using Forum.App.Views;
	using System.Linq;
	using WorkShop.Controllers.Services;

	public class AddReplyController : IController
	{
		private enum Command { Write, Post }
		private const int TEXT_AREA_WIDTH = 37;
		private const int TEXT_AREA_HEIGHT = 6;
		private const int POST_MAX_LENGTH = 220;

		private static int centerTop = Position.ConsoleCenter().Top;
		private static int centerLeft = Position.ConsoleCenter().Left;

		public ReplyViewModel Reply
		{
			get;
			private set;
		}

		private PostViewModel postViewModel;

		public TextArea TextArea
		{
			get;
			set;
		}

		public bool Error
		{
			get;
			private set;
		}

		public AddReplyController()
		{
			ResetReply();
		}

		public MenuState ExecuteCommand(int index)
		{
			switch ((Command)index)
			{
				case Command.Write:
					TextArea.Write();
					Reply.Content = TextArea.Lines.ToArray();
					return MenuState.AddPost;
				case Command.Post:
					bool replyAdded = PostService.TrySaveReply(Reply, postViewModel.PostId);

					if (!replyAdded)
					{
						Error = true;
						return MenuState.Rerender;
					}

					return MenuState.ReplyAdded;
			}

			throw new InvalidCommandException();
		}

		public IView GetView(string userName)
		{
			Reply.Author = userName;
			return new AddReplyView(postViewModel, Reply, TextArea, Error);
		}

		public void ResetReply()
		{
			Error = false;
			Reply = new ReplyViewModel();
			int contentLength = postViewModel?.Content.Count ?? 0;
			TextArea = new TextArea(centerLeft - 18, centerTop + contentLength - 7,
				TEXT_AREA_WIDTH, TEXT_AREA_HEIGHT, POST_MAX_LENGTH);
		}

		public void SetPostId(int postId)
		{
			postViewModel = PostService.GetPostViewModel(postId);
			ResetReply();
		}
	}
}
