using System;
using Newtonsoft.Json;

namespace Citrina.StandardApi.Core.Converters
{
    internal class BooleanConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var val = value as bool?;

            if (val != null)
            {
                writer.WriteValue(val.Value ? 1 : 0);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return reader.Value.ToString() == "1";
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof (bool) || objectType == typeof (bool?);
        }
    }
}