using System;
using System.Globalization;
using Newtonsoft.Json;

namespace Citrina.Json.Converters
{
    internal class UnixDateConverter : JsonConverter
    {
        private const string GroupStartDateFormat = "yyyyMMdd";

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // For StartDate in Group model
            if (DateTime.TryParseExact(reader.Value.ToString(), GroupStartDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate))
            {
                return startDate;
            }

            if (ulong.TryParse(reader.Value.ToString(), out ulong unixTime))
            {
                return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTime).ToLocalTime();
            }

            if (DateTime.TryParse(reader.Value.ToString(), out DateTime strTime))
            {
                return strTime;
            }

            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime) || objectType == typeof(DateTime?);
        }
    }
}