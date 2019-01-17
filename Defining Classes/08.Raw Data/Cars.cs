using System;
using System.Collections.Generic;

namespace _08.RawData
{
	public class Car
	{
		private string _model;
		private Engine _engine;
		private Cargo _cargo;
		private List<Tire> tires;

		public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
		{
			Model = model ?? throw new ArgumentNullException(nameof(model));
			Engine = engine ?? throw new ArgumentNullException(nameof(engine));
			Cargo = cargo ?? throw new ArgumentNullException(nameof(cargo));
			Tires = tires ?? throw new ArgumentNullException(nameof(tires));
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

		public Engine Engine
		{
			get
			{
				return _engine;
			}
			set
			{
				_engine = value;
			}
		}

		public Cargo Cargo
		{
			get
			{
				return _cargo;
			}
			set
			{
				_cargo = value;
			}
		}

		public List<Tire> Tires
		{
			get
			{
				return tires;
			}
			set
			{
				tires = value;
			}
		}
	}
}