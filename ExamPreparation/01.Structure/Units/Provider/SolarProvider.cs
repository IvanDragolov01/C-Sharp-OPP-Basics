namespace _01.Structure.Units.Provider
{
	public class SolarProvider : Provider
	{
		public override string Type => "Solar";

		public SolarProvider(string id, double energyOutput)
			: base(id, energyOutput) { }
	}
}
