using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersism {
	public static class PhoneNumber {

		public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber) {
			var isNewYork = Array.IndexOf(new string[] { "212", "646", "718" }, phoneNumber.Substring(0, 3)) != -1;
			var isFake = phoneNumber.Substring(4, 3).Equals("555");
			var LocalNumber = phoneNumber.Substring(phoneNumber.Length - 4);
			return (isNewYork, isFake, LocalNumber);

		}

		public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
	}

}
