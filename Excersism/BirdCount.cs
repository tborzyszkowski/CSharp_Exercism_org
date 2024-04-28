using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersism {
	class BirdCount {
		private int[] birdsPerDay;

		public BirdCount(int[] birdsPerDay) {
			this.birdsPerDay = birdsPerDay;
		}

		public static int[] LastWeek()
		{
			return new int[] { 0, 2, 5, 3, 7, 8, 4 };

		}

		public int Today()
		{
			return this.birdsPerDay[^1];
		}

		public void IncrementTodaysCount()
		{
			int birdsPerDayLastIndex = this.birdsPerDay.Length;
			if (birdsPerDayLastIndex > 0)
				this.birdsPerDay[birdsPerDayLastIndex - 1]++;
		}

		public bool HasDayWithoutBirds()
		{
			return birdsPerDay.Any(e => e == 0);
		}

		public int CountForFirstDays(int numberOfDays)
		{
			int sum = 0;
			for (int i = 0; i < numberOfDays; i++)
			{
				sum += birdsPerDay[i];
			}
			return sum;
		}

		public int BusyDays()
		{
			return birdsPerDay.Count(e => e >= 5);
		}
	}
}
