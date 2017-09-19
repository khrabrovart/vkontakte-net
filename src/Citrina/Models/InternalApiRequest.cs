using System;
using System.Collections.Generic;

namespace Citrina.Models
{
    internal class InternalApiRequest<TResponse>
    {
        public DateTime CreatedOn { get; } = DateTime.Now;
        public IAccessToken AccessToken { get; set; }
        public ApiError Error { get; set; }
        public string Method { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
        public TResponse Response { get; set; }
    }
}
