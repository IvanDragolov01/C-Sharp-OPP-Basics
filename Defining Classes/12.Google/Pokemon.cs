namespace _12.Google
{
	class Pokemon
	{
		private string _name;
		private string _type;

		public Pokemon(string name, string type)
		{
			_name = name;
			_type = type;
		}

		public string Type
		{
			get
			{
				return _type;
			}
			set
			{
				_type = value;
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
			return $"{Name} {Type}";
		}
	}
}
