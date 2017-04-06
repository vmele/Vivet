using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace VMELE_E4
{
    class DAL_Droit
    {

        static NpgsqlConnection c_Cnn = Program.DAL.Cnn;

        /// <summary>
        /// Select et créé la liste des droits
        /// </summary>
        /// <returns>Liste des droits</returns>
        public static Dictionary<int, cls_Droit> CreerListeDroits()
        {
            cls_Droit l_Droit = null;
            Dictionary<int, cls_Droit> l_ListeDroit = new Dictionary<int, cls_Droit>();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;
                // Retrieve all rows
                cmd.CommandText = "SELECT id_droit, libelle FROM droits;";
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int l_IDDroit = reader.GetInt32(0);
                        string l_LibelleDroit = reader.GetString(1);

                        l_Droit = new cls_Droit(l_IDDroit, l_LibelleDroit);
                        l_ListeDroit.Add(l_IDDroit, l_Droit);
                    }
                }
            }
            return l_ListeDroit;
        }
    }
}
