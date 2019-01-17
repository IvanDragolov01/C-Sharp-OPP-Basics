using System.Text;

namespace _02.CarSalesman
{
	public class Car
	{
		private const string Offset = "  ";

		public string _model;
		public Engine _engine;
		public int _weight;
		public string _color;

		public Car(string model, Engine engine)
		{
			_model = model;
			_engine = engine;
			_weight = -1;
			_color = "n/a";
		}

		public Car(string model, Engine engine, int weight)
		{
			_model = model;
			_engine = engine;
			_weight = weight;
			_color = "n/a";
		}

		public Car(string model, Engine engine, string color)
		{
			_model = model;
			_engine = engine;
			_weight = -1;
			_color = color;
		}

		public Car(string model, Engine engine, int weight, string color)
		{
			_model = model;
			_engine = engine;
			_weight = weight;
			_color = color;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0}:\n", _model);
			sb.Append(this._engine.ToString());
			sb.AppendFormat("{0}Weight: {1}\n", Offset, _weight == -1 ? "n/a" : _weight.ToString());
			sb.AppendFormat("{0}Color: {1}", Offset, _color);

			return sb.ToString();
		}
	}
}
