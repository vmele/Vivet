using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMELE_E4
{
    class DAL_Produit
    {
        static NpgsqlConnection c_Cnn = Program.DAL.Cnn;

        /// <summary>
        /// Select et créé la liste états des commandes
        /// </summary>
        /// <returns>Liste états des commandes</returns>
        public static Dictionary<int, cls_Produit> CreerListeProduits()
        {
            cls_Produit l_Produit = null;
            Dictionary<int, cls_Produit> l_ListeProduits = new Dictionary<int, cls_Produit>();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;
                // Retrieve all rows
                cmd.CommandText = "SELECT id_produit, conditionnement, prix_cdt, libelle FROM produit;";
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int l_IDProduit = reader.GetInt32(0);
                        short l_Conditionnement = reader.GetInt16(1);
                        float l_PrixCdt = reader.GetFloat(2);
                        string l_Libelle = reader.GetString(3);
                        l_Produit = new cls_Produit(l_IDProduit, l_Conditionnement, l_PrixCdt, l_Libelle);
                        l_ListeProduits.Add(l_IDProduit, l_Produit);
                    }
                }
            }
            return l_ListeProduits;
        }
    }
}
