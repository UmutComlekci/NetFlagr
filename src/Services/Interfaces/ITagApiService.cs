using NetFlagr.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Tag functions to interact with the API endpoints
    /// </summary>
    public interface ITagApiService
    {
        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="body">create a tag</param>
        /// <returns>Task of ApiResponse (Tag)</returns>
        Task<ApiResponse<Tag>> CreateTagAsync(long flagID, CreateTagRequest body);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <param name="tagID">numeric ID of the tag</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> DeleteTagAsync(long flagID, long tagID);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">the numbers of tags to return (optional)</param>
        /// <param name="offset">return tags given the offset, it should usually set together with limit (optional)</param>
        /// <param name="valueLike">return tags partially matching given value (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Tag&gt;)</returns>
        Task<ApiResponse<IEnumerable<Tag>>> FindAllTagsAsync(long? limit = null, long? offset = null, string valueLike = null);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="flagID">numeric ID of the flag</param>
        /// <returns>Task of ApiResponse (List&lt;Tag&gt;)</returns>
        Task<ApiResponse<IEnumerable<Tag>>> FindTagsAsync(long flagID);
    }
}
