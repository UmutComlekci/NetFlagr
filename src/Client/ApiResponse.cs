using System;
using System.Collections.Generic;

namespace NetFlagr
{
    public abstract class ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the status code (HTTP status code)
        /// </summary>
        /// <value>The status code.</value>
        public int StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the HTTP headers
        /// </summary>
        /// <value>HTTP headers</value>
        public IDictionary<string, string> Headers { get; set; }
    }

    /// <summary>
    /// This class is used to create standard responses for AJAX requests.
    /// </summary>
    [Serializable]
    public class ApiResponse<TResult> : ApiResponseBase
    {
        /// <summary>
        /// The actual result object of AJAX request.
        /// It is set if <see cref="ApiResponseBase.StatusCode"/> is 200.
        /// </summary>
        public TResult Data { get; set; }
    }
}
