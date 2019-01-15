namespace Forum.App.UserInterface.ViewModels
{
	using Forum.Models;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using WorkShop.Controllers.Services;

	public class PostViewModel
	{
		private const int LINE_LENGHT = 37;

		public PostViewModel()
		{
			Content = new List<string>();
		}

		public PostViewModel(Post post)
		{
			Author = UsersService.GetUser(post.AuthorId).Username;
			Category = PostService.GetCategory(post.CategoryId).Name;
			Title = post.Title;
			PostId = post.Id;
			Content = GetLines(post.Content);
			Replies = PostService.GetPostReplies(post.Id);
		}

		private IList<string> GetLines(string content)
		{
			char[] contentChars = content.ToCharArray();
			List<string> contentLines = new List<string>();

			for (int lineCounter = 0; lineCounter < contentLines.Count; lineCounter += LINE_LENGHT)
			{
				IEnumerable<char> rowCharacters = contentChars.Skip(lineCounter).Take(lineCounter + LINE_LENGHT);
				string line = string.Join("", rowCharacters);
				contentLines.Add(line);
			}

			return contentLines;
		}

		public int PostId
		{
			get;
			set;
		}

		public string Title
		{
			get;
			set;
		}

		public string Author
		{
			get;
			set;
		}

		public string Category
		{
			get;
			set;
		}

		public IList<string> Content
		{
			get;
			set;
		}

		public IList<ReplyViewModel> Replies
		{
			get;
			set;
		}
	}
}
