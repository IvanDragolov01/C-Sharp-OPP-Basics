using System;
using System.Linq;
using System.Text;

namespace _03.Mankind
{
	public class Student : Human
	{
		private const int FacNumMinLength = 5;
		private const int FacNumMaxLength = 10;
		private string _facultyNumber;

		public Student(string firstName, string lastName, string facultyNumber)
			: base(firstName, lastName)
		{
			FacultyNumber = facultyNumber;
		}

		private string FacultyNumber
		{
			set
			{
				if (value.Length < FacNumMinLength || value.Length > FacNumMaxLength ||
					!value.All(char.IsLetterOrDigit))
				{
					throw new ArgumentException("Invalid faculty number!");
				}

				_facultyNumber = value;
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();

			builder.Append(base.ToString()).AppendLine($"Faculty number: {_facultyNumber}");

			return builder.ToString();
		}
	}
}
