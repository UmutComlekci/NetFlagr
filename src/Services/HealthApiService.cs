using NetFlagr.Model;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Health functions to interact with the API endpoints
    /// </summary>
    internal class HealthApiService : IHealthApiService
    {
        private readonly NetFlagrHttpClient _httpClient;

        public HealthApiService(NetFlagrHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        ///  Check if Flagr is healthy
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Health)</returns>
        public async Task<ApiResponse<Health>> GetHealthAsync()
        {
            return await _httpClient.GetAsync("health").AsApiResponse<Health>();
        }
    }
}
