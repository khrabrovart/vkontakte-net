using System;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Citrina.StandardApi.Core.Converters
{
    internal class AccessTokenConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((IAccessToken) value).Value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IAccessToken) || objectType.GetTypeInfo().ImplementedInterfaces.Contains(typeof(IAccessToken));
        }
    }
}