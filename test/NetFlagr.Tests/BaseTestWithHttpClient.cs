using Microsoft.Extensions.Options;
using NUnit.Framework;
using System.Net.Http;

namespace NetFlagr.Tests
{
    public class BaseTestWithHttpClient
    {
		private readonly HttpClient _httpClient = new HttpClient();
		private NetFlagrApiClient _apiClient;

		protected NetFlagrApiClient ApiClient => _apiClient;

		[SetUp]
		public void Setup()
		{
			_apiClient = new NetFlagrApiClient(_httpClient, Options.Create<NetFlagrConfiguration>(new NetFlagrConfiguration()
			{
				BasePath = "https://try-flagr.herokuapp.com/api/v1/",
				Timeout = 100000,
				UserAgent = "",
				Username = "",
				Password = ""
			}));
		}
	}
}
