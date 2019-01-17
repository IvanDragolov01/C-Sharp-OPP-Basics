using System;
using System.Collections.Generic;
using System.Text;

namespace _12.Google
{
	class Car
	{
		private string _model;
		private int _speed;

		public Car(string model, int speed)
		{
			_model = model;
			_speed = speed;
		}

		public int Speed
		{
			get
			{
				return _speed;
			}
			set
			{
				_speed = value;
			}
		}

		public string Model
		{
			get
			{
				return _model;
			}
			set
			{
				_model = value;
			}
		}

		public override string ToString()
		{
			return $"{Model} {Speed}";
		}
	}
}
