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
			this.Model = _model;
			this.Speed = speed;
		}

		public int Speed
		{
			get { return this._speed; }
			set { this._speed = value; }
		}

		public string Model
		{
			get { return this._model; }
			set { this._model = value; }
		}

		public override string ToString()
		{
			return $"{this.Model} {this.Speed}";
		}
	}
}
