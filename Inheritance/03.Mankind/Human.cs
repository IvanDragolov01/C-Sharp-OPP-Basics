using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Mankind
{
	public class Human
	{
		private const int _LastNameMinLength = 3;
		private const int _FirstNameMinLength = 4;
		private const string _CapitalLetterError = "Expected upper case letter! Argument: {0}";
		private const string _LengthError = "Expected length at least {0} symbols! Argument: {1}"; 

		private string _firstName;
		private string _lastName;

		public Human(string firstName, string lastName)
		{
			this._firstName = FirstName;
			this._lastName = LastName;
		}

		public string FirstName
		{
			get { return _firstName; }
			set
			{
				ValidateName(value, nameof(_firstName), _FirstNameMinLength);
				_firstName = value;
			}
		}

		public string LastName
		{
			get { return _lastName; }
			set
			{
				ValidateName(value, nameof(_lastName), _LastNameMinLength);
				_lastName = value;
			}
		}

		private static void ValidateName(string value, string type,int minLength)
		{
			if (char.IsLower(value[0]))
			{
				throw new ArgumentException(string.Format(_CapitalLetterError, type));
			}

			if (value.Length < minLength)
			{
				throw new ArgumentException(string.Format(_LengthError, minLength,type));
			}
			
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.AppendLine($"First Name: {this._firstName}")
				.AppendLine($"Last Name: {this._lastName}");
			string result = builder.ToString().TrimEnd();

			return result;
		}
	}
}
