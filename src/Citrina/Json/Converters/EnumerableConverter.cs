using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;

namespace Citrina.Json.Converters
{
    internal class EnumerableConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var stringValues = value as IEnumerable<string>;

            if (stringValues != null)
            {
                writer.WriteValue(string.Join(",", stringValues));
                return;
            }

            var intValues = value as IEnumerable<int>;

            if (intValues != null)
            {
                writer.WriteValue(string.Join(",", intValues));
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(IEnumerable<string>).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo()) ||
                typeof(IEnumerable<int>).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }
    }
}
