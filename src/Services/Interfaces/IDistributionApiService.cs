using NetFlagr.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Distribution functions to interact with the API endpoints
    /// </summary>
    public interface IDistributionApiService
    {
        /// <summary>
        /// </summary>
        /// <remarks>
        /// Get the distributions
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="segmentID">numeric ID of the segment</param>
        /// <returns>Task of ApiResponse (List&lt;Distribution&gt;)</returns>
        Task<ApiResponse<IEnumerable<Distribution>>> GetDistributionsAsync(long flagID, long segmentID);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// replace the distribution with the new setting
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="segmentID">numeric ID of the segment</param>
        /// <param name="body">array of distributions</param>
        /// <returns>Task of ApiResponse (List&lt;Distribution&gt;)</returns>
        Task<ApiResponse<IEnumerable<Distribution>>> PutDistributionsAsync(long flagID, long segmentID, PutDistributionsRequest body);
    }
}
