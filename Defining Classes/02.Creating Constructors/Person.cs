namespace _02.CreatingConstructors
{
	public class Person
	{
		private string _name;
		private int _age;

		public Person() 
		{
			_name = "No name";
			_age = 1;
		}

		public Person(int age)
		{
			_name = "No name";
			_age =  age;
		}

		public Person(string name, int age)
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
		}

		public int Age
		{
			get
			{
				return _age;
			}
		}
	}
}
