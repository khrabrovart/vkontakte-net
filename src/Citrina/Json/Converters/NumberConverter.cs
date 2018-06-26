using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;

namespace Citrina.Json.Converters
{
    internal class NumberConverter : JsonConverter
    {
        private static readonly CultureInfo invariantCulture = CultureInfo.InvariantCulture;
        private static readonly Type
                                        intType = typeof(int),
                                        intQType = typeof(int?),
                                        uintType = typeof(uint),
                                        uintQType = typeof(uint?),
                                        longType = typeof(long),
                                        longQType = typeof(long?),
                                        ulongType = typeof(ulong),
                                        ulongQType = typeof(ulong?),
                                        shortType = typeof(short),
                                        shortQType = typeof(short?),
                                        ushortType = typeof(ushort),
                                        ushortQType = typeof(ushort?),
                                        byteType = typeof(byte),
                                        byteQType = typeof(byte?),
                                        sbyteType = typeof(sbyte),
                                        sbyteQType = typeof(sbyte?);
        private static readonly HashSet<Type> types = new HashSet<Type>{
            intType, intQType, uintType, uintQType, longType, longQType,
            ulongType, ulongQType, shortType, shortQType, ushortType, ushortQType,
            byteType, byteQType, sbyteType, sbyteQType
        };
        private static readonly HashSet<Type> nulltypes = new HashSet<Type>{
            intQType, uintQType, longQType, ulongQType, shortQType, ushortQType, byteQType, sbyteQType,
        };

        private static readonly Dictionary<Type, Type> nullBase = new Dictionary<Type, Type>{
            { intQType, intType },
            { uintQType, uintType },
            { longQType, longType },
            { ulongQType, ulongType },
            { shortQType, shortType },
            { ushortQType, ushortType },
            { byteQType, byteType },
            { sbyteQType, sbyteType },
        };

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotImplementedException();

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    if (nulltypes.Contains(objectType))
                    {
                        return null;
                    }
                    throw new JsonSerializationException($"Unexpected null token for a non-nullable  field");
                case JsonToken.Integer:
                case JsonToken.Float:
                    return Convert.ChangeType(
                        reader.Value,
                        objectType = nullBase.ContainsKey(objectType) ? nullBase[objectType] : objectType
                    );
                case JsonToken.String:
                    if (!long.TryParse(reader.Value as string, NumberStyles.Any, invariantCulture, out var value))
                        if (!double.TryParse(reader.Value as string, NumberStyles.Any, invariantCulture, out var dvalue))
                            throw new FormatException($"Invalid input string: {reader.Value}");
                        else
                            value = (long)Convert.ChangeType(value, longType);
                    objectType = nullBase.ContainsKey(objectType) ? nullBase[objectType] : objectType;
                    if (objectType == longType)//short path
                        return value;
                    return Convert.ChangeType(value, objectType);
                default:
                    throw new JsonSerializationException($"Unexpected token type: {reader.TokenType}");
            }
        }

        public override bool CanConvert(Type objectType) => types.Contains(objectType);
        public override bool CanRead => true;
        public override bool CanWrite => false;
    }
}