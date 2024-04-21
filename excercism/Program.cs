using System;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace excercism {

	internal class Program {
		static void Main(string[] args)
		{
			var N = 200 * 1000;
			//Console.WriteLine(string.Join(" ",Sieve.GetPrimeNumbers(200)));
			var timer = new Stopwatch();
			timer.Start();
			//Console.WriteLine(string.Join(" ", Sieve.Primes(20000000)));
			Sieve.Primes(N);
			timer.Stop();
			Console.WriteLine(timer.Elapsed.ToString((@"m\:ss\.fff")));
			timer.Reset();
			timer.Start();
			//Console.WriteLine(string.Join(" ", Sieve.Primes2(20000000)));
			Sieve.Primes2(N);
			timer.Stop();
			Console.WriteLine(timer.Elapsed.ToString((@"m\:ss\.fff")));
		}
	}
}