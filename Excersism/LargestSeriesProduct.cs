using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Excersism {
	public static class LargestSeriesProduct
	{
		public static long GetLargestProduct(string digits, int span)
		{
			ValidateData(digits, span);

			var maximum = 0L;
			var numbers = digits.Select(n => n - '0').ToList();
			for (var i = 0; i < numbers.Count - span + 1; i++)
			{
				var product = numbers
						.Skip(i)
						.Take(span)
						.Aggregate(1, (a, b) => a * b);
				if (product > maximum) maximum = product;
			}

			return maximum;
		}

		private static void ValidateData(string digits, int span)
		{
			if (digits.Length - span < 0)
			{
				throw new ArgumentException("span must be less than or equal to length of digits");
			}
			if (digits.Length == 0 && span == 0)
			{
				return;
			}
			if (digits.Length == 0)
			{
				throw new ArgumentException("digits cannot be ampty");
			}

			if (span < 1)
			{
				throw new ArgumentException("span must be positive");
			}

			if (Regex.IsMatch(digits, @"\D"))
			{
				throw new ArgumentException("digits must contain only digits");
			}
		}
	}
}
