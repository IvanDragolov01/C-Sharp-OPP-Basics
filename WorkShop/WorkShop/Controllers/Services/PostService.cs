using Forum.App.UserInterface.ViewModels;
using Forum.Data;
using Forum.Models;
using System.Collections.Generic;
using System.Linq;

namespace WorkShop.Controllers.Services
{
	internal static class PostService
	{
		public static Category GetCategory(int categoryId)
		{
			ForumData forumdata = new ForumData();
			Category category = forumdata.Categories.Find(c => c.Id == categoryId);
			return category;
		}

		public static IList<ReplyViewModel> GetPostReplies(int postId)
		{
			ForumData forumdata = new ForumData();
			Post post = forumdata.Posts.Find(p => p.Id == postId);
			List<ReplyViewModel> replies = new List<ReplyViewModel>();

			foreach (int replyId in post.ReplyIds)
			{
				Reply reply = forumdata.Replies.Single(r => r.Id == replyId);
				replies.Add(new ReplyViewModel(reply));
			}

			return replies;
		}

		public static string[] GetAllCategoryNames()
		{
			ForumData forumData = new ForumData();
			string[] allCategories = forumData.Categories.Select(c => c.Name).ToArray();
			return allCategories;
		}

		public static IEnumerable<Post> GetPostsByCategory(int categoryId)
		{
			ForumData forumData = new ForumData();
			ICollection<int> postIds = forumData.Categories.First(c => c.Id == categoryId).PostIds;
			IEnumerable<Post> posts = forumData.Posts.Where(p => postIds.Contains(p.Id));
			return posts;
		}

		public static PostViewModel GetPostViewModel(int postId)
		{
			ForumData forumData = new ForumData();
			Post post = forumData
				.Posts
				.Find(p => p.Id == postId);
			PostViewModel pvm = new PostViewModel(post);
			return pvm;
		}

		private static Category EnsureCategory(PostViewModel postViewModel, ForumData forumData)
		{
			string categoryName = postViewModel.Category;
			Category category = forumData.Categories.FirstOrDefault(c => c.Name == categoryName);
			if (category == null)
			{
				List<Category> categories = forumData.Categories;
				int categoryId = categories.Any() ? categories.Last().Id + 1 : 1;
				category = new Category(categoryId, categoryName, new List<int>());
				forumData.Categories.Add(category);
			}
			return category;
		}

		public static bool TrySavePost(PostViewModel postViewModel)
		{
			bool emptyCategory = string.IsNullOrWhiteSpace(postViewModel.Category);
			bool emptyTitle = string.IsNullOrWhiteSpace(postViewModel.Title);
			bool emptyContent = !postViewModel.Content.Any();

			if (emptyCategory || emptyTitle || emptyContent)
			{
				return false;
			}

			ForumData forumData = new ForumData();
			Category category = EnsureCategory(postViewModel, forumData);

			int postId = forumData.Posts.Any() ? forumData.Posts.LastOrDefault().Id + 1 : 1;
			User author = forumData.Users.Single(u => u.Username == postViewModel.Author);
			int authorId = author.Id;
			string content = string.Join("", postViewModel.Content);

			Post post = new Post(postId, postViewModel.Title, content, category.Id, authorId, new List<int>());

			forumData.Posts.Add(post);
			author.PostIds.Add(post.Id);
			category.PostIds.Add(post.Id);
			forumData.SaveChanges();
			postViewModel.PostId = postId;
			return true;
		}

		public static bool TrySaveReply(ReplyViewModel replyViewModel, int postId)
		{
			if (!replyViewModel.Content.Any())
			{
				return false;
			}

			ForumData forumData = new ForumData();
			User author = UsersService.GetUser(replyViewModel.Author, forumData);
			int authorId = author.Id;
			Post post = forumData.Posts.Single(p => p.Id == postId);
			int replyId = forumData.Replies.LastOrDefault()?.Id + 1 ?? 1;
			string content = string.Join("", replyViewModel.Content);

			Reply reply = new Reply(replyId, content, authorId, postId);

			forumData.Replies.Add(reply);
			post.ReplyIds.Add(replyId);
			forumData.SaveChanges();
			return true;
		}
	}
}
