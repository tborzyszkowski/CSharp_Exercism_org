using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercism {
	class RemoteControlCar
	{
		public int DistanceDriven { get; set; } = 0;
		public int RemainingBatteryCharge { get; set; } = 100;

		public static RemoteControlCar Buy()
		{
			return new RemoteControlCar();
		}

		public string DistanceDisplay()
		{
			return $"Driven {this.DistanceDriven} meters";
		}

		public string BatteryDisplay() {
			return (this.RemainingBatteryCharge > 0) ? 
				$"Battery at {this.RemainingBatteryCharge}%" :
				"Battery empty";
		}

		public void Drive()
		{
			if (this.RemainingBatteryCharge > 0)
			{
				this.DistanceDriven += 20;
				this.RemainingBatteryCharge -= 1;
			}
		}
	}

}
