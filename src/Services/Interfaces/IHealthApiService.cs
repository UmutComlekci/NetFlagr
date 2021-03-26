using NetFlagr.Model;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Health functions to interact with the API endpoints
    /// </summary>
    public interface IHealthApiService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Check if Flagr is healthy
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Health)</returns>
        Task<ApiResponse<Health>> GetHealthAsync();
    }
}
