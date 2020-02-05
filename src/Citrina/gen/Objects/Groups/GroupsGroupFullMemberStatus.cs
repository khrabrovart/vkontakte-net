using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public enum GroupsGroupFullMemberStatus
    {
        NotAMember,
        Member,
        NotSure,
        Declined,
        HasSentARequest,
        Invited,
    }
}
