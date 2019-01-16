namespace _02.VehiclesExtension.Models
{
	public abstract class Vehicle
	{
		private double _fuelQuantity;
		private double _fuelConsumption;
		private double _tankCapacity;

		protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
		{
			FuelQuantity = _fuelQuantity > _tankCapacity ? 0 : _fuelQuantity;
			FuelConsumption = _fuelConsumption;
			TankCapacity = _tankCapacity;
		}

		public double TankCapacity
		{
			get
			{
				return _tankCapacity;
			}
			set
			{
				Validator.CheckPositiveNumber(value);
				_tankCapacity = value;
			}
		}

		public double FuelConsumption
		{
			get
			{
				return _fuelConsumption;
			}
			set
			{
				_fuelConsumption = value;
			}
		}

		public double FuelQuantity
		{
			get
			{
				return _fuelQuantity;
			}
			set
			{
				Validator.CheckPositiveNumber(value);
				_fuelQuantity = value;
			}
		}

		public abstract void Drive(double distance);

		public abstract void Refuel(double liters);

		public override string ToString()
		{
			return $"{GetType().Name}: {FuelQuantity:F2}";
		}
	}
}
