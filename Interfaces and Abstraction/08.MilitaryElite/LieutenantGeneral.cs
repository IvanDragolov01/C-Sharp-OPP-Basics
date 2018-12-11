using System.Collections.Generic;
using System.Text;

namespace _08.MilitaryElite.Contracts
{
	public class LieutenantGeneral : Private, ILieutantGeneral
	{
		private ICollection<ISolider> privates;

		public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
			: base(id, firstName, lastName, salary)
		{
			privates = new List<ISolider>();
		}

		public IReadOnlyCollection<ISolider> Privates => (IReadOnlyCollection<ISolider>)privates;

		public void AddPrivate(ISolider solider)
		{
			privates.Add(solider);
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.AppendLine(base.ToString())
				.AppendLine($"{nameof( Privates)}: ");
			//priv = private
			foreach (ISolider priv in Privates)
			{
				builder.AppendLine($"  {priv.ToString()}");
			}

			string result = builder.ToString().TrimEnd();
			return result;
		}
	}
}
