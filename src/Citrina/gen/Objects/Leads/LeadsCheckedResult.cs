using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Information whether user can start the lead.
    /// </summary>
    public enum LeadsCheckedResult
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False,
    }
}
