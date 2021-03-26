using NetFlagr.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Flag functions to interact with the API endpoints
    /// </summary>
    public interface IFlagApiService
    {
        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">create a flag</param>
        /// <returns>Task of ApiResponse (Flag)</returns>
        Task<ApiResponse<Flag>> CreateFlagAsync(CreateFlagRequest body);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> DeleteFlagAsync(long flagID);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">the numbers of flags to return (optional)</param>
        /// <param name="enabled">return flags having given enabled status (optional)</param>
        /// <param name="description">return flags exactly matching given description (optional)</param>
        /// <param name="tags">return flags with the given tags (comma separated) (optional)</param>
        /// <param name="descriptionLike">return flags partially matching given description (optional)</param>
        /// <param name="key">return flags matching given key (optional)</param>
        /// <param name="offset">return flags given the offset, it should usually set together with limit (optional)</param>
        /// <param name="preload">return flags with preloaded segments and variants (optional)</param>
        /// <param name="deleted">return all deleted flags (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Flag&gt;)</returns>
        Task<ApiResponse<IEnumerable<Flag>>> FindFlagsAsync(long? limit = null, bool? enabled = null, string description = null, string tags = null, string descriptionLike = null, string key = null, long? offset = null, bool? preload = null, bool? deleted = null);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag to get</param>
        /// <returns>Task of ApiResponse (Flag)</returns>
        Task<ApiResponse<Flag>> GetFlagAsync(long flagID);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        Task<ApiResponse<IEnumerable<string>>> GetFlagEntityTypesAsync();

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag to get</param>
        /// <returns>Task of ApiResponse (List&lt;FlagSnapshot&gt;)</returns>
        Task<ApiResponse<IEnumerable<FlagSnapshot>>> GetFlagSnapshotsAsync(long flagID);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag to get</param>
        /// <param name="body">update a flag</param>
        /// <returns>Task of ApiResponse (Flag)</returns>
        Task<ApiResponse<Flag>> PutFlagAsync(long flagID, PutFlagRequest body);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag to get</param>
        /// <returns>Task of ApiResponse (Flag)</returns>
        Task<ApiResponse<Flag>> RestoreFlagAsync(long flagID);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag to get</param>
        /// <param name="body">set flag enabled state</param>
        /// <returns>Task of ApiResponse (Flag)</returns>
        Task<ApiResponse<Flag>> SetFlagEnabledAsync(long flagID, SetFlagEnabledRequest body);
    }
}
