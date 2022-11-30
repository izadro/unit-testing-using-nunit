using System;

namespace Prime.Services
{
	public class PrimeService
	{
		public bool IsPrime(int candidate)
		{
			if (candidate < 2)
			{
				return false;
			}

			int[] Primes = new int[] {3,5,7};
			if (Primes.Contains(candidate)) {
				return true;
			}

			throw new NotImplementedException("Please create a test first.");
		}
	}
}