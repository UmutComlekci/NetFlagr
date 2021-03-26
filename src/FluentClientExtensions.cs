using Newtonsoft.Json;
using Pathoschild.Http.Client;
using System.Linq;
using System.Threading.Tasks;

namespace NetFlagr
{
    public static class FluentClientExtensions
    {
        public static async Task<ApiResponse<T>> AsApiResponse<T>(this IRequest request)
        {
            IResponse response = await request.AsResponse().ConfigureAwait(false);
            if (response.IsSuccessStatusCode == false)
            {
                return new ApiResponse<T>()
                {
                    StatusCode = (int)response.Status,
                    Headers = response.Message.Headers.ToDictionary(x => x.Key, x => x.Value.FirstOrDefault()),
                };
            }

            string responseString = await response.AsString();
            return new ApiResponse<T>()
            {
                Data = JsonConvert.DeserializeObject<T>(responseString),
                StatusCode = (int)response.Status,
                Headers = response.Message.Headers.ToDictionary(x => x.Key, x => x.Value.FirstOrDefault()),
            };
        }

        public static async Task<ApiResponse<T>> AsApiResponse<T>(this IResponse response)
        {
            string responseString = await response.AsString();
            return new ApiResponse<T>()
            {
                Data = JsonConvert.DeserializeObject<T>(responseString),
                StatusCode = (int)response.Status,
                Headers = response.Message.Headers.ToDictionary(x => x.Key, x => x.Value.FirstOrDefault()),
            };
        }
    }
}
