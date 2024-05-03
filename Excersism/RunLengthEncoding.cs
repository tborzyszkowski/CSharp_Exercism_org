using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersism {
	public static class RunLengthEncoding {
		public static string Encode(string input) {
			if (input.Length == 0)
				return input;
			char[] charInput = input.ToCharArray();
			int count = 0;
			int idx = 0;
			int len = charInput.Length;
			char currentChar;
			StringBuilder sb = new StringBuilder();
			while (idx < len)
			{
				currentChar = charInput[idx];
				count = 1;
				while (idx + count < len)
				{
					char pomChar = charInput[idx + count];
					if (pomChar == currentChar)
						count++;
					else
						break;
				}
				if (count == 1)
					sb.Append(currentChar);
				else
				{
					sb.Append(count).Append(currentChar);
				}
				idx += count;
			}
			return sb.ToString();
		}

		public static string Decode(string input) {
			if (input.Length == 0)
				return input;
			char[] charInput = input.ToCharArray();
			StringBuilder sb = new StringBuilder();
			int len = charInput.Length;
			int idx = 0;
			int count = 0;
			while (idx < len)
			{
				count = 0;

				char pomChar = charInput[idx];
				while (Char.IsNumber(pomChar))
				{
					if (count > 0)
						count *= 10;
					count += pomChar - '0';
					if (idx < len)
					{
						idx++;
						pomChar = charInput[idx];
					}
				}
				if (count > 0)
					sb.Append(pomChar, count);
				else
						sb.Append(pomChar);
				idx++;
			}
			return sb.ToString();
		}
	}
}
