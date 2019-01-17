using System;
using System.Text;

namespace _06.Animals
{
	public class Animal : ISoundProducable
	{
		private const string ErrorMessage = "Invalid input!";
		private string _name;
		private int _age;
		private string _gender;

		public Animal(string name, int age, string gender)
		{
			_name = name;
			_age = age;
			_gender = gender;
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				NotEmptyValidation(value);
				_name = value;
			}
		}

		public int Age
		{
			get
			{
				return _age;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException(ErrorMessage);
				}

				_age = value;
			}
		}

		public string Gender
		{
			get
			{
				return _gender;
			}
			set
			{
				NotEmptyValidation(value);

				if (value != "Male" && value != "Female")
				{
					throw new ArgumentException(ErrorMessage);
				}

				_gender = value;
			}
		}

		private static void NotEmptyValidation(string value)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentException(ErrorMessage);
			}
		}

		public virtual string ProduceSound()
		{
			return "NOISE!!!!!";
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"{GetType().Name}")
				.AppendLine($"{Name} {Age} {Gender}")
				.AppendLine(ProduceSound());

			string result = sb.ToString().TrimEnd();
			return result;
		}
	}
}
