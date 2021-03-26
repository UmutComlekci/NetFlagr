using System.Collections.Generic;

namespace NetFlagr
{
    /// <summary>
    /// Represents a set of configuration settings
    /// </summary>
    public class NetFlagrConfiguration
    {
        /// <summary>
        /// Gets the DefaultHeader
        /// </summary>
        public IDictionary<string, string> DefaultHeader { get; set; }

        /// <summary>
        /// Gets the base path for API access.
        /// </summary>
        public string BasePath { get; set; }

        /// <summary>
        /// Gets the HTTP timeout (milliseconds) of ApiClient. Default to 100000 milliseconds.
        /// </summary>
        public int Timeout { get; set; } = 100000;

        /// <summary>
        /// Gets the HTTP user agent.
        /// </summary>
        /// <value>Http user agent.</value>
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets the username (HTTP basic authentication).
        /// </summary>
        /// <value>The username.</value>
        public string Username { get; set; }

        /// <summary>
        /// Gets the password (HTTP basic authentication).
        /// </summary>
        /// <value>The password.</value>
        public string Password { get; set; }
    }
}
