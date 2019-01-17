namespace Forum.App.Views
{
	using System.Collections.Generic;

	using Forum.App.UserInterface;
	using Forum.App.UserInterface.Contracts;
	using Forum.App.UserInterface.Input;
	using Forum.App.UserInterface.ViewModels;

	public class AddReplyView : IView
	{
		private const int AuthorOffset = 8;
		private const int LeftOffset = 18;
		private const int TopOffset = 7;

		public AddReplyView(PostViewModel postViewModel, ReplyViewModel reply, TextArea textArea, bool error = false)
		{
			Post = postViewModel;
			SetBuffer();
			InitalizeLabels();
		}

		public ILabel[] Labels
		{
			get;
			private set;
		}

		public ILabel[] Buttons
		{
			get;
			private set;
		}

		private PostViewModel Post
		{
			get;
		}

		private void SetBuffer()
		{
			int totalLines = 25 + Post.Content.Count;

			if (totalLines > 30)
			{
				ForumViewEngine.SetBufferHeight(totalLines);
			}
		}

		private void InitalizeLabels()
		{
			Position consoleCenter = Position.ConsoleCenter();

			Position titlePosition =
				new Position(consoleCenter.Left - Post.Title.Length / 2, consoleCenter.Top - 10);
			Position authorPosition =
				new Position(consoleCenter.Left - Post.Author.Length, consoleCenter.Top - 9);

			List<ILabel> labels = new List<ILabel>()
			{
				new Label(Post.Title, titlePosition),
				new Label($"Author: {Post.Author}", authorPosition),
			};

			int leftPosition = consoleCenter.Left - LeftOffset;

			int lineCount = Post.Content.Count;

			// Add post contents
			for (int i = 0; i < lineCount; i++)
			{
				Position position = new Position(leftPosition, consoleCenter.Top - (TopOffset - i));
				ILabel label = new Label(Post.Content[i], position);
				labels.Add(label);
			}

			int currentRow = consoleCenter.Top - (TopOffset - lineCount) + 1;

			InitializeButtons(leftPosition, currentRow);

			Labels = labels.ToArray();
		}

		private void InitializeButtons(int left, int top)
		{
			Buttons = new ILabel[3];

			Buttons[0] = new Label("Write", new Position(left + 28, top - 1));
			Buttons[1] = new Label("Submit", new Position(left + 28, top + 12));
			Buttons[2] = new Label("Back", new Position(left + 28, top + 13));
		}
	}
}
