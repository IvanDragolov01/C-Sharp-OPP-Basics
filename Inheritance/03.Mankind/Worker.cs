using System;
using System.Text;

namespace _03.Mankind
{
	public class Worker : Human
	{
		private const decimal MinWeekSalary = 10;
		private const int MinWorkingHoursPerDay = 1;
		private const int MaxWorkingHoursPerDay = 12;
		private decimal _weekSalary;
		private double _workHoursPerDay;

		public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
			: base(firstName, lastName)
		{
			_weekSalary = weekSalary;
			_workHoursPerDay = workHoursPerDay;
		}

		private decimal WeekSalary
		{
			set
			{
				if (value <= MinWeekSalary)
				{
					throw new ArgumentException($"Expected value mismatch! Argument: {nameof(_weekSalary)}");
				}

				_weekSalary = value;
			}
		}

		private double WorkHoursPerDay
		{
			set
			{
				if (value < MinWorkingHoursPerDay || value > MaxWorkingHoursPerDay)
				{
					throw new ArgumentException($"Expected value mismatch! Argument: {nameof(_workHoursPerDay)}");
				}

				_workHoursPerDay = value;
			}
		}

		private decimal GetSalaryPerHour()
		{
			decimal salaryPerDay = _weekSalary / 5;
			return salaryPerDay / (decimal)_workHoursPerDay;
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();

			builder.Append(base.ToString())
				.AppendLine($"Week Salary: {_weekSalary:F2}")
				.AppendLine($"Hours per day: {_workHoursPerDay:F2}")
				.AppendLine($"Salary per hour: {GetSalaryPerHour():F2}");

			return builder.ToString();
		}
	}
}
