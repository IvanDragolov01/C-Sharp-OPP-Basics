using System;
using System.Collections.Generic;
using System.Text;

namespace _03.AnimalFarms
{
	public class Chicken
	{
		protected string _name;
		internal int _age;

		public Chicken(string _name, int _age)
		{
			this._name = _name;
			this._age = _age;
		}

		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		public int Age
		{
			get
			{
				return this._age;
			}
			set
			{
				this._age = value;
			}
		}

		public double ProductPerDay
		{
			get
			{
				return this.CalculateProductPerDay();
			}
		}

		private double CalculateProductPerDay()
		{
			switch (this.Age)
			{
				case 0:
				case 1:
				case 2:
				case 3:
					return 1.5;
				case 4:
				case 5:
				case 6:
				case 7:
					return 2;
				case 8:
				case 9:
				case 10:
				case 11:
					return 1;
				default:
					return 0.75;
			}
		}
	}
}
