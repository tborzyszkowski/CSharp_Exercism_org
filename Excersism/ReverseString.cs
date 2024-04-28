using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersism {
	public static class ReverseString {
		public static string Reverse(string input) {
			char[] charArray = input.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}
	}
}
