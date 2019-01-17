using System;

namespace _01.Structure.Units.Harvester
{
	public abstract class Harvester : Unit
	{
		public const double MaxEnergyRequirement = 10_000;
		private double _oreOutput;
		private double _energyRequirement;

		public double OreOutput
		{
			get
			{
				return _oreOutput;
			}
			private set
			{
				if (value < 0)
				{
					throw new ArgumentException("Harvester is not registered, because of it's ОreOutput");
				}

				_oreOutput = value;
			}
		}

		public double EnergyRequirement
		{
			get
			{
				return _energyRequirement;
			}
			private set
			{
				if (value < 0 || value >= MaxEnergyRequirement)
				{
					throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
				}

				_energyRequirement = value;
			}
		}

		protected Harvester(string id, double oreOutput, double energyRequirment)
			: base(id)
		{
			OreOutput = oreOutput;
			EnergyRequirement = energyRequirment;
		}

		public override string ToString()
		{
			return $"{Type} Harvester - {Id}" + Environment.NewLine +
				$"Ore Output: {OreOutput}" + Environment.NewLine +
				$"Energy Requirement: {_energyRequirement}";
		}
	}
}
