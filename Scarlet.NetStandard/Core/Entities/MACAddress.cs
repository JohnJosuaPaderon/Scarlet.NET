using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Scarlet.Core.Entities
{
    [DataContract]
    public class MACAddress
    {
        [DataMember]
        public byte Block1 { get; set; }

        [DataMember]
        public byte Block2 { get; set; }

        [DataMember]
        public byte Block3 { get; set; }

        [DataMember]
        public byte Block4 { get; set; }

        [DataMember]
        public byte Block5 { get; set; }

        [DataMember]
        public byte Block6 { get; set; }

        [DataMember]
        public byte Block7 { get; set; }

        [DataMember]
        public byte Block8 { get; set; }

    }
}
