using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Pim.Model
{
    static public class Factory
    {
        private static AbstractDefinition singleton = null;
        public static AbstractDefinition Model
        {
            get
            {
                if(singleton == null)
                {
                    switch(ConfigurationManager.AppSettings["Factory"])
                    {
                        //case "Sql":
                        //  singleton = new MyAirport.Pim.Model.Sql();
                        //  break;
                        case "Natif":
                            singleton = new MyAirport.Pim.Model.Natif();
                            break;
                        default:
                            singleton = new MyAirport.Pim.Model.Natif();
                            break;
                    }
                }
                return singleton;
            }
        }
    }
}
