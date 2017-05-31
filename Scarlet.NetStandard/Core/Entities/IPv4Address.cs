using System.Runtime.Serialization;

namespace Scarlet.Core.Entities
{
    [DataContract]
    public class IPv4Address
    {
        [DataMember]
        public byte Class1 { get; set; }

        [DataMember]
        public byte Class2 { get; set; }

        [DataMember]
        public byte Class3 { get; set; }

        [DataMember]
        public byte Class4 { get; set; }

        public static bool operator ==(IPv4Address left, IPv4Address right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IPv4Address left, IPv4Address right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            var value = obj as IPv4Address;
            return
                Class1 == value.Class1 &&
                Class2 == value.Class2 &&
                Class3 == value.Class3 &&
                Class4 == value.Class4;
        }

        public override int GetHashCode()
        {
            return
                Class1.GetHashCode() ^
                Class2.GetHashCode() ^
                Class3.GetHashCode() ^
                Class4.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
