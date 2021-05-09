using System.IO;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Export functions to interact with the API endpoints
    /// </summary>
    internal class ExportApiService : IExportApiService
    {
        private readonly NetFlagrHttpClient _httpClient;

        public ExportApiService(NetFlagrHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        ///  Export JSON format of the eval cache dump
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (object)</returns>
        public async Task<ApiResponse<object>> GetExportEvalCacheJSONAsync()
        {
            return await _httpClient.GetAsync("export/eval_cache/json").AsApiResponse<object>();
        }

        /// <summary>
        ///  Export sqlite3 format of the db dump, which is converted from the main database.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="excludeSnapshots">export without snapshots data - useful for smaller db without snapshots  (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async Task<ApiResponse<Stream>> GetExportSqliteAsync(bool? excludeSnapshots = null)
        {
            var request = _httpClient.GetAsync("export/sqlite");
            if (excludeSnapshots != null)
            {
                request = request.WithArgument("exclude_snapshots", excludeSnapshots);
            }

            return await request.AsApiResponse<Stream>();
        }
    }
}
