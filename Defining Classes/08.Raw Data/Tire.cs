namespace _08.RawData
{
	public class Tire
	{
		private int _age;
		private double _pressure;

		public Tire(int age, double pressure)
		{
			_age = age;
			_pressure = pressure;
		}

		public int Age
		{
			get
			{
				return _age;
			}
			set
			{
				_age = value;
			}
		}

		public double Pressure
		{
			get
			{
				return _pressure;
			}
			set
			{
				_pressure = value;
			}
		}
	}
}