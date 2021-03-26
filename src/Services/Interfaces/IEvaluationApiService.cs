using NetFlagr.Model;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Evaluation functions to interact with the API endpoints
    /// </summary>
    public interface IEvaluationApiService
    {
        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evalution context</param>
        /// <returns>Task of ApiResponse (EvalResult)</returns>
        Task<ApiResponse<EvalResult>> PostEvaluationAsync(EvalContext body);

        /// <summary></summary>
        /// <remarks></remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evalution batch request</param>
        /// <returns>Task of ApiResponse (EvaluationBatchResponse)</returns>
        Task<ApiResponse<EvaluationBatchResponse>> PostEvaluationBatchAsync(EvaluationBatchRequest body);
    }
}
