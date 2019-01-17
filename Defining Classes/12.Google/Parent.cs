namespace _12.Google
{
	class Parent
	{
		private string _name;
		private string _birthday;

		public Parent(string name, string birthday)
		{
			_name = name;
			_birthday = birthday;
		}

		public string Birthday
		{
			get
			{
				return _birthday;
			}
			set
			{
				_birthday = value;
			}
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

		public override string ToString()
		{
			return $"{Name} {Birthday}";
		}
	}
}
