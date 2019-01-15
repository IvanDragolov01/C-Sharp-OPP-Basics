namespace Forum.App.UserInterface.Input
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Forum.App.UserInterface.Contracts;

	public class TextArea : IInput
	{
		private int x;
		private int y;
		private int width;
		private int height;
		private int textCursorPosition;
		private Position displayCursor;
		private const int OFFSET = 37;
		private IEnumerable<string> lines = new List<string>();
		private string text = string.Empty;
		private static char[] forbiddenCharacters = { ';' };

		private int MaxLength { get; set; }

		public int Left { get => x; }
		public int Top { get => y; }

		public IEnumerable<string> Lines
		{
			get => lines;
		}

		public string Text
		{
			get => text;
			set
			{
				text = value;
				lines = StringProcessor.Split(value);
			}
		}

		public Position DisplayCursor
		{
			get => displayCursor;
		}

		public TextArea(int x, int y, int width, int height, int maxLength)
		{
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
			displayCursor = new Position(x, y);
			MaxLength = maxLength;
		}

		public bool AddCharacter(char character)
		{
			if (Text.Length < MaxLength)
			{
				string stringBefore = Text.Substring(0, textCursorPosition);
				string stringAfter = Text.Substring(textCursorPosition, Text.Length - textCursorPosition);

				Text = stringBefore + character + stringAfter;

				textCursorPosition++;
				ForumViewEngine.DrawTextArea(this);
				return true;
			}

			return false;
		}

		internal void Write()
		{
			ForumViewEngine.DrawTextArea(this);
			ForumViewEngine.ShowCursor();

			while (true)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey(true);
				ConsoleKey key = keyInfo.Key;

				if (key == ConsoleKey.Backspace)
				{
					Delete();
				}
				else if (Text.Length == MaxLength || forbiddenCharacters.Contains(keyInfo.KeyChar))
				{
					Console.Beep(415, 260);
					continue;
				}

				else if (key == ConsoleKey.Enter || key == ConsoleKey.Escape)
				{
					break;
				}
				else
				{
					AddCharacter(keyInfo.KeyChar);
				}
			}

			ForumViewEngine.HideCursor();
		}

		public void Delete()
		{
			if (textCursorPosition > 0)
			{
				string stringBefore = Text.Substring(0, textCursorPosition);
				string stringAfter = Text.Substring(textCursorPosition, Text.Length - textCursorPosition);

				stringBefore = stringBefore.Substring(0, stringBefore.Length - 1);
				Text = stringBefore + stringAfter;
				textCursorPosition--;
				ForumViewEngine.DrawTextArea(this);
			}

			lines = StringProcessor.Split(Text);
		}

	}
}
