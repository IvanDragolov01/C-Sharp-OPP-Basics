using System;

namespace _06.CompanyRoster
{
	public class Employee
	{
		private string _name;
		private int _age;
		private decimal _salary;
		private string _position;
		private string _email;

		//public Employee()
		//{
		//	this.email = "n/a";
		//	this.Age = -1;
		//}
		public Employee(string _name, string _position, decimal _salary, int _age = - 1, string _email = "n/a")
		{
			this.Name = _name;
			this.Position = _position;
			this.Salary = _salary;
			this.Age = _age;
			this.Email = _email;
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public decimal Salary
		{
			get { return _salary; }
			set { _salary = value; }
		}

		public int Age
		{
			get { return _age; }
			set { _age = value; }
		}

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		public string Position
		{
			get { return _position; }
			set { _position = value; }
		}
	}
}
