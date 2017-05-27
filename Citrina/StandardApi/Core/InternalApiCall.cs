using System;
using System.Collections.Generic;
using Citrina.StandardApi.Models;

namespace Citrina.StandardApi.Core
{
    internal class InternalApiCall<TRequest, TResponse>
        where TRequest : IRequestModel
    {
        public DateTime CreatedOn { get; } = DateTime.Now;
        public TimeSpan ExecutionTime { get; set; }
        public bool IsCustom { get; set; }
        public bool IsError { get; set; }
        public ApiCallError Error { get; set; }
        public string Method { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
        public Type RequestType { get; set; }
        public Type ResponseType { get; set; }

        public TRequest Request { get; set; }
        public TResponse Response { get; set; }
    }
}
