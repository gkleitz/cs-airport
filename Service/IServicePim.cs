using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyAirport.Serveur
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServicePim
    {
        [OperationContract]
        string GetData(int value);
        [OperationContract]
        MyAirport.Pim.Entities.BagageDefinition GetBagageById(int idBagage);
        [OperationContract]
        MyAirport.Pim.Entities.BagageDefinition GetBagageByCodeIata(string codeIata);
        [OperationContract]
        int createBagage(MyAirport.Pim.Entities.BagageDefinition bag);
        [OperationContract]
        MyAirport.Pim.Entities.RoutageBagage GetInfoRoutage(int idBagage);

        // TODO: ajoutez vos opérations de service ici
    }
}
