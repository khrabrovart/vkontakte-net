using System.Collections.Generic;

namespace Citrina.StandardApi
{
    /// <summary>
    /// Represents an error returned after the call to the VK API.
    /// </summary>
    public class ApiCallError
    {
        internal ApiCallError(int? code, string message, Dictionary<string, string> parameters)
        {
            Code = code;
            Message = message;
            RequestParameters = parameters;
        }

        /// <summary>
        /// Gets the error code.
        /// </summary>
        public int? Code { get; }

        /// <summary>
        /// Gets the error message.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Gets the request parameters that the VK has actually received.
        /// </summary>
        public Dictionary<string, string> RequestParameters { get; }
    }
}