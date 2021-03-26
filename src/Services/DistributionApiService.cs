using NetFlagr.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Distribution functions to interact with the API endpoints
    /// </summary>
    internal class DistributionApiService : IDistributionApiService
    {
        private readonly NetFlagrApiClient _apiClient;

        public DistributionApiService(NetFlagrApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<ApiResponse<IEnumerable<Distribution>>> GetDistributionsAsync(long flagID, long segmentID)
        {
            return await _apiClient.GetAsync($"flags/{flagID}/segments/{segmentID}/distributions").AsApiResponse<IEnumerable<Distribution>>();
        }

        /// <summary>
        ///  replace the distribution with the new setting
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="segmentID">numeric ID of the segment</param>
        /// <param name="body">array of distributions</param>
        /// <returns>Task of ApiResponse (List&lt;Distribution&gt;)</returns>
        public async Task<ApiResponse<IEnumerable<Distribution>>> PutDistributionsAsync(long flagID, long segmentID, PutDistributionsRequest body)
        {
            if (body == null)
            {
                throw new ApiException(400, "Missing required parameter 'body' when calling DistributionApi->PutDistributions");
            }

            return await _apiClient.PutAsync($"flags/{flagID}/segments/{segmentID}/distributions")
                .WithBody((x) => x.Model(body))
                .AsApiResponse<IEnumerable<Distribution>>();
        }
    }
}
