using System;

namespace Citrina
{
    [Flags]
    public enum GroupPermissions
    {
        Photos = 4,
        Messages = 4096,
        Docs = 131072,
        Manage = 262144
    }
}
