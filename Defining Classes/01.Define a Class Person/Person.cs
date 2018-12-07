namespace DefiningClasses
{
	public class Person
	{
		private int _age;
		private string _name;

		public Person(string name, int age)
		{
			_name = name;
			_age = age;
		}

		public string Name
		{
			get => _name;
			set => _name = value;
		}

		public int Age
		{
			get => _age;
			set => _age = value;
		}

		public string FullName
		{
			get
			{
				return $"{_name} {_age}";
			}
		}
	}
}
