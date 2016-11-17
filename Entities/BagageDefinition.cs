using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Pim.Entities
{
    [DataContract]
    public class BagageDefinition
    {
        [DataMember]
        public int IdBagage { get; set; }
        [DataMember]
        public string CodeIata { get; set; }
        [DataMember]
        public string Compagnie { get; set; }
        [DataMember]
        public int Ligne { get; set; }
        [DataMember]
        public char LigneAlpha { get; set; }
        [DataMember]
        public DateTime DateCreation { get; set; }
        [DataMember]
        public string Itineraire { get; set; }
        [DataMember]
        public char ClasseBagage { get; set; }
        [DataMember]
        public bool Continuation { get; set; }
        [DataMember]
        public bool Rush { get; set; }

        public override string ToString()
        {
            return IdBagage.ToString() + CodeIata + Compagnie + Ligne.ToString() + DateCreation.ToString();
            //return base.ToString();
        }
    }
}
