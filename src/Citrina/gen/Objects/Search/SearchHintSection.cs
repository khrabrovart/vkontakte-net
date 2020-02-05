using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    /// <summary>
    /// Section title.
    /// </summary>
    public enum SearchHintSection
    {
        [EnumMember(Value = "groups")]
        Groups,
        [EnumMember(Value = "events")]
        Events,
        [EnumMember(Value = "publics")]
        Publics,
        [EnumMember(Value = "correspondents")]
        Correspondents,
        [EnumMember(Value = "people")]
        People,
        [EnumMember(Value = "friends")]
        Friends,
        [EnumMember(Value = "mutual_friends")]
        MutualFriends,
    }
}
