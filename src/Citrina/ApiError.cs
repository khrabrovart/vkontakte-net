using System.Collections.Generic;

namespace Citrina
{
    /// <summary>
    /// Represents an error returned after the request to the VK API.
    /// </summary>
    public class ApiError
    {
        internal ApiError(int? code, string message, Dictionary<string, string> parameters)
        {
            Code = code;
            Message = message;
            RequestParameters = parameters;
        }

        internal ApiError(string message)
        {
            Message = message;
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
        /// Gets the request parameters that the VK actually received.
        /// </summary>
        public Dictionary<string, string> RequestParameters { get; }
    }
}