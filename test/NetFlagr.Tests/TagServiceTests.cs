using NUnit.Framework;
using System.Threading.Tasks;

namespace NetFlagr.Tests
{
    public class TagServiceTests : BaseTestWithHttpClient
	{
		[Test]
		public async Task FindAllTagsAsync()
		{
			var tagApiService = new TagApiService(ApiClient);
			var response = await tagApiService.FindAllTagsAsync();
			Assert.Pass();
		}
	}
}