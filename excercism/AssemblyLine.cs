using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercism {
	static class AssemblyLine {
		const int CARS_PER_HOUR = 221;
		public static double SuccessRate(int speed) {
			return speed switch
			{
				0 => 0.0,
				< 5 => 1.0,
				< 9 => 0.9,
				9 => 0.8,
				10 => 0.77,
				_ => -1.0,
			};
	}

		public static double ProductionRatePerHour(int speed) {
			return speed * CARS_PER_HOUR * SuccessRate(speed);
		}

		public static int WorkingItemsPerMinute(int speed) {
			return (int)(ProductionRatePerHour(speed) / 60);
		}
	}
}
