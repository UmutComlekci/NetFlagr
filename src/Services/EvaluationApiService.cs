using NetFlagr.Model;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Evaluation functions to interact with the API endpoints
    /// </summary>
    internal class EvaluationApiService : IEvaluationApiService
    {
        private readonly NetFlagrApiClient _apiClient;

        public EvaluationApiService(NetFlagrApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evalution batch request</param>
        /// <returns>Task of ApiResponse (EvaluationBatchResponse)</returns>
        public async Task<ApiResponse<EvalResult>> PostEvaluationAsync(EvalContext body)
        {
            if (body == null)
            {
                throw new ApiException(400, "Missing required parameter 'body' when calling EvaluationApi->PostEvaluationBatch");
            }

            return await _apiClient.PostAsync("evaluation").WithBody((x) => x.Model(body)).AsApiResponse<EvalResult>();
        }

        /// <summary>
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evalution batch request</param>
        /// <returns>Task of ApiResponse (EvaluationBatchResponse)</returns>
        public async Task<ApiResponse<EvaluationBatchResponse>> PostEvaluationBatchAsync(EvaluationBatchRequest body)
        {
            if (body == null)
            {
                throw new ApiException(400, "Missing required parameter 'body' when calling EvaluationApi->PostEvaluationBatch");
            }

            return await _apiClient.PostAsync("evaluation/batch").WithBody((x) => x.Model(body)).AsApiResponse<EvaluationBatchResponse>();
        }
    }
}
