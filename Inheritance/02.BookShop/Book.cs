﻿using System;
using System.Text;

namespace _02.BookShop
{
	public class Book
	{
		private string _title;
		private string _author;
		private double _price;

		public Book(string author, string title, double price)
		{
			this.Author = author;
			this.Title = title;
			this.Price = price;
		}

		public string Title
		{
			get { return _title; }
			set
			{
				if (value.Length < 3)
				{
					throw new ArgumentException("Title not valid!");
				}

				_title = value;
			}
		}

		public string Author
		{
			get { return _author; }
			set
			{
				string[] authorNames = value.Split();

				if (authorNames.Length == 2 && char.IsDigit(authorNames[1][0]))
				{
					throw new ArgumentException("Author not valid!");
				}

				_author = value;
			}
		}

		public virtual double Price
		{
			get { return _price; }
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Price not valid!");
				}

				_price = value;
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.AppendLine($"Type: {this.GetType().Name}")
				.AppendLine($"Title: {this.Title}")
				.AppendLine($"Author: {this.Author}")
				.AppendLine($"Price: {this.Price:F2}");

			string result = builder.ToString().TrimEnd();
			return result;
		}
	}
}