using System.Text.RegularExpressions;
using Newtonsoft.Json.Serialization;

namespace Citrina.StandardApi.Core
{
    internal class DelimiterContractResolver : DefaultContractResolver
    {
        private readonly string _separator;

        protected DelimiterContractResolver(char separator)
        {
            _separator = separator.ToString();
        }

        protected override string ResolvePropertyName(string propertyName)
        {
            return Regex.Replace(propertyName, @"(.)([A-Z]|\d+)", $"$1{_separator}$2").ToLower();
        }
    }
}