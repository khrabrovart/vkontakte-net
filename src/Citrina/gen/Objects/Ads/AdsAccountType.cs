using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Account type.
    /// </summary>
    public enum AdsAccountType
    {
        [EnumMember(Value = "general")]
        General,
        [EnumMember(Value = "agency")]
        Agency,
    }
}
