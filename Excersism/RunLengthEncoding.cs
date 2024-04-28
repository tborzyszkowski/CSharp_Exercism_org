using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersism {
	public static class RunLengthEncoding {
		public static string Encode(string input)
		{
			if (input == null || input.Length == 0)
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
			throw new NotImplementedException("You need to implement this function.");
		}
	}
}
