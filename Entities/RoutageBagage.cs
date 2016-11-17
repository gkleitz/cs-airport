using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Pim.Entities
{
    [DataContract]
    public class RoutageBagage
    {
        [DataMember]
        public int LocalisationEjection { get; set; }
        [DataMember]
        public string NomEjection { get; set; }
        [DataMember]
        public string StatutEjection { get; set; }
        [DataMember]
        public int LocalisationSureteN1 { get; set; }
        [DataMember]
        public string NomSureteN1 { get; set; }
        [DataMember]
        public int LocalisationSureteN3 { get; set; }
        [DataMember]
        public string NomSureteN3 { get; set; }
    }
}
