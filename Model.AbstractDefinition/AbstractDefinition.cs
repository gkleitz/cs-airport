using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAirport.Pim.Entities;

namespace MyAirport.Pim.Model
{
    public abstract class AbstractDefinition
    {
        public abstract BagageDefinition GetBagage(int idBagage);
        public abstract BagageDefinition GetBagage(string codeIata);
        public abstract Entities.RoutageBagage GetInfoRoutage(int idBagage);
    }
}
