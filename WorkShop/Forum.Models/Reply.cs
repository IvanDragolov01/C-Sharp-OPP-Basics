namespace Forum.Models
{
	public class Reply
	{
		public int Id
		{
			get;
			set;
		}

		public string Content
		{
			get;
			set;
		}

		public int AuthorId
		{
			get;
			set;
		}


		public int PostId
		{
			get;
			set;
		}

		public Reply(int id, string content, int authorId, int posId)
		{
			Id = id;
			Content = content;
			AuthorId = authorId;
			PostId = posId;
		}
	}
}
