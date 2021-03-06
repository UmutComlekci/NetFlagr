using NetFlagr.Model;
using System.Threading.Tasks;

namespace NetFlagr
{
    /// <summary>
    /// Represents a collection of Flagr Evaluation functions to interact with the API endpoints
    /// </summary>
    internal class EvaluationApiService : IEvaluationApiService
    {
        private readonly NetFlagrHttpClient _httpClient;

        public EvaluationApiService(NetFlagrHttpClient httpClient)
        {
            _httpClient = httpClient;
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

            return await _httpClient.PostAsync("evaluation").WithBody((x) => x.Model(body)).AsApiResponse<EvalResult>();
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

            return await _httpClient.PostAsync("evaluation/batch").WithBody((x) => x.Model(body)).AsApiResponse<EvaluationBatchResponse>();
        }
    }
}
