using FizzBuzz.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Fizzbuzz.Services
{
	[TestClass]
	public class FizzbuzzServices_FizzBuzzShould
	{
		private readonly FizzBuzzService _fizzBuzzService;

		public FizzbuzzServices_FizzBuzzShould()
		{
			_fizzBuzzService = new FizzBuzzService();
		}

		[TestMethod]
		[DataRow(1)]
		[DataRow(0)]
		[DataRow(-1)]
		[DataRow(7)]
		[DataRow(1253)]
		[DataRow(12544679863513)]
		public void returnValueifNotFizzBuzz(double value)
		{
			string result = _fizzBuzzService.FizzBuzz(value);
			Assert.AreEqual(result, value.ToString());
		}
		[TestMethod]
		[DataRow(3)]
		[DataRow(6)]
		public void returnFizzif3mod(double value)
		{
			string result = _fizzBuzzService.FizzBuzz(value);
			Assert.AreEqual(result, "Fizz");
		}
		[TestMethod]
		[DataRow(4)]
		[DataRow(8)]
		public void returnBuzzif4(double value)
		{ 
			string result = _fizzBuzzService.FizzBuzz(value);
			Assert.AreEqual(result, "Buzz");
		}
	}
}