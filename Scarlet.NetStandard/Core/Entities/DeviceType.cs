using System;

namespace Scarlet.Core.Entities
{
    [Flags]
    public enum DeviceType
    {
        NotSet = 0,
        Mobile = 1,
        Laptop = 2,
        Desktop = 4
    }
}
