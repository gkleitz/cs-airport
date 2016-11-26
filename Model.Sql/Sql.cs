using MyAirport.Pim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAirport.Pim.Entities;
using System.Configuration;
using System.Data.SqlClient;

namespace MyAirport.Pim.Model
{
    public class Sql : AbstractDefinition
    {
        string strcnx = ConfigurationManager.ConnectionStrings["Client.FormIhm.Properties.Settings.DbConnect"].ConnectionString;
        string commandGetBagage =   "SELECT b.id_bagage, b.code_iata, b.compagnie, b.ligne, b.date_creation, b.escale, b.classe, b.continuation, cast(iif(bp.PARTICULARITE is null, 0, 1) as bit) as 'RUSH' "+
                                    "FROM bagage b "+
                                    "LEFT OUTER JOIN BAGAGE_A_POUR_PARTICULARITE bap on bap.ID_BAGAGE = b.ID_BAGAGE "+
                                    "LEFT OUTER JOIN BAGAGE_PARTICULARITE bp on bp.ID_PART = bap.ID_PARTICULARITE and bp.PARTICULARITE = 'RUSH' "+
                                    "WHERE b.code_iata = @code "+
                                    "ORDER by b.id_bagage ";

        public override BagageDefinition GetBagage(string codeIata)
        {
            using (SqlConnection cnx = new SqlConnection(strcnx))
            {
                SqlDataReader sdr;
                BagageDefinition bag = null;
                SqlCommand cmd = new SqlCommand(commandGetBagage, cnx);
                cmd.Parameters.AddWithValue("@code", codeIata);
                cnx.Open();
                sdr = cmd.ExecuteReader();
                if (sdr.Read())
                #region cache
                {
                    bag = new BagageDefinition();
                    bag.IdBagage = Convert.ToInt32(sdr["id_bagage"]);
                    bag.Compagnie = sdr["compagnie"].ToString();
                    bag.Ligne = Convert.ToInt32(sdr["ligne"]);
                    bag.DateCreation = sdr.GetDateTime(sdr.GetOrdinal("date_creation"));
                    bag.Itineraire = sdr.GetString(sdr.GetOrdinal("escale"));
                    bag.ClasseBagage = sdr["classe"] is DBNull ? 'Y' : Convert.ToChar(sdr["classe"]);
                    bag.CodeIata = sdr.GetString(sdr.GetOrdinal("code_iata"));
                    bag.Continuation = sdr[sdr.GetOrdinal("continuation")].ToString() == "Y" ? true : false;
                    bag.Rush = sdr.GetFieldValue<bool>(sdr.GetOrdinal("rush"));
                }
                if (sdr.Read())
                {
                    throw new ApplicationException("Trop de résultats retournés");
                }
                #endregion

                return bag;
            }
        }

        public override BagageDefinition GetBagage(int idBagage)
        {
            throw new NotImplementedException();
        }

        public override RoutageBagage GetInfoRoutage(int idBagage)
        {
            throw new NotImplementedException();
        }
    }
}
