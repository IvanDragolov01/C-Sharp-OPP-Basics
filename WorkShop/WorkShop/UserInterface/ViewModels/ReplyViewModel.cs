namespace Forum.App.UserInterface.ViewModels
{
	using Forum.Models;
	using System.Collections.Generic;
	using System.Linq;
	using WorkShop.Controllers.Services;

	public class ReplyViewModel
	{
		private const int LineLength = 37;

		public ReplyViewModel()
		{
			Content = new List<string>();
		}

		public ReplyViewModel(Reply reply)
		{
			Author = UsersService.GetUser(reply.AuthorId).Username;
			Content = GetLines(reply.Content);
		}

		public string Author
		{
			get;
			set;
		}

		public IList<string> Content
		{
			get;
			set;
		}

		private IList<string> GetLines(string content)
		{
			char[] contentChars = content.ToCharArray();
			List<string> contentLines = new List<string>();

			for (int lineCounter = 0; lineCounter < contentChars.Length; lineCounter += LineLength)
			{
				IEnumerable<char> rowCharacters = contentChars.Skip(lineCounter).Take(lineCounter + LineLength);
				string line = string.Join("", rowCharacters);
				contentLines.Add(line);
			}

			return contentLines;
		}
	}
}