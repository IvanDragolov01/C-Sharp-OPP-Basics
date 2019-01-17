using System;

namespace _01.Structure.Units.Provider
{
	public abstract class Provider : Unit
	{
		public const double MaxEnergyOutput = 10_000;
		private double _energyOutput;

		protected Provider(string id, double energyOutput)
			: base(id)
		{
			EnergyOutput = energyOutput;
		}

		public double EnergyOutput
		{
			get
			{
				return _energyOutput;
			}
			private set
			{
				if (value < 0 || value >= MaxEnergyOutput)
				{
					throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
				}

				_energyOutput = value;
			}
		}

		public override string ToString()
		{
			return $"{Type} Provider - {Id}" + Environment.NewLine +
				$"Energy Output: {_energyOutput}";
		}
	}
}
