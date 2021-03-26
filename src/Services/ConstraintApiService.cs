using NetFlagr.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Contraint functions to interact with the API endpoints
    /// </summary>
    internal class ConstraintApiService : IConstraintApiService
    {
        private readonly NetFlagrApiClient _apiClient;

        public ConstraintApiService(NetFlagrApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="segmentID">numeric ID of the segment</param>
        /// <param name="body">create a constraint</param>
        /// <returns>Task of ApiResponse (Constraint)</returns>
        public async Task<ApiResponse<Constraint>> CreateConstraintAsync(long flagID, long segmentID, CreateConstraintRequest body)
        {
            if (body == null)
            {
                throw new ApiException(400, "Missing required parameter 'body' when calling ConstraintApi->CreateConstraint");
            }

            return await _apiClient.PostAsync($"flags/{flagID}/segments/{segmentID}/constraints").AsApiResponse<Constraint>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="segmentID">numeric ID of the segment</param>
        /// <param name="constraintID">numeric ID of the constraint</param>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<object>> DeleteConstraintAsync(long flagID, long segmentID, long constraintID)
        {
            return await _apiClient.DeleteAsync($"flags/{flagID}/segments/{segmentID}/constraints/{constraintID}").AsApiResponse<object>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="segmentID">numeric ID of the segment</param>
        /// <returns>Task of ApiResponse (List&lt;Constraint&gt;)</returns>
        public async Task<ApiResponse<IEnumerable<Constraint>>> FindConstraintsAsync(long flagID, long segmentID)
        {
            return await _apiClient.GetAsync($"flags/{flagID}/segments/{segmentID}/constraints").AsApiResponse<IEnumerable<Constraint>>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="segmentID">numeric ID of the segment</param>
        /// <param name="constraintID">numeric ID of the constraint</param>
        /// <param name="body">create a constraint</param>
        /// <returns>Task of ApiResponse (Constraint)</returns>
        public async Task<ApiResponse<Constraint>> PutConstraintAsync(long flagID, long segmentID, long constraintID, CreateConstraintRequest body)
        {
            if (body == null)
            {
                throw new ApiException(400, "Missing required parameter 'body' when calling ConstraintApi->PutConstraint");
            }

            return await _apiClient.PutAsync($"flags/{flagID}/segments/{segmentID}/constraints/{constraintID}")
                .WithBody((x) => x.Model(body))
                .AsApiResponse<Constraint>();
        }
    }
}
