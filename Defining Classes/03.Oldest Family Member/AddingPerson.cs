namespace _03.Oldest_Family_Member
{
	class AddingPerson
	{
		private string _name;
		private int _age;

		public AddingPerson(string name, int age)
		{
			_name = name;
			_age = age;
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		public int Age
		{
			get
			{
				return _age;
			}
			set
			{
				_age = value;
			}
		}
	}
}
