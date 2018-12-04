using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Mankind
{
	public class Human
	{
		private const int LastNameMinLength = 3;
		private const int FirstNameMinLength = 4;
		private const string CapitalLetterError = "Expected upper case letter! Argument: {0}";
		private const string LengthError = "Expected length at least {0} symbols! Argument: {1}"; 

		private string firstName;
		private string lastName;

		public Human(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		public string FirstName
		{
			get { return firstName; }
			set
			{
				ValidateName(value, nameof(firstName), FirstNameMinLength);
				firstName = value;
			}
		}

		public string LastName
		{
			get { return lastName; }
			set
			{
				ValidateName(value, nameof(lastName), LastNameMinLength);
				lastName = value;
			}
		}

		private static void ValidateName(string value, string type,int minLength)
		{
			if (char.IsLower(value[0]))
			{
				throw new ArgumentException(string.Format(CapitalLetterError, type));
			}

			if (value.Length < minLength)
			{
				throw new ArgumentException(string.Format(LengthError, minLength,type));
			}
			
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.AppendLine($"First Name: {this.firstName}")
				.AppendLine($"Last Name: {this.lastName}");
			string result = builder.ToString().TrimEnd();

			return result;
		}
	}
}
