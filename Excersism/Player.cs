using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersism {
	public class Player {
		readonly Random _random = new Random();
		public int RollDie() {
			
			return _random.Next(1, 19);
		}

		public double GenerateSpellStrength()
		{
			return _random.NextDouble() * 100;
		}
	}

}
