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
		public Employee(string name, string position, decimal salary, int age = - 1, string email = "n/a")
		{
			_name = name;
			_position = position;
			_salary = salary;
			_age = age;
			_email = email;
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
