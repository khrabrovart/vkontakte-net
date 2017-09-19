using System;

namespace Citrina
{
    internal static class RequestSettings
    {
        public static string ApiVersion { get; } = "5.67";
        public static TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(30);
    }
}
