using Forum.App.UserInterface.ViewModels;
using Forum.Data;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkShop.Controllers.Services
{
	internal static class PostService
	{
		public static Category GetCategory(int id)
		{
			ForumData forumdata = new ForumData();
			Category category = forumdata.Categories.Single(c => c.Id == id);
			return category;
		}

		public static IList<ReplyViewModel> GetPostReplies(int id)
		{
			ForumData forumdata = new ForumData();
			Post post = forumdata.Posts.SingleOrDefault(p => p.Id == id);
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
			return forumData.Categories.Select(c => c.Name).ToArray();
		}

		public static IEnumerable<Post> GetPostsByCategory(int categoryId)
		{
			ForumData forumdata = new ForumData();
			Category category = forumdata.Categories.Single(c => c.Id == categoryId);
			List<Post> forumata1 = forumdata.Posts;
			return forumata1.Where(p => category.PostIds.Contains(p.Id)).ToList();
		}

		public static PostViewModel GetPostViewModel(int postId)
		{
			ForumData forumData = new ForumData();
			Post post = forumData
				.Posts
				.Single(p => p.Id == postId);
			return new PostViewModel(post);
		}

		private static Category EnsureCategory(PostViewModel postViewModel, ForumData forumData)
		{
			Category category = forumData
				.Categories
				.SingleOrDefault(c => c.Name == postViewModel.Category);

			if (category == null)
			{
				List<Category> categories = forumData
					.Categories;
				int id = categories
					.LastOrDefault()?.Id + 1 ?? 1;
				category = new Category(id, postViewModel.Category, new List<int>());
				forumData
						.Categories
					.Add(category);
				forumData.SaveChanges();
			}

			return category;
		}

		public static bool TrySavePost(PostViewModel postViewModel)
		{
			bool isTitleValid = !string.IsNullOrWhiteSpace(postViewModel.Title);
			bool isContentValid = postViewModel
				.Content
				.Any();
			bool isCategoryValid = !string
				.IsNullOrWhiteSpace(postViewModel.Category);

			if (!isTitleValid || !isContentValid || !isCategoryValid)
			{
				return false;
			}

			ForumData forumData = new ForumData();
			Category category = EnsureCategory(postViewModel, forumData);
			int postId = forumData.Posts.LastOrDefault()?.Id + 1 ?? 1;
			User author = UsersService.GetUser(postViewModel.Author, forumData);
			string content = string.Join("", postViewModel.Content);

			Post post = new Post(postId, postViewModel.Title, content, category.Id, author.Id, new List<int>());

			forumData.Posts.Add(post);
			category.PostIds.Add(postId);
			author.PostIds.Add(postId);
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
			var post = forumData.Posts.Single(p => p.Id == postId);
			int replyId = forumData.Replies.LastOrDefault()?.Id + 1 ?? 1;
			string content = string.Join("", replyViewModel.Content);
			Reply reply = new Reply(replyId, content, author.Id, postId);

			forumData.Replies.Add(reply);
			post.ReplyIds.Add(replyId);
			forumData.SaveChanges();
			return true;
		}
	}
}
