using NetFlagr.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Variant functions to interact with the API endpoints
    /// </summary>
    internal class VariantApiService : IVariantApiService
    {
        private readonly NetFlagrHttpClient _httpClient;

        public VariantApiService(NetFlagrHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="body">create a variant</param>
        /// <returns>Task of ApiResponse (Variant)</returns>
        public async Task<ApiResponse<Variant>> CreateVariantAsync(long flagID, CreateVariantRequest body)
        {
            if (body == null)
            {
                throw new ApiException(400, "Missing required parameter 'body' when calling VariantApi->CreateVariant");
            }

            return await _httpClient.PostAsync($"flags/{flagID}/variants").WithBody((x) => x.Model(body)).AsApiResponse<Variant>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="variantID">numeric ID of the variant</param>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<object>> DeleteVariantAsync(long flagID, long variantID)
        {
            return await _httpClient.DeleteAsync($"flags/{flagID}/variants/{variantID}").AsApiResponse<object>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <returns>Task of ApiResponse (List&lt;Variant&gt;)</returns>
        public async Task<ApiResponse<IEnumerable<Variant>>> FindVariantsAsync(long flagID)
        {
            return await _httpClient.GetAsync($"flags/{flagID}/variants").AsApiResponse<IEnumerable<Variant>>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="variantID">numeric ID of the variant</param>
        /// <param name="body">update a variant</param>
        /// <returns>Task of ApiResponse (Variant)</returns>
        public async Task<ApiResponse<Variant>> PutVariantAsync(long flagID, long variantID, PutVariantRequest body)
        {
            if (body == null)
            {
                throw new ApiException(400, "Missing required parameter 'body' when calling VariantApi->PutVariant");
            }

            return await _httpClient.PutAsync($"flags/{flagID}/variants/{variantID}").WithBody((x) => x.Model(body)).AsApiResponse<Variant>();
        }
    }
}
