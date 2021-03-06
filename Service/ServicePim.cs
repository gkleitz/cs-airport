﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MyAirport.Pim.Entities;

namespace MyAirport.Serveur
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Service : IServicePim
    {
        public int createBagage(BagageDefinition bag)
        {
            throw new NotImplementedException();
        }

        public BagageDefinition GetBagageByCodeIata(string codeIata)
        {
            return MyAirport.Pim.Model.Factory.Model.GetBagage(codeIata);
        }

        public BagageDefinition GetBagageById(int idBagage)
        {
            return MyAirport.Pim.Model.Factory.Model.GetBagage(idBagage);
        }


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public RoutageBagage GetInfoRoutage(int idBagage)
        {
            throw new NotImplementedException();
        }
    }
}
