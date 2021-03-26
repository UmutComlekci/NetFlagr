using NetFlagr.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Segment functions to interact with the API endpoints
    /// </summary>
    internal class SegmentApiService : ISegmentApiService
    {
        private readonly NetFlagrApiClient _apiClient;

        public SegmentApiService(NetFlagrApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag to get</param>
        /// <param name="body">create a segment under a flag</param>
        /// <returns>Task of ApiResponse (Segment)</returns>
        public async Task<ApiResponse<Segment>> CreateSegmentAsync(long flagID, CreateSegmentRequest body)
        {
            if (body == null)
            {
                throw new ApiException(400, "Missing required parameter 'body' when calling SegmentApi->CreateSegment");
            }

            return await _apiClient.PostAsync($"flags/{flagID}/segments").WithBody((x) => x.Model(body)).AsApiResponse<Segment>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="segmentID">numeric ID of the segment</param>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<object>> DeleteSegmentAsync(long flagID, long segmentID)
        {
            return await _apiClient.DeleteAsync($"flags/{flagID}/segments/{segmentID}").AsApiResponse<object>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag to get</param>
        /// <returns>Task of ApiResponse (List&lt;Segment&gt;)</returns>
        public async Task<ApiResponse<IEnumerable<Segment>>> FindSegmentsAsync(long flagID)
        {
            return await _apiClient.GetAsync($"flags/{flagID}/segments").AsApiResponse<IEnumerable<Segment>>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="segmentID">numeric ID of the segment</param>
        /// <param name="body">update a segment</param>
        /// <returns>Task of ApiResponse (Segment)</returns>
        public async Task<ApiResponse<Segment>> PutSegmentAsync(long flagID, long segmentID, PutSegmentRequest body)
        {
            if (body == null)
            {
                throw new ApiException(400, "Missing required parameter 'body' when calling SegmentApi->PutSegment");
            }

            return await _apiClient.PutAsync($"flags/{flagID}/segments/{segmentID}").WithBody((x) => x.Model(body)).AsApiResponse<Segment>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="body">reorder segments</param>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<object>> PutSegmentsReorderAsync(long flagID, PutSegmentReorderRequest body)
        {
            if (body == null)
            {
                throw new ApiException(400, "Missing required parameter 'body' when calling SegmentApi->PutSegmentsReorder");
            }

            return await _apiClient.PutAsync($"flags/{flagID}/segments/reorder").WithBody((x) => x.Model(body)).AsApiResponse<object>();
        }
    }
}
