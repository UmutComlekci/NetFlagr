using NetFlagr.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Flag functions to interact with the API endpoints
    /// </summary>
    internal class FlagApiService : IFlagApiService
    {
        private readonly NetFlagrHttpClient _httpClient;

        public FlagApiService(NetFlagrHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">create a flag</param>
        /// <returns>Task of ApiResponse (Flag)</returns>
        public async Task<ApiResponse<Flag>> CreateFlagAsync(CreateFlagRequest body)
        {
            if (body == null)
            {
                throw new ApiException(400, "Missing required parameter 'body' when calling FlagApi->CreateFlag");
            }

            return await _httpClient.PostAsync("flags").WithBody((x) => x.Model(body)).AsApiResponse<Flag>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<object>> DeleteFlagAsync(long flagID)
        {
            return await _httpClient.DeleteAsync($"flags/{flagID}").AsApiResponse<object>();
        }

        /// <summary>
        /// </summary>
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
        public async Task<ApiResponse<IEnumerable<Flag>>> FindFlagsAsync(long? limit = null, bool? enabled = null, string description = null, string tags = null, string descriptionLike = null, string key = null, long? offset = null, bool? preload = null, bool? deleted = null)
        {
            var request = _httpClient.GetAsync("flags");
            if (limit != null)
            {
                request = request.WithArgument("limit", limit);
            }

            if (enabled != null)
            {
                request = request.WithArgument("enabled", enabled);
            }

            if (description != null)
            {
                request = request.WithArgument("description", description);
            }

            if (tags != null)
            {
                request = request.WithArgument("tags", tags);
            }

            if (descriptionLike != null)
            {
                request = request.WithArgument("description_like", descriptionLike);
            }

            if (key != null)
            {
                request = request.WithArgument("key", key);
            }

            if (offset != null)
            {
                request = request.WithArgument("offset", offset);
            }

            if (preload != null)
            {
                request = request.WithArgument("preload", preload);
            }

            if (deleted != null)
            {
                request = request.WithArgument("deleted", deleted);
            }

            return await request.AsApiResponse<IEnumerable<Flag>>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag to get</param>
        /// <returns>Task of ApiResponse (Flag)</returns>
        public async Task<ApiResponse<Flag>> GetFlagAsync(long flagID)
        {
            return await _httpClient.GetAsync($"flags/{flagID}").AsApiResponse<Flag>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async Task<ApiResponse<IEnumerable<string>>> GetFlagEntityTypesAsync()
        {
            return await _httpClient.GetAsync("flags/entity_types").AsApiResponse<IEnumerable<string>>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag to get</param>
        /// <returns>Task of ApiResponse (List&lt;FlagSnapshot&gt;)</returns>
        public async Task<ApiResponse<IEnumerable<FlagSnapshot>>> GetFlagSnapshotsAsync(long flagID)
        {
            return await _httpClient.GetAsync($"flags/{flagID}/snapshots").AsApiResponse<IEnumerable<FlagSnapshot>>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag to get</param>
        /// <param name="body">update a flag</param>
        /// <returns>Task of ApiResponse (Flag)</returns>
        public async Task<ApiResponse<Flag>> PutFlagAsync(long flagID, PutFlagRequest body)
        {
            if (body == null)
            {
                throw new ApiException(400, "Missing required parameter 'body' when calling FlagApi->PutFlag");
            }

            return await _httpClient.PutAsync($"flags/{flagID}").WithBody((x) => x.Model(body)).AsApiResponse<Flag>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag to get</param>
        /// <returns>Task of ApiResponse (Flag)</returns>
        public async Task<ApiResponse<Flag>> RestoreFlagAsync(long flagID)
        {
            return await _httpClient.PutAsync($"flags/{flagID}/restore").AsApiResponse<Flag>();
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag to get</param>
        /// <param name="body">set flag enabled state</param>
        /// <returns>Task of ApiResponse (Flag)</returns>
        public async Task<ApiResponse<Flag>> SetFlagEnabledAsync(long flagID, SetFlagEnabledRequest body)
        {
            if (body == null)
            {
                throw new ApiException(400, "Missing required parameter 'body' when calling FlagApi->SetFlagEnabled");
            }

            return await _httpClient.PutAsync($"flags/{flagID}/enabled").WithBody((x) => x.Model(body)).AsApiResponse<Flag>();
        }
    }
}
