using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersism {
	public static class Bob {
		private static bool IsYelling(string text) {
			return text.Any(x => char.IsLetter(x)) && text.ToUpper().Equals(text);
		}

		private static bool IsQuestion(string text) {
			return text[^1] == '?';
		}

		private static bool IsSilence(string text) {
			return text.Equals("") || String.IsNullOrWhiteSpace(text);
		}

		public static string Response(string statement) {
			if (IsSilence(statement))
				return "Fine. Be that way!";

			var strippedStatement = statement.Trim();

			if (IsQuestion(strippedStatement))
			{
				if (IsYelling(strippedStatement))
					return "Calm down, I know what I'm doing!";

				return "Sure.";
			}

			if (IsYelling(strippedStatement))
				return "Whoa, chill out!";

			return "Whatever.";
		}
	}
}
