using System;

public class Rectangle : IDrawable
{
	private int _width;
	private int _height;

	public Rectangle(int width, int height)
	{
		Width = width;
		Height = height;
	}

	public int Height
	{
		get
		{
			return _height;
		}

		private set
		{
			if (value <= 0)
			{
				throw new ArgumentException("Height must be positive!");
			}

			_height = value;
		}
	}

	public int Width
	{
		get
		{
			return _width;
		}

		private set
		{
			if (value <= 0)
			{
				throw new ArgumentException("Width must be positive!");
			}

			_width = value;
		}
	}

	public void Draw()
	{
		Console.WriteLine(new string('*', Width));

		for (int row = 1; row < Height - 1; row++)
		{
			Console.Write("*");

			for (int i = 1; i < Width - 1; i++)
			{
				Console.Write(" ");
			}

			Console.WriteLine("*");
		}

		Console.WriteLine(new string('*', Width));
	}
}