using Scarlet.Entities;
using System.Runtime.Serialization;

namespace Scarlet.Core.Entities
{
    [DataContract]
    public class SystemModule : Entity<uint>
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public SystemModuleCode Code { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
