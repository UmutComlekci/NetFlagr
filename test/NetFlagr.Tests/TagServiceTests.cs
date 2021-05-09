using NUnit.Framework;
using System.Threading.Tasks;

namespace NetFlagr.Tests
{
    public class TagServiceTests : BaseTestWithHttpClient
	{
		[Test]
		public async Task FindAllTagsAsync()
		{
			var response = await ApiClient.TagApiService.FindAllTagsAsync();
			Assert.Pass();
		}
	}
}