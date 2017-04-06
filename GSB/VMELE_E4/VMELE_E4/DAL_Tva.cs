using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMELE_E4
{
    class DAL_Tva
    {

        static NpgsqlConnection c_Cnn = Program.DAL.Cnn;

        /// <summary>
        /// Select et créé la liste des TVA existantes
        /// </summary>
        /// <returns>Liste des TVA</returns>
        public static Dictionary<int, cls_Tva> CreerListeTVA()
        {
            cls_Tva l_TVA = null;
            Dictionary<int, cls_Tva> l_ListeTVA = new Dictionary<int, cls_Tva>();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;
                // Retrieve all rows
                cmd.CommandText = "SELECT id_tva, taux, libelle FROM tva;";
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int l_IDtva = reader.GetInt32(0);
                        float l_Taux = reader.GetFloat(1);
                        string l_Libelle = reader.GetString(2);

                        l_TVA = new cls_Tva(l_IDtva, l_Taux, l_Libelle);
                        l_ListeTVA.Add(l_IDtva, l_TVA);
                    }
                }
            }
            return l_ListeTVA;
        }
    }
}
