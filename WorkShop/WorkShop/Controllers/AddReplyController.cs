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
		private const int TextAreaWidth = 37;
		private const int TextAreaHeight = 6;
		private const int PostMaxLength = 220;

		private static int _centerTop = Position.ConsoleCenter().Top;
		private static int _centerLeft = Position.ConsoleCenter().Left;
		private PostViewModel postViewModel;

		public AddReplyController()
		{
			ResetReply();
		}

		public ReplyViewModel Reply
		{
			get;
			private set;
		}

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

		private enum Command
		{
			Write,
			Post
		}

		public MenuState ExecuteCommand(int index)
		{
			switch ((Command)index)
			{
				case Command.Write:
					TextArea.Write();
					Reply.Content = TextArea.Lines.ToArray();
					return MenuState.AddReply;
				case Command.Post:
					bool validAdded = PostService.TrySaveReply(Reply, postViewModel.PostId);

					if (!validAdded)
					{
						Error = true;
						return MenuState.Rerender;
					}

					return MenuState.ReplyAdded;
				default:
					throw new InvalidCommandException();
			}
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
			TextArea = new TextArea(_centerLeft - 18, _centerTop + contentLength - 6,
				TextAreaWidth, TextAreaHeight, PostMaxLength);
		}

		public void SetPostId(int postId)
		{
			postViewModel = PostService.GetPostViewModel(postId);
			ResetReply();
		}
	}
}
