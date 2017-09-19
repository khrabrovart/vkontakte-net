using System;
using Citrina.Json.ContractResolvers;
using Citrina.Json.Converters;
using Newtonsoft.Json;

namespace Citrina.Json
{
    public static class CitrinaJsonConverter
    {
        private static readonly JsonSerializerSettings DeserializerSettings = new JsonSerializerSettings
        {
            Converters =
            {
                new UnixDateConverter(),
                new BooleanConverter()
            },
            ContractResolver = new SnakeCaseContractResolver()
        };

        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            Converters =
            {
                new BooleanConverter(),
                new UnixDateConverter(),
                new AccessTokenConverter(),
                new JsonArrayConverter(),
                new EnumerableConverter()
            },
            ContractResolver = new SnakeCaseContractResolver()
        };

        public static T Deserialize<T>(string data)
        {
            return (T) JsonConvert.DeserializeObject(data, typeof(T), DeserializerSettings);
        }

        public static object Deserialize(string data, Type type)
        {
            return JsonConvert.DeserializeObject(data, type, DeserializerSettings);
        }

        public static string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.None, SerializerSettings);
        }

        public static T Serialize<T>(object obj)
        {
            var jsonRequest = JsonConvert.SerializeObject(obj, Formatting.None, SerializerSettings);
            return JsonConvert.DeserializeObject<T>(jsonRequest);
        } 
    }
}
