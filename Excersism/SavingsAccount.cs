using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersism {
	public static class SavingsAccount {
		public static float InterestRate(decimal balance) {
			if (balance < 0) return (float)3.213;
			if (balance >= 0 && balance < 1000) return (float)0.5;
			if (balance >= 1000 && balance < 5000) return (float)1.621;
			return (float)2.475;
		}

		public static decimal Interest(decimal balance) {
			return (balance * (decimal)InterestRate(balance)/100);
		}

		public static decimal AnnualBalanceUpdate(decimal balance) {
			return balance + Interest(balance);
		}

		public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance) {
			int counter = 0;
			decimal runningBalance = balance;
			while (Math.Abs(runningBalance) < Math.Abs(targetBalance)) {
				runningBalance += Interest(runningBalance);
				counter++;
			}
			return counter;
		}
	}
}
