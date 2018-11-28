using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _05.DateModifier
{
	class DateModifier
	{
		public static double GetDaysBetweenDates(string dateOne, string dateTwo)
		{
			if (string.IsNullOrEmpty(dateOne))
			{
				throw new ArgumentNullException((dateOne));
			}

			if (string.IsNullOrEmpty(dateTwo))
			{
				throw new ArgumentNullException((dateTwo));
			}

			DateTime firstDate = DateTime.ParseExact(dateOne, "yyyy MM dd", CultureInfo.InvariantCulture);
			DateTime secondDate = DateTime.ParseExact(dateTwo, "yyyy MM dd", CultureInfo.InvariantCulture);

			if (firstDate > secondDate)
			{
				double result = GetDaysBetweenDates(dateTwo, dateOne);
				return result;
			}

			double secondresult = (secondDate - firstDate).Days;
			return secondresult;
		}
	}
}
