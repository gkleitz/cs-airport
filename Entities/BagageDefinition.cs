using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Pim.Entities
{
    public class BagageDefinition
    {
        public int IdBagage { get; set; }
        public string CodeIata { get; set; }
        public string Compagnie { get; set; }
        public int Ligne { get; set; }
        public char LigneAlpha { get; set; }
        public DateTime DateCreation { get; set; }
        public string Itineraire { get; set; }
        public char ClasseBagage { get; set; }
        public bool Continuation { get; set; }
        public bool Rush { get; set; }

        public override string ToString()
        {
            return IdBagage.ToString() + CodeIata + Compagnie + Ligne.ToString() + DateCreation.ToString();
            //return base.ToString();
        }
    }
}
