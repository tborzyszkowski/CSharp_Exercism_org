using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersism {
	public class Anagram
	{
		private string baseWord;
		public Anagram(string baseWord) {
			this.baseWord = baseWord;
		}

		public string[] FindAnagrams(string[] potentialMatches)
		{
			return potentialMatches.Where(IsBaseWordAnagram).ToArray();
		}

		private bool IsBaseWordAnagram(string word) {
			string baseWordLowercase = this.baseWord.ToLower();
			string wordLowercase = word.ToLower();

			if (baseWordLowercase.Equals(wordLowercase))
				return false;
			char[] baseWordLowecaseArray = baseWordLowercase.ToArray();
			char[] wordLowercaseArray = wordLowercase.ToArray();

			Array.Sort(baseWordLowecaseArray);
			Array.Sort(wordLowercaseArray);

			return new string(baseWordLowecaseArray) == new string(wordLowercaseArray);
		}
	}
}
