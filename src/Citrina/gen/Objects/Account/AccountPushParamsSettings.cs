using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Settings parameters.
    /// </summary>
    public enum AccountPushParamsSettings
    {
        [EnumMember(Value = "on")]
        On,
        [EnumMember(Value = "off")]
        Off,
        [EnumMember(Value = "fr_of_fr")]
        FrOfFr,
    }
}
