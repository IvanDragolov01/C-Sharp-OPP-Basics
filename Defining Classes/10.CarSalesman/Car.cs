using System;
using System.Text;

namespace _10.CarSalesman
{
	class Car
	{
		private string _model;
		private Engine _engine;
		private int _weight;
		private string _color;

		public Car(string model, Engine engine)
		{
			this.Model = model;
			this.Engine = engine;
			this.Weight = 0;
			this.Color = "n/a";
		}

		public string Color
		{
			get { return this._color; }
			set { this._color = value; }
		}

		public int Weight
		{
			get { return this._weight; }
			set { this._weight = value; }
		}

		public Engine Engine
		{
			get { return this._engine; }
			set { this._engine = value; }
		}

		public string Model
		{
			get { return this._model; }
			set { this._model = value; }
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"{this.Model}:")
				.AppendLine($"  {this.Engine}");

			if (this.Weight == 0)
			{
				sb.AppendLine($"  Weight: n/a");
			}
			else
			{
				sb.AppendLine($"  Weight: {this.Weight}");
			}

			sb.AppendLine($"  Color: {this.Color}");

			return sb.ToString().Trim();
		}
	}
}
