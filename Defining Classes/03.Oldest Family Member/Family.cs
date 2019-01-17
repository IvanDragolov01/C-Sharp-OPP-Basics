using System.Collections.Generic;
using System.Linq;

namespace _03.Oldest_Family_Member
{
	class Family
	{
		private List<AddingPerson> _people;

		public Family()
		{
			_people = new List<AddingPerson>();
		}

		public List<AddingPerson> People
		{
			get
			{
				return _people;
			}
			set
			{
				_people = value;
			}
		}

		public void AddMember(AddingPerson member)
		{
			_people.Add(member);
		}

		public AddingPerson GetOldestMember()
		{
			return _people.OrderByDescending(m => m.Age).FirstOrDefault();
		}
	}
}
