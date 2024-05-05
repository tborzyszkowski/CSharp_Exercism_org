using System.Reflection.Metadata;
using Excersism;

namespace TestExcersism {

	public class SavingsAccountTest {
		[Fact]
		public void Interest_for_4999_99m() {
			Assert.Equal(81.0498379m, SavingsAccount.Interest(4999.99m));
		}
		[Fact]
		public void YearsBeforeDesiredBalance_for_100_125_80() {
			Assert.Equal(47, SavingsAccount.YearsBeforeDesiredBalance(100.0m, 125.80m));
		}
	}
}
