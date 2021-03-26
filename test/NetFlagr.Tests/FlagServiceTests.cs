using NUnit.Framework;
using System.Threading.Tasks;

namespace NetFlagr.Tests
{
    public class FlagServiceTests : BaseTestWithHttpClient
	{
		[Test]
		public async Task FindFlagsAsync()
		{
			var flagApiService = new FlagApiService(ApiClient);
			var response = await flagApiService.FindFlagsAsync(key: "superportal_portal_announcement");
			Assert.Pass();
		}
	}
}