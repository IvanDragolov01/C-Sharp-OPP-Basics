using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Opinion_Poll
{
	class PrintingPersons
	{
		private List<Person> people;

		public PrintingPersons()
		{
			people = new List<Person>();
		}

		public List<Person> People
		{
			get { return people; }
			set { people = value; }
		}

		public void AddMember(Person member)
		{
			people.Add(member);
		}

		public Person GetAllАgesMoreThanMember()
		{
			return people.OrderByDescending(m => m.Age).FirstOrDefault();
		}
	}
}
