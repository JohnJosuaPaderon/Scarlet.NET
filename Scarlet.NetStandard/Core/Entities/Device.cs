using Scarlet.Entities;
using System.Runtime.Serialization;

namespace Scarlet.Core.Entities
{
    [DataContract]
    public class Device : Entity<ulong>
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DeviceType Type { get; set; }

        [DataMember]
        public MACAddress MACAddress { get; set; }

        [DataMember]
        public IPv4Address IPv4Address { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
