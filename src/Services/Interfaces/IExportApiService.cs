using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Export functions to interact with the API endpoints
    /// </summary>
    public interface IExportApiService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Export JSON format of the eval cache dump
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (object)</returns>
        Task<ApiResponse<object>> GetExportEvalCacheJSONAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Export sqlite3 format of the db dump, which is converted from the main database.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="excludeSnapshots">export without snapshots data - useful for smaller db without snapshots  (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        Task<ApiResponse<System.IO.Stream>> GetExportSqliteAsync(bool? excludeSnapshots = null);
    }
}
