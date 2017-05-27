using System;

namespace Citrina.StandardApi
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ApiVersionAttribute : Attribute
    {
        public string Value { get; }

        public ApiVersionAttribute(string version)
        {
            Value = version;
        }
    }
}
