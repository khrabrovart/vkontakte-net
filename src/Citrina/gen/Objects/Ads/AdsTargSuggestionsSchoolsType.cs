using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// School type.
    /// </summary>
    public enum AdsTargSuggestionsSchoolsType
    {
        [EnumMember(Value = "school")]
        School,
        [EnumMember(Value = "university")]
        University,
        [EnumMember(Value = "faculty")]
        Faculty,
        [EnumMember(Value = "chair")]
        Chair,
    }
}
