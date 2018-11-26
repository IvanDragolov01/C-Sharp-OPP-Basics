using System.Collections.Generic;

namespace _08.RawData
{
	public class Car
	{
		private string _model;
		private Engine _engine;
		private Cargo _cargo;
		private List<Tire> tires;

		public Car(string _model, Engine _engine, Cargo _cargo, List<Tire> tires)
		{
			this.Model = _model;
			this.Engine = _engine;
			this.Cargo = _cargo;
			this.Tires = tires;
		}

		public string Model
		{
			get { return _model; }
			set { _model = value; }
		}

		public Engine Engine
		{
			get { return _engine; }
			set { _engine = value; }
		}

		public Cargo Cargo
		{
			get { return _cargo; }
			set { _cargo = value; }
		}

		public List<Tire> Tires
		{
			get { return tires; }
			set { tires = value; }
		}
	}
}