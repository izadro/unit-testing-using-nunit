using System;

namespace FizzBuzz.Services
{
	public class FizzBuzzService
	{
		public string FizzBuzz(double candidate)
		{
			if(candidate < 3)
			{
				return candidate.ToString();
			}
			if (candidate % 3 != 0
				&& candidate % 4 != 0)
			{
				return candidate.ToString();
			}
			if (candidate % 3 == 0 && candidate>0)
			{
				return "Fizz";
			}
			if (candidate%4==0 && candidate>0)
			{
				return "Buzz";
			}
			throw new NotImplementedException("Please create a test first.");
		}
	}
}