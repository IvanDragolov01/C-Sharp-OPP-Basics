namespace _12.Google
{
	class Company
	{
		private string _name;
		private string _department;
		private decimal _salary;

		public Company(string name, string department, decimal salary)
		{
			_name = name;
			_department = department;
			_salary = salary;
		}

		public decimal Salary
		{
			get
			{
				return _salary;
			}
			set
			{
				_salary = value;
			}
		}

		public string Department
		{
			get
			{
				return _department;
			}
			set
			{
				_department = value;
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
			return $"{Name} {Department} {Salary:F2}";
		}
	}
}
