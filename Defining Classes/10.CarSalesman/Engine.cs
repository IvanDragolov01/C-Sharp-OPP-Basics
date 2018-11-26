using System;
using System.Collections.Generic;
using System.Text;

namespace _10.CarSalesman
{
	class Engine
	{
		private string _model;
		private int _power;
		private int _displacement;
		private string _efficiency;

		public Engine(string model, int power)
		{
			this.Model = model;
			this.Power = power;
			this.Displacement = 0;
			this.Efficiency = "n/a";
		}

		public string Efficiency
		{
			get { return this._efficiency; }
			set { this._efficiency = value; }
		}

		public int Displacement
		{
			get { return this._displacement; }
			set { this._displacement = value; }
		}

		public int Power
		{
			get { return this._power; }
			set { this._power = value; }
		}

		public string Model
		{
			get { return this._model; }
			set { this._model = value; }
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"  {this.Model}:").
			AppendLine($"    Power: {this.Power}");

			if (this.Displacement == 0)
			{
				sb.AppendLine($"    Displacement: n/a");
			}
			else
			{
				sb.AppendLine($"    Displacement: {this.Displacement}");
			}

			sb.AppendLine($"    Efficiency: {this.Efficiency}");

			return sb.ToString().Trim();
		}
	}
}
