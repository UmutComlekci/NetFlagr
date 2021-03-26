using NetFlagr.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Segment functions to interact with the API endpoints
    /// </summary>
    public interface ISegmentApiService
    {
        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag to get</param>
        /// <param name="body">create a segment under a flag</param>
        /// <returns>Task of ApiResponse (Segment)</returns>
        Task<ApiResponse<Segment>> CreateSegmentAsync(long flagID, CreateSegmentRequest body);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="segmentID">numeric ID of the segment</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> DeleteSegmentAsync(long flagID, long segmentID);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag to get</param>
        /// <returns>Task of ApiResponse (List&lt;Segment&gt;)</returns>
        Task<ApiResponse<IEnumerable<Segment>>> FindSegmentsAsync(long flagID);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="segmentID">numeric ID of the segment</param>
        /// <param name="body">update a segment</param>
        /// <returns>Task of ApiResponse (Segment)</returns>
        Task<ApiResponse<Segment>> PutSegmentAsync(long flagID, long segmentID, PutSegmentRequest body);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="body">reorder segments</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> PutSegmentsReorderAsync(long flagID, PutSegmentReorderRequest body);
    }
}
