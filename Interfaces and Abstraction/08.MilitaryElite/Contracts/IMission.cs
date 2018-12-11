namespace _08.MilitaryElite.Contracts
{
	public interface IMission
	{
		string CodeName
		{
			get;
		}

		MissionState State
		{
			get;
		}

		void Complete();
	}
}