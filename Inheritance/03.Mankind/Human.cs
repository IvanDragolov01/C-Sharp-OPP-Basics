using System;
using System.Text;

namespace _03.Mankind
{
	public class Human
	{
		private const int LastNameMinLength = 3;
		private const int FirstNameMinLength = 4;
		private string _firstName;
		private string _lastName;

		public Human(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}

		public string FirstName
		{
			get
			{
				return _firstName;
			}
			set
			{
				if (char.IsLower(value[0]))
				{
					throw new ArgumentException($"Expected upper case letter! Argument: {nameof(_firstName)}");
				}

				if (value.Length < FirstNameMinLength)
				{
					throw new ArgumentException($"Expected length at least {FirstNameMinLength} symbols! Argument: {nameof(_firstName)}");
				}

				_firstName = value;
			}
		}

		public string LastName
		{
			get
			{
				return _lastName;
			}
			set
			{
				if (char.IsLower(value[0]))
				{
					throw new ArgumentException($"Expected upper case letter! Argument: {nameof(_lastName)}");
				}

				if (value.Length < LastNameMinLength)
				{
					throw new ArgumentException($"Expected length at least {LastNameMinLength} symbols! Argument: {nameof(_lastName)}");
				}

				_lastName = value;
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.AppendLine($"First Name: {_firstName}").AppendLine($"Last Name: {_lastName}");

			return builder.ToString();
		}
	}
}
