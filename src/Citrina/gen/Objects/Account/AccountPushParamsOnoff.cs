using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Settings parameters.
    /// </summary>
    public enum AccountPushParamsOnoff
    {
        [EnumMember(Value = "on")]
        On,
        [EnumMember(Value = "off")]
        Off,
    }
}
