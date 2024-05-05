
using Excersism;

namespace TestExcersism {
	public class RaceTrackTest {
		[Fact]
		public void DriveToAlmostDrainBattery() {
			int speed = 2;
			int batteryDrain = 1;
			var car = new RemoteControlCar(speed, batteryDrain);
			for (var i = 0; i < 99; i++)
			{
				car.Drive();
			}

			Assert.False(car.BatteryDrained());
		}
	}
}
