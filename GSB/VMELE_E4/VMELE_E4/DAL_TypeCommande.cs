using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMELE_E4
{
    class DAL_TypeCommande
    {
        static NpgsqlConnection c_Cnn = Program.DAL.Cnn;

        /// <summary>
        /// Select et créé la liste des types de commande
        /// </summary>
        /// <returns>Liste états des commandes</returns>
        public static Dictionary<int, cls_TypeCommande> CreerListeType()
        {
            cls_TypeCommande l_Type = null;
            Dictionary<int, cls_TypeCommande> l_ListeTypes = new Dictionary<int, cls_TypeCommande>();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;
                // Retrieve all rows
                cmd.CommandText = "SELECT id_type, libelle, libelle_court from type_commande;";
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int l_IDType = reader.GetInt32(0);
                        string l_Libelle = reader.GetString(1);
                        string l_LibelleCourt = reader.GetString(2);
                        l_Type = new cls_TypeCommande(l_IDType, l_Libelle, l_LibelleCourt);
                        l_ListeTypes.Add(l_IDType, l_Type);
                    }
                }
            }
            return l_ListeTypes;
        }
    }
}
