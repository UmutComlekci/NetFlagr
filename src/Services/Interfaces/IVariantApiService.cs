using NetFlagr.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Variant functions to interact with the API endpoints
    /// </summary>
    public interface IVariantApiService
    {
        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="body">create a variant</param>
        /// <returns>Task of ApiResponse (Variant)</returns>
        Task<ApiResponse<Variant>> CreateVariantAsync(long flagID, CreateVariantRequest body);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="variantID">numeric ID of the variant</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> DeleteVariantAsync(long flagID, long variantID);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <returns>Task of ApiResponse (List&lt;Variant&gt;)</returns>
        Task<ApiResponse<IEnumerable<Variant>>> FindVariantsAsync(long flagID);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="variantID">numeric ID of the variant</param>
        /// <param name="body">update a variant</param>
        /// <returns>Task of ApiResponse (Variant)</returns>
        Task<ApiResponse<Variant>> PutVariantAsync(long flagID, long variantID, PutVariantRequest body);
    }
}
