using NetFlagr.Model;
using NUnit.Framework;
using System.Threading.Tasks;

namespace NetFlagr.Tests
{
    public class EvaluationServiceTests : BaseTestWithHttpClient
	{
		[Test]
		public async Task PostEvaluationAsync()
		{
			var response = await ApiClient.EvaluationApiService.PostEvaluationAsync(new EvalContext() 
			{
				FlagKey = "demo_example"
			});
			Assert.Pass();
		}
	}
}