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

		public Engine(string model, int power)
		{
			_model = model;
			_power = power;
			_displacement = -1;
			_efficiency = "n/a";
		}

		public Engine(string model, int power, int displacement)
		{
			_model = model;
			_power = power;
			_displacement = displacement;
			_efficiency = "n/a";
		}

		public Engine(string model, int power, string efficiency)
		{
			_model = model;
			_power = power;
			_displacement = -1;
			_efficiency = efficiency;
		}

		public Engine(string model, int power, int displacement, string efficiency)
		{
			_model = model;
			_power = power;
			_displacement = displacement;
			_efficiency = efficiency;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0}{1}:\n", offset, this._model);
			sb.AppendFormat("{0}{0}Power: {1}\n", offset, this._power);
			sb.AppendFormat("{0}{0}Displacement: {1}\n", offset, this._displacement == -1 ? "n/a" : this._displacement
				.ToString());
			sb.AppendFormat("{0}{0}Efficiency: {1}\n", offset, this._efficiency);

			return sb.ToString();
		}
	}
}
