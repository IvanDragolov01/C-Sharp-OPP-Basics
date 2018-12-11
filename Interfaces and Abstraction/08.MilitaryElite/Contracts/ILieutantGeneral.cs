using System.Collections.Generic;

namespace _08.MilitaryElite.Contracts
{
	public interface ILieutantGeneral
	{
		IReadOnlyCollection<ISolider> Privates
		{
			get;
		}

		void AddPrivate(ISolider solider);
	}
}
