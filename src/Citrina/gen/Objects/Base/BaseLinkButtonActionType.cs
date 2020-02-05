using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Action type.
    /// </summary>
    public enum BaseLinkButtonActionType
    {
        [EnumMember(Value = "open_url")]
        OpenUrl,
    }
}
