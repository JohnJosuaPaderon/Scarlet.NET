using System.Runtime.Serialization;
using System.Security;

namespace Scarlet.Security.Entities
{
    [DataContract]
    public class UserLoginCredentials
    {
        [DataMember]
        public SecureString SecureUserName { get; set; }

        [DataMember]
        public SecureString SecurePassword { get; set; }
    }
}
