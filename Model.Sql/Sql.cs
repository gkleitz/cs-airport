using MyAirport.Pim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAirport.Pim.Entities;
using System.Configuration;
using System.Data.SqlClient;

namespace Model.Sql
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

        public override List<BagageDefinition> GetBagage(string codeIata)
        {
            List<BagageDefinition> MaListe = new List<BagageDefinition>();
            using (SqlConnection cnx = new SqlConnection(strcnx))
            {
                SqlDataReader sdr;
                BagageDefinition bag;
                SqlCommand cmd = new SqlCommand(commandGetBagage, cnx);
                cmd.Parameters.AddWithValue("@code", codeIata);
                cnx.Open();
                sdr = cmd.ExecuteReader();
                while(sdr.Read())
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

                    MaListe.Add(bag);
                }
                #endregion
            }
            string maString = MaListe[0].ToString();
            System.Diagnostics.Debug.WriteLine(maString);
            System.Console.WriteLine(maString);

            switch(MaListe.Count)
            {
                case 0:
                    MaListe = null;
                    return MaListe;
                case 1:
                    return MaListe;
                default:
                    throw new ApplicationException();
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

        public Sql()
        {
            GetBagage("023232646700");
        }
    }
}
