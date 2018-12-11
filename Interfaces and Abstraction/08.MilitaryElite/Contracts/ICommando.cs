using System.Collections.Generic;

namespace _08.MilitaryElite.Contracts
{
	interface ICommando : ISpecialisedSoldier
	{
		IReadOnlyCollection<IMission> Missions
		{
			get;
		}

		void AddMission(IMission mission);
		void CompleteMission(string missionCodeName);
	}
}
