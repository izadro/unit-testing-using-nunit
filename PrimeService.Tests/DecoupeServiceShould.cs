using Decoupe.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Decoupe.Service
{
	[TestClass]
	public class DecoupeServiceShould
	{
		private readonly DecoupeService _decoupeService;

		public DecoupeServiceShould()
		{
			_decoupeService = new DecoupeService();
		}

		[TestMethod]
		public void besoin0necessite0siSeulement1m()
		{
			int result = _decoupeService.optimisation();
			Assert.AreEqual(result, 0);
		}
	}
}