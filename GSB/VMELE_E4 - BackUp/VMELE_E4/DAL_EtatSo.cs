using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace VMELE_E4
{
    class DAL_EtatSo
    {

        static NpgsqlConnection c_Cnn = Program.DAL.Cnn;

        /// <summary>
        /// Select et créé la liste états des commandes
        /// </summary>
        /// <returns>Liste états des commandes</returns>
        public static Dictionary<int, cls_EtatSo> CreerListeEtatCommande()
        {
            cls_EtatSo l_EtatCommande = null;
            Dictionary<int, cls_EtatSo> l_ListeEtatCommande = new Dictionary<int, cls_EtatSo>();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;
                // Retrieve all rows
                cmd.CommandText = "SELECT id_etat, libelle FROM etat_so;";
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int l_IDEtatCommande = reader.GetInt32(0);
                        string l_LibelleEtat = reader.GetString(1);

                        l_EtatCommande = new cls_EtatSo(l_IDEtatCommande, l_LibelleEtat);
                        l_ListeEtatCommande.Add(l_IDEtatCommande, l_EtatCommande);
                    }
                }
            }
            return l_ListeEtatCommande;
        }
    }
}
