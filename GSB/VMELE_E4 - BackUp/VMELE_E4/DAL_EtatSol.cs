using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMELE_E4
{
    class DAL_EtatSol
    {
        static NpgsqlConnection c_Cnn = Program.DAL.Cnn;

        /// <summary>
        /// Select et créé la liste états des lignes de commandes
        /// </summary>
        /// <returns>Liste états des lignes de commandes</returns>
        public static Dictionary<int, cls_EtatSol> CreerListeEtatLignesCommande()
        {
            cls_EtatSol l_EtatLignesCommande = null;
            Dictionary<int, cls_EtatSol> l_ListeEtatLignesCommande = new Dictionary<int, cls_EtatSol>();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;
                // Retrieve all rows
                cmd.CommandText = "SELECT id_etat, libelle FROM etat_sol;";
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int l_IDEtatLignesCommande = reader.GetInt32(0);
                        string l_LibelleEtat = reader.GetString(1);

                        l_EtatLignesCommande = new cls_EtatSol(l_IDEtatLignesCommande, l_LibelleEtat);
                        l_ListeEtatLignesCommande.Add(l_IDEtatLignesCommande, l_EtatLignesCommande);
                    }
                }
            }
            return l_ListeEtatLignesCommande;
        }
    }
}
