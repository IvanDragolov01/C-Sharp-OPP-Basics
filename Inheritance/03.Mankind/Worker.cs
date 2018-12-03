using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Mankind
{
	public class Worker : Human
	{
		private const int MinWorkHours = 1;
		private const int MaxWorkHours = 12;
		private const int MinSalary = 10;
		private const int WorkDaysPerWeek = 5;

		private decimal weekSalary;
		private double workHoursPerDay;

		private const string Error = "Expected value mismatch! Argument: {0}";

		public Worker(string firstName, string lastName, decimal weekSalary, double workHours)
			: base(firstName, lastName)
		{
			this.WeekSalary = weekSalary;
			this.WorkHoursPerDay = workHours;
		}

		public decimal SalaryPerHour => weekSalary / (decimal)(workHoursPerDay * WorkDaysPerWeek);


		public decimal WeekSalary
		{
			get { return weekSalary; }
			set
			{
				if (value <= MinSalary)
				{
					throw new ArgumentException(string.Format(Error, nameof(weekSalary)));
				}

				weekSalary = value;
			}
		}

		public double WorkHoursPerDay
		{
			get { return workHoursPerDay; }
			set
			{
				if (value < MinWorkHours || value > MaxWorkHours)
				{
					throw new ArgumentException(string.Format(Error, nameof(WorkHoursPerDay)));
				}

				workHoursPerDay = value;
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.AppendLine(base.ToString())
				.AppendLine($"Week Salary: {this.WeekSalary:f2}")
				.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}")
				.AppendLine($"Salary per hour: {SalaryPerHour:f 2}");
			string result = builder.ToString().TrimEnd();
			return result;
		}
	}
}
