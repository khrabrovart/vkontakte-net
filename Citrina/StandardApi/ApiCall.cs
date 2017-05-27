using System;
using System.Collections.Generic;
using Citrina.StandardApi.Models;

namespace Citrina.StandardApi
{
    /// <summary>
    /// Represents a call to the VK API.
    /// </summary>
    /// <typeparam name="TRequest">Call request type.</typeparam>
    /// <typeparam name="TResponse">Call response type.</typeparam>
    public class ApiCall<TRequest, TResponse>
        where TRequest : IRequestModel
    {
        internal ApiCall(
            string method, 
            Dictionary<string, string> parameters, 
            DateTime createdOn, 
            TimeSpan executionTime, 
            bool isCustom, 
            bool isError, 
            ApiCallError error,
            TRequest request,
            TResponse response)
        {
            CreatedOn = createdOn;
            ExecutionTime = executionTime;
            IsCustom = isCustom;
            IsError = isError;
            Error = error;
            Method = method;
            Parameters = parameters;
            Request = request;
            Response = response;
        }

        /// <summary>
        /// Gets the call cteation time.
        /// </summary>
        public DateTime CreatedOn { get; }

        /// <summary>
        /// Gets the call execution time.
        /// </summary>
        public TimeSpan ExecutionTime { get;}

        /// <summary>
        /// Indicates whether the call method is custom method (e.g. execute.myCustomMethod).
        /// </summary>
        public bool IsCustom { get; }

        /// <summary>
        /// Indicates whether the call has returned with error.
        /// </summary>
        public bool IsError { get; }

        /// <summary>
        /// Gets error if exists.
        /// </summary>
        public ApiCallError Error { get; }

        /// <summary>
        /// Gets the call method name.
        /// </summary>
        public string Method { get; }

        /// <summary>
        /// Gets the call actual parameters.
        /// </summary>
        public Dictionary<string, string> Parameters { get; }

        /// <summary>
        /// Gets the call request.
        /// </summary>
        public TRequest Request { get; }

        /// <summary>
        /// Gets the call response.
        /// </summary>
        public TResponse Response { get; }
    }
}