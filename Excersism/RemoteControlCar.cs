using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersism {
	public class RemoteControlCar {
		public int DistanceDrivenByCar { get; set; } = 0;
		public int RemainingBatteryCharge { get; set; } = 100;
		public readonly int Speed;
		public readonly int BatteryDrain;

		public RemoteControlCar(int speed, int batteryDrain)
		{
			Speed = speed;
			BatteryDrain = batteryDrain;
		}

		public bool BatteryDrained() =>
			RemainingBatteryCharge  < BatteryDrain;
		

		public int DistanceDriven() => DistanceDrivenByCar;

		public void Drive()
		{
			if (RemainingBatteryCharge >= BatteryDrain)
			{
				DistanceDrivenByCar += Speed;
				RemainingBatteryCharge -= BatteryDrain;
			}
		}

		public static RemoteControlCar Nitro() => 
			new RemoteControlCar(50, 4);
	}

	public class RaceTrack
	{
		public int Distance { get; set; } = 0;

		public RaceTrack(int distance) => 
			Distance = distance;
		

		public bool TryFinishTrack(RemoteControlCar car) => 
			Math.Ceiling((double)Distance / car.Speed) * car.BatteryDrain <= 100;
	}

}
