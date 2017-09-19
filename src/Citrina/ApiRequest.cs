using System;
using System.Collections.Generic;

namespace Citrina
{
    /// <summary>
    /// Represents a request to the VK API.
    /// </summary>
    /// <typeparam name="TResponse">Request response type.</typeparam>
    public class ApiRequest<TResponse>
    {
        internal ApiRequest(
            string method,
            Dictionary<string, string> parameters,
            DateTime createdOn,
            ApiError error,
            TResponse response)
        {
            CreatedOn = createdOn;
            IsError = error != null;
            Error = error;
            Method = method;
            Parameters = parameters;
            Response = response;
        }

        /// <summary>
        /// Gets the request cteation time.
        /// </summary>
        public DateTime CreatedOn { get; }

        /// <summary>
        /// Indicates whether the request has returned with error.
        /// </summary>
        public bool IsError { get; }

        /// <summary>
        /// Gets error if exists.
        /// </summary>
        public ApiError Error { get; }

        /// <summary>
        /// Gets the request method name.
        /// </summary>
        public string Method { get; }

        /// <summary>
        /// Gets the request actual parameters.
        /// </summary>
        public Dictionary<string, string> Parameters { get; }

        /// <summary>
        /// Gets the request response.
        /// </summary>
        public TResponse Response { get; }
    }
}