using Forum.Data;
using Forum.Models;
using System.Collections.Generic;
using System.Linq;
using static Forum.App.Controllers.SignUpController;

namespace WorkShop.Controllers.Services
{
	public static class UsersService
	{
		public static SingUpStatus TrySingUpUser(string username, string password)
		{
			bool validUsername = !string.IsNullOrWhiteSpace(username) && username.Length > 3;
			bool validPassword = !string.IsNullOrWhiteSpace(password) && password.Length > 3;

			if(!validUsername || !validPassword)
			{
				return SingUpStatus.DetailsError;
			}

			ForumData forumData = new ForumData();
			bool userAlreadyExist = forumData.Users.Any(u => u.Username == username);

			if (!userAlreadyExist)
			{
				int id = forumData.Users.LastOrDefault() ?.Id + 1 ?? 1;
				User user = new User(id, username, password, new List<int>());
				forumData.Users.Add(user);
				forumData.SaveChanges();
				return SingUpStatus.Success;
			}

			return SingUpStatus.UsernameTakenError;
		}

		public static bool TryLoginUser(string username, string password)
		{
			if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
			{
				return false;
			}

			ForumData forumData = new ForumData();
			bool userExists = forumData.Users.Any(u => u.Username == username && u.Password == password);
			return userExists;
		}

		public static User GetUser(int id)
		{
			ForumData forumdata = new ForumData();
			User user = forumdata.Users.Single(u => u.Id == id);
			return user;
		}

		public static User GetUser(string username, ForumData forumData)
		{
			User user = forumData.Users.Single(u => u.Username == username);
			return user;
		}
	}
}
