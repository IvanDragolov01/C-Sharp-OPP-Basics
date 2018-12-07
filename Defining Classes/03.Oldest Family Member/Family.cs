using System.Collections.Generic;
using System.Linq;

namespace _03.Oldest_Family_Member
{
	class Family
	{
		private List<AddingPerson> people;

		public Family()
		{
			people = new List<AddingPerson>();
		}

		public List<AddingPerson> People
		{
			get
			{
				return people;
			}
			set
			{
				people = value;
			}
		}

		public void AddMember(AddingPerson member)
		{
			people.Add(member);
		}

		public AddingPerson GetOldestMember()
		{
			return people.OrderByDescending(m => m.Age).FirstOrDefault();
		}
	}
}
