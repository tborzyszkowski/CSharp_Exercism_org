using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace excercism
{
	public static class Sieve
	{
		public static int[] Primes(int limit)
		{
			var candidates = Enumerable.Range(2, limit - 1).ToArray();
			var visited = new bool[candidates.Length];
			var primes = new List<int>();
			for (int i = 0; i < candidates.Length; i++)
			{
				if (visited[i]) continue;
				primes.Add(candidates[i]);
				for (int j = i; j < candidates.Length; j += candidates[i])
				{
					visited[j] = true;
				}
			}

			return primes.ToArray();
		}

		public static int[] Primes2(int limit) {
			var candidates = Enumerable.Range(2, limit).ToList();
			var current = 1;
			var limitSqrt = Math.Sqrt(limit);
			while ( current <  limitSqrt )
			{
				var temporalCurrent = current;
				var newCurrent = candidates.First(i => i > temporalCurrent);

				candidates.RemoveAll(i => i != newCurrent && i % newCurrent == 0);
				current = newCurrent;
			}
			return candidates.ToArray();
		}

		public static int[] GetPrimeNumbers(int max)
		{
			var allPossibleNumbers = Enumerable.Range(3, max-3);
			return 
				allPossibleNumbers
				.AsParallel()
				.Where(n => Enumerable.Range(2, (int)Math.Sqrt(n))
					.All(i => n % i != 0)
				)
				.Order()
				.ToArray();
		}
	}
}
