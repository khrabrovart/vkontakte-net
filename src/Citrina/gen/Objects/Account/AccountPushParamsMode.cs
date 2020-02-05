using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Settings parameters.
    /// </summary>
    public enum AccountPushParamsMode
    {
        [EnumMember(Value = "on")]
        On,
        [EnumMember(Value = "off")]
        Off,
        [EnumMember(Value = "no_sound")]
        NoSound,
        [EnumMember(Value = "no_text")]
        NoText,
    }
}
