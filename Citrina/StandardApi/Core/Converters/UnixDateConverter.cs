using System;
using System.Globalization;
using Newtonsoft.Json;

namespace Citrina.StandardApi.Core.Converters
{
    internal class UnixDateConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var time = (DateTime) value;
            writer.WriteValue((int)time.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            ulong unixTime;
            DateTime strTime;

            // For StartDate in Group model
            if (DateTime.TryParseExact(reader.Value.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out strTime))
            {
                return strTime;
            }

            if (ulong.TryParse(reader.Value.ToString(), out unixTime))
            {
                return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTime).ToLocalTime();
            }

            if (DateTime.TryParse(reader.Value.ToString(), out strTime))
            {
                return strTime;
            }

            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime) || objectType == typeof(DateTime?);
        }

        public override bool CanWrite => true;
    }
}