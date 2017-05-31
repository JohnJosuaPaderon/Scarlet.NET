using System;
using System.Runtime.Serialization;

namespace Scarlet.Core.Entities
{
    [DataContract]
    public class IPv4Address
    {
        static void Sample()
        {
            var ipv4Address = new IPv4Address();
            string x = ipv4Address;
        }

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

        public static implicit operator string(IPv4Address arg)
        {
            if (arg == null) return null;

            return $"{arg.Class1}.{arg.Class2}.{arg.Class3}.{arg.Class4}";
        }

        public static implicit operator IPv4Address(string arg)
        {
            if (string.IsNullOrWhiteSpace(arg)) return null;

            var splitted = "";

            return new IPv4Address()
            {

            };
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
