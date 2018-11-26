using System;
using System.Collections.Generic;
using System.Text;

namespace _09.RectangleIntersection
{
	class Rectangle
	{
		private string _id;
		private double _width;
		private double _height;
		private double _topLeftX;
		private double _topLeftY;

		public Rectangle(string id, double width, double height, double topLeftX, double topLeftY)
		{
			this._id = id;
			this._width = Math.Abs(width);
			this._height = Math.Abs(height);
			this._topLeftX = topLeftX;
			this._topLeftY = topLeftY;
		}

		public string Id
		{
			get { return _id; }
			set { _id = value; }
		}

		public bool IsThereIntersection(Rectangle rectangle)
		{
			return rectangle._topLeftX + rectangle._width >= this._topLeftX &&
				rectangle._topLeftX <= this._topLeftX + this._width &&
				rectangle._topLeftY >= this._topLeftY - this._height &&
				rectangle._topLeftY - rectangle._height <= this._topLeftY;
		}
	}
}
