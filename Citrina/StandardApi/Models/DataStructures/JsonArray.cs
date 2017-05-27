using System.Collections.Generic;
using Newtonsoft.Json;

namespace Citrina.StandardApi.Models
{
    public class JsonArray
    {
        public string JsonValue { get; }

        public JsonArray(IEnumerable<string> values)
        {
            JsonValue = JsonConvert.SerializeObject(values, Formatting.Indented);
        }

        public JsonArray(params string[] values)
        {
            JsonValue = JsonConvert.SerializeObject(values, Formatting.Indented);
        }

        public static implicit operator JsonArray(string[] values)
        {
            return new JsonArray(values);
        }
    }
}
