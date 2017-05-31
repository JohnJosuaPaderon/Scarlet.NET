using Scarlet.Entities;
using System.Runtime.Serialization;

namespace Scarlet.Security.Entities
{
    [DataContract]
    public class User : Entity<ulong>
    {
        [DataMember]
        public ulong Id { get; set; }

        [DataMember]
        public bool Active { get; set; }
    }
}
