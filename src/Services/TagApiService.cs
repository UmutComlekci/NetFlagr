using NetFlagr.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Tag functions to interact with the API endpoints
    /// </summary>
    internal class TagApiService : ITagApiService
    {
        private readonly NetFlagrHttpClient _httpClient;

        public TagApiService(NetFlagrHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="body">create a tag</param>
        /// <returns>Task of ApiResponse (Tag)</returns>
        public async Task<ApiResponse<Tag>> CreateTagAsync(long flagID, CreateTagRequest body)
        {
            if (body == null)
            {
                throw new ApiException(400, "Missing required parameter 'body' when calling TagApi->CreateTag");
            }

            return await _httpClient.PostAsync($"flags/{flagID}/tags").WithBody((x) => x.Model(body)).AsApiResponse<Tag>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="tagID">numeric ID of the tag</param>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<object>> DeleteTagAsync(long flagID, long tagID)
        {
            return await _httpClient.DeleteAsync($"flags/{flagID}/tags/{tagID}").AsApiResponse<object>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">the numbers of tags to return (optional)</param>
        /// <param name="offset">return tags given the offset, it should usually set together with limit (optional)</param>
        /// <param name="valueLike">return tags partially matching given value (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Tag&gt;)</returns>
        public async Task<ApiResponse<IEnumerable<Tag>>> FindAllTagsAsync(long? limit = null, long? offset = null, string valueLike = null)
        {
            var request = _httpClient.GetAsync("tags");
            if (limit != null)
            {
                request = request.WithArgument("limit", limit);
            }

            if (offset != null)
            {
                request = request.WithArgument("offset", offset);
            }

            if (valueLike != null)
            {
                request = request.WithArgument("value_like", valueLike);
            }

            return await request.AsApiResponse<IEnumerable<Tag>>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <returns>Task of ApiResponse (List&lt;Tag&gt;)</returns>
        public async Task<ApiResponse<IEnumerable<Tag>>> FindTagsAsync(long flagID)
        {
            return await _httpClient.GetAsync($"flags/{flagID}/tags").AsApiResponse<IEnumerable<Tag>>();
        }
    }
}
