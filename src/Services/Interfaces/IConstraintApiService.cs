using NetFlagr.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Contraint functions to interact with the API endpoints
    /// </summary>
    public interface IConstraintApiService
    {
        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="segmentID">numeric ID of the segment</param>
        /// <param name="body">create a constraint</param>
        /// <returns>Task of ApiResponse (Constraint)</returns>
        Task<ApiResponse<Constraint>> CreateConstraintAsync(long flagID, long segmentID, CreateConstraintRequest body);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="segmentID">numeric ID of the segment</param>
        /// <param name="constraintID">numeric ID of the constraint</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> DeleteConstraintAsync(long flagID, long segmentID, long constraintID);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="segmentID">numeric ID of the segment</param>
        /// <returns>Task of ApiResponse (List&lt;Constraint&gt;)</returns>
        Task<ApiResponse<IEnumerable<Constraint>>> FindConstraintsAsync(long flagID, long segmentID);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="segmentID">numeric ID of the segment</param>
        /// <param name="constraintID">numeric ID of the constraint</param>
        /// <param name="body">create a constraint</param>
        /// <returns>Task of ApiResponse (Constraint)</returns>
        Task<ApiResponse<Constraint>> PutConstraintAsync(long flagID, long segmentID, long constraintID, CreateConstraintRequest body);
    }
}
