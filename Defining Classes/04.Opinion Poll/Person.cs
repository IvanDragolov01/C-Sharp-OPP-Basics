namespace _04.Opinion_Poll
{
	public class Person
	{
		private string _name;
		private int _age;

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
