namespace Forum.App
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Forum.App.Controllers;
	using Forum.App.Controllers.Contracts;
	using Forum.App.UserInterface;
	using Forum.App.UserInterface.Contracts;
	using WorkShop.Controllers.Services;
	using Models;

	internal class MenuController
	{
		private const int DEFAULT_INDEX = 0;

		private IController[] controllers;
		private Stack<int> controllerHistory;
		private int currentOptionIndex;
		private ForumViewEngine forumViewer;

		public MenuController(IEnumerable<IController> controllers, ForumViewEngine forumViewer)
		{
			this.controllers = controllers.ToArray();
			this.forumViewer = forumViewer;

			InitializeControllerHistory();

			currentOptionIndex = DEFAULT_INDEX;
		}

		private string Username
		{
			get;
			set;
		}

		private IView CurrentView
		{
			get;
			set;
		}

		private MenuState State => (MenuState)controllerHistory.Peek();
		private int CurrentControllerIndex => controllerHistory.Peek();
		private IController CurrentController => controllers[controllerHistory.Peek()];
		internal ILabel CurrentLabel => CurrentView.Buttons[currentOptionIndex];

		private void InitializeControllerHistory()
		{
			if (controllerHistory != null)
			{
				throw new InvalidOperationException($"{nameof(controllerHistory)} already initialized!");
			}

			int mainControllerIndex = 0;
			controllerHistory = new Stack<int>();
			controllerHistory.Push(mainControllerIndex);
			RenderCurrentView();
		}

		internal void PreviousOption()
		{
			currentOptionIndex--;

			if (currentOptionIndex < 0)
			{
				currentOptionIndex += CurrentView.Buttons.Length;
			}

			if (CurrentLabel.IsHidden)
			{
				PreviousOption();
			}
		}

		internal void NextOption()
		{
			currentOptionIndex++;

			int totalOptions = CurrentView.Buttons.Length;

			if (currentOptionIndex >= totalOptions)
			{
				currentOptionIndex -= totalOptions;
			}

			if (CurrentLabel.IsHidden)
			{
				NextOption();
			}
		}

		internal void Back()
		{
			if (State == MenuState.Categories || State == MenuState.OpenCategory)
			{
				IPaginationController currentController = (IPaginationController)CurrentController;
				currentController.CurrentPage = 0;
			}

			if (controllerHistory.Count > 1)
			{
				controllerHistory.Pop();
				currentOptionIndex = DEFAULT_INDEX;
			}

			RenderCurrentView();
		}

		internal void ExecuteCommand()
		{
			MenuState newState = CurrentController.ExecuteCommand(currentOptionIndex);

			switch (newState)
			{
				case MenuState.PostAdded:
					AddPost();
					break;
				case MenuState.OpenCategory:
					OpenCategory();
					break;
				case MenuState.ViewPost:
					ViewPost();
					break;
				case MenuState.SuccessfulLogIn:
					SuccessfulLogin();
					break;
				case MenuState.LoggedOut:
					LogOut();
					break;
				case MenuState.Back:
					Back();
					break;
				case MenuState.Error:
				case MenuState.Rerender:
					RenderCurrentView();
					break;
				case MenuState.AddReplyToPost:
					RedirectToAddReply();
					break;
				case MenuState.ReplyAdded:
					AddReply();
					break;
				default:
					RedirectToMenu(newState);
					break;
			}
		}

		private void AddReply()
		{
			Back();
		}

		private void RedirectToAddReply()
		{
			PostDetailsController postDetailsController = (PostDetailsController)CurrentController;
			AddReplyController addReplyController = (AddReplyController)controllers[(int)MenuState.AddReply];
			addReplyController.SetPostId(postDetailsController.PostId);
			RedirectToMenu(MenuState.AddReply);
		}

		private void LogOut()
		{
			Username = string.Empty;
			LogOutUser();
			RenderCurrentView();
		}

		private void SuccessfulLogin()
		{
			Username = ((IReadUserInfoController)CurrentController).Username;
			LogInUser();
			RedirectToMenu(MenuState.Main);
		}

		private void ViewPost()
		{
			CategoryController categoryController = (CategoryController)CurrentController;
			int categoryId = categoryController.CategoryId;
			Post[] posts = PostService
				.GetPostsByCategory(categoryId)
				.ToArray();
			int postIndex = categoryController
				.CurrentPage * CategoryController
				.PAGE_OFFSET + currentOptionIndex;
			Post post = posts[postIndex - 1];
			PostDetailsController postDeitalsController = (PostDetailsController)controllers[(int)MenuState.ViewPost];
			postDeitalsController.SetPostId(post.Id);
			RedirectToMenu(MenuState.ViewPost);
		}

		private void OpenCategory()
		{
			CategoriesController categoriesController = (CategoriesController)CurrentController;
			int categoryIndex = categoriesController.CurrentPage * CategoriesController.PAGE_OFFSET +
				currentOptionIndex;

			CategoryController categoryController = (CategoryController)controllers[(int)MenuState.OpenCategory];
			categoryController.SetCategory(currentOptionIndex);
			RedirectToMenu(MenuState.OpenCategory);
		}

		private void AddPost()
		{
			AddPostController addPostController = (AddPostController)CurrentController;
			int postId = addPostController.Post.PostId;
			PostDetailsController postViewer = (PostDetailsController)controllers[(int)MenuState.ViewPost];
			postViewer.SetPostId(postId);
			addPostController.ResetPost();
			controllerHistory.Pop();
			RedirectToMenu(MenuState.ViewPost);
		}

		private void RenderCurrentView()
		{
			CurrentView = CurrentController.GetView(Username);
			currentOptionIndex = DEFAULT_INDEX;
			forumViewer.RenderView(CurrentView);
		}

		private bool RedirectToMenu(MenuState newState)
		{
			if (State != newState)
			{
				controllerHistory.Push((int)newState);
				RenderCurrentView();
				return true;
			}

			return false;
		}

		private void LogInUser()
		{
			foreach (IController controller in controllers)
			{
				if (controller is IUserRestrictedController userRestrictedController)
				{
					userRestrictedController.UserLogIn();
				}
			}
		}

		private void LogOutUser()
		{
			foreach (IController controller in controllers)
			{
				if (controller is IUserRestrictedController userRestrictedController)
				{
					userRestrictedController.UserLogOut();
				}
			}
		}
	}
}