using System;
using System.Collections.Generic;
using System.Globalization;

namespace Citrina
{
    internal static class RequestHelpers
    {
        public static string ParseDateTime(DateTime? value)
        {
            return value?.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds.ToString(CultureInfo.InvariantCulture);
        }

        public static string ParseBoolean(bool? value)
        {
            return value == true ? "1" : "0";
        }

        public static string ParseEnumerable<T>(IEnumerable<T> values)
        {
            return values != null ? string.Join(",", values) : null;
        }
    }
}
