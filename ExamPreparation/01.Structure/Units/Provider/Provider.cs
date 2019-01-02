using System;

namespace _01.Structure.Units.Provider
{
	public abstract class Provider : Unit
	{
		public const double maxEnergyOutput = 10_000;
		private double energyOutput;

		protected Provider(string id, double energyOutput)
			: base(id)
		{
			EnergyOutput = energyOutput;
		}

		public double EnergyOutput
		{
			get
			{
				return energyOutput;
			}
			private set
			{
				if (value < 0 || value >= maxEnergyOutput)
				{
					throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
				}

				energyOutput = value;
			}
		}

		public override string ToString()
		{
			return $"{Type} Provider - {Id}" + Environment.NewLine +
				$"Energy Output: {energyOutput}";
		}
	}
}
