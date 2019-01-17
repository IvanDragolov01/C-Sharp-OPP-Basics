using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CompanyRoster
{
	public class Department
	{
		private List<Employee> _employees;
		private string _name;

		public Department(string name)
		{
			_employees = new List<Employee>();
			_name = name;
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

		public List<Employee> Employees
		{
			get
			{
				return _employees;
			}

			private set
			{
				_employees = value;
			}
		}

		public decimal AverageSalary => Employees
			.Select(e => e.Salary)
			.Average();

		public void AddEmployee(Employee employee)
		{
			if (employee == null)
			{
				throw new ArgumentNullException();
			}

			Employees.Add(employee);
		}
	}
}