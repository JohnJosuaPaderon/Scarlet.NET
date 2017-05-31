using Scarlet.Entities;
using System.Runtime.Serialization;

namespace Scarlet.Core.Entities
{
    [DataContract]
    public class SystemModuleCode : Entity<uint>
    {
        [DataMember]
        public uint Series { get; set; }

        [DataMember]
        public uint Year { get; set; }

        public override string ToString()
        {
            return $"{Series.ToString(Configuration.SystemModuleCodeSeriesFormat)}-{Year.ToString("####")}";
        }
    }
}
