using MyAirport.Pim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Pim.Model
{
    public class Natif: AbstractDefinition
    {
        private List<BagageDefinition> listeBagage;

        public Natif()
        {
            listeBagage = new List<BagageDefinition>();
            listeBagage.Add(new BagageDefinition
            {
                IdBagage = 123456,
                Compagnie = "aa",
                Ligne = 0063,
                LigneAlpha = ' ',
                DateCreation = new DateTime(2016, 10, 06),
                Itineraire = "MIA",
                ClasseBagage = 'Y',
                CodeIata = "456789",
                Continuation = false,
                Rush = false
            });
        }

        public override BagageDefinition GetBagage(int idBagage)
        {

            return null;
        }

        public override BagageDefinition GetBagage(string codeIata)
        {

            return null;
        }

        public override Entities.RoutageBagage GetInfoRoutage(int idBagage)
        {
            return new Entities.RoutageBagage()
            {
                LocalisationEjection = 4516,
                NomEjection = "EJ13",
                StatutEjection = "TPS",
                LocalisationSureteN1 = 4385,
                NomSureteN1 = "PIM EST",
                LocalisationSureteN3 = 13248,
                NomSureteN3 = "CX1"
            };
        }
    }
}
