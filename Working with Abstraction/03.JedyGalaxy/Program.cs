using System;
using System.Linq;

namespace _03.JedyGalaxy
{
	public class Program
	{
		static void Main()
		{
			int[] dimentions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).
				Select(int.Parse).
				ToArray();
			int x = dimentions[0];
			int y = dimentions[1];
			int[,] matrix = new int[x, y];
			int value = 0;

			for (int i = 0; i < x; i++)
			{
				for (int j = 0; j < y; j++)
				{
					matrix[i, j] = value++;
				}
			}

			string command = Console.ReadLine();
			long sum = 0;

			while (command != "Let the Force be with you")
			{
				int[] ivoS = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).
					Select(int.Parse).
					ToArray();
				int[] evil = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).
					Select(int.Parse).
					ToArray();
				int xEvil = evil[0];
				int yEvil = evil[1];

				while (xEvil >= 0 && yEvil >= 0)
				{
					if (xEvil >= 0 && xEvil < matrix.GetLength(0) && yEvil >= 0 && yEvil < matrix.GetLength(1))
					{
						matrix[xEvil, yEvil] = 0;
					}

					xEvil--;
					yEvil--;
				}

				int xIvos = ivoS[0];
				int yIvos = ivoS[1];

				while (xIvos >= 0 && yIvos < matrix.GetLength(1))
				{
					if (xIvos >= 0 && xIvos < matrix.GetLength(0) && yIvos >= 0 && yIvos < matrix.GetLength(1))
					{
						sum += matrix[xIvos, yIvos];
					}

					yIvos++;
					xIvos--;
				}

				command = Console.ReadLine();
			}

			Console.WriteLine(sum);
		}
	}
}
