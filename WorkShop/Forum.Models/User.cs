using System.Collections.Generic;

namespace Forum.Models
{
	public class User
	{
		public int Id
		{
			get;
			set;
		}

		public string Username
		{
			get;
			set;
		}

		public string Password
		{
			get;
			set;
		}

		public ICollection<int> PostIds
		{
			get;
			set;
		}

		public User(int id, string username, string password, ICollection<int> postids)
		{
			Id = id;
			Username = username;
			Password = password;
			PostIds = new List<int>(postids);
		}
	}
}
