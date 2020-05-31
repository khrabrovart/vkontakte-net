using System;
using Citrina.Json.ContractResolvers;
using Citrina.Json.Converters;
using Newtonsoft.Json;

namespace Citrina.Json
{
    /// <summary>
    /// Provides methods for converting VK API response JSON to CLR objects.
    /// </summary>
    public static class CitrinaJsonConverter
    {
        private static readonly JsonSerializerSettings DeserializerSettings = new JsonSerializerSettings
        {
            Converters =
            {
                new UnixDateConverter(),
                new BooleanConverter(),
                new NumberConverter(),
            },
            ContractResolver = new SnakeCaseContractResolver(),
            Error = (a,b) => b.ErrorContext.Handled = true,
        };

        public static T Deserialize<T>(string data)
        {
            return (T) JsonConvert.DeserializeObject(data, typeof(T), DeserializerSettings);
        }

        public static object Deserialize(string data, Type type)
        {
            return JsonConvert.DeserializeObject(data, type, DeserializerSettings);
        }
    }
}
