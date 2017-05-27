using System.Collections.Generic;
using Newtonsoft.Json;

namespace Citrina.StandardApi.Core
{
    internal class InternalApiCallError
    {
        [JsonProperty("error_code")]
        public int? Code { get; set; }

        [JsonProperty("error_msg")]
        public string Message { get; set; }

        [JsonProperty("request_params")]
        public IEnumerable<KeyValuePair<string, string>> RequestParameters { get; set; }
    }
}
