using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCompany.MyModule;

namespace PowerShellTests
{
	public abstract class SampleCmdletTestBase
	{
		#region Methods

		[TestMethod]
		public virtual async Task Test()
		{
			await Task.CompletedTask;

			var sampleCmdlet = new SampleCmdlet
			{
				FavoriteNumber = 7,
				FavoritePet = "Dog"
			};

			var result = sampleCmdlet.Invoke().Cast<FavoriteStuff>().ToArray();

			Assert.IsNotNull(result);
			Assert.AreEqual(1, result.Length);
			Assert.AreEqual(7, result[0].FavoriteNumber);
			Assert.AreEqual("Dog", result[0].FavoritePet);
		}

		#endregion
	}
}