using System;

public class Circle : IDrawable
{
	private int _radius;

	public Circle(int radius)
	{
		Radius = radius;
	}

	public int Radius
	{
		get
		{
			return _radius;
		}
		private set
		{
			if (value <= 0)
			{
				throw new ArgumentException("Radius must be positive!");
			}

			_radius = value;
		}
	}

	public void Draw()
	{
		double innerRadius = Radius - 0.4;
		double outsideRadius = Radius + 0.4;

		for (double i = Radius; i >= -Radius; --i)
		{
			for (double j = -Radius; j < outsideRadius; j += 0.5)
			{
				double value = i * i + j * j;

				if (value >= innerRadius * innerRadius && value <= outsideRadius * outsideRadius)
				{
					Console.Write("*");
				}
				else
				{
					Console.Write(" ");
				}
			}

			Console.WriteLine();
		}
	}
}