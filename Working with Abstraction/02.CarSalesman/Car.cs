using System;
using System.Collections.Generic;
using System.Text;

namespace _02.CarSalesman
{
	public class Car
	{
		private const string offset = "  ";

		public string _model;
		public Engine _engine;
		public int _weight;
		public string _color;

		public Car(string _model, Engine _engine)
		{
			this._model = _model;
			this._engine = _engine;
			this._weight = -1;
			this._color = "n/a";
		}

		public Car(string _model, Engine _engine, int _weight)
		{
			this._model = _model;
			this._engine = _engine;
			this._weight = _weight;
			this._color = "n/a";
		}

		public Car(string _model, Engine _engine, string _color)
		{
			this._model = _model;
			this._engine = _engine;
			this._weight = -1;
			this._color = _color;
		}

		public Car(string model, Engine _engine, int _weight, string _color)
		{
			this._model = model;
			this._engine = _engine;
			this._weight = _weight;
			this._color = _color;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0}:\n", this._model);
			sb.Append(this._engine.ToString());
			sb.AppendFormat("{0}Weight: {1}\n", offset, this._weight == -1 ? "n/a" : this._weight.ToString());
			sb.AppendFormat("{0}Color: {1}", offset, this._color);

			return sb.ToString();
		}
	}
}
