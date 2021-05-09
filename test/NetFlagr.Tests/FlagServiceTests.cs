using NUnit.Framework;
using System.Threading.Tasks;

namespace NetFlagr.Tests
{
    public class FlagServiceTests : BaseTestWithHttpClient
	{
		[Test]
		public async Task FindFlagsAsync()
		{
			var response = await ApiClient.FlagApiService.FindFlagsAsync(key: "announcement");
			Assert.Pass();
		}
	}
}