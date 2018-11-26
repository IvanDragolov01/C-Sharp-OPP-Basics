using System;
using System.Collections.Generic;
using System.Text;

namespace _02.CarSalesman
{
	public class Engine
	{
		private const string offset = "  ";

		public string _model;
		public int _power;
		public int _displacement;
		public string _efficiency;

		public Engine(string _model, int _power)
		{
			this._model = _model;
			this._power = _power;
			this._displacement = -1;
			this._efficiency = "n/a";
		}

		public Engine(string _model, int _power, int _displacement)
		{
			this._model = _model;
			this._power = _power;
			this._displacement = _displacement;
			this._efficiency = "n/a";
		}

		public Engine(string _model, int _power, string _efficiency)
		{
			this._model = _model;
			this._power = _power;
			this._displacement = -1;
			this._efficiency = _efficiency;
		}

		public Engine(string _model, int _power, int _displacement, string _efficiency)
		{
			this._model = _model;
			this._power = _power;
			this._displacement = _displacement;
			this._efficiency = _efficiency;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0}{1}:\n", offset, this._model);
			sb.AppendFormat("{0}{0}Power: {1}\n", offset, this._power);
			sb.AppendFormat("{0}{0}Displacement: {1}\n", offset, this._displacement == -1 ? "n/a" : this._displacement.ToString());
			sb.AppendFormat("{0}{0}Efficiency: {1}\n", offset, this._efficiency);

			return sb.ToString();
		}
	}
}
