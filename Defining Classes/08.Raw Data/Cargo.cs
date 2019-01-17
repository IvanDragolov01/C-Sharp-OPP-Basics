namespace _08.RawData
{
	public class Cargo
	{
		private int _cargoWeight;
		private string _cargoType;

		public Cargo(int cargoWeight, string cargoType)
		{
			_cargoWeight = cargoWeight;
			_cargoType = cargoType;
		}

		public int CargoWeight
		{
			get
			{
				return _cargoWeight;
			}
			set
			{
				_cargoWeight = value;
			}
		}

		public string CargoType
		{
			get
			{
				return _cargoType;
			}
			set
			{
				_cargoType = value;
			}
		}
	}
}