﻿namespace _01.Structure.Units.Harvester
{
	class SonicHarvester : Harvester
	{
		public override string Type => "Sonic";

		public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
			: base(id, oreOutput, energyRequirement / sonicFactor) { }
	}
}
