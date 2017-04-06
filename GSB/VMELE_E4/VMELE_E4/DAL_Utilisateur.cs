using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMELE_E4
{
    class DAL_Utilisateur
    {
        static NpgsqlConnection c_Cnn = Program.DAL.Cnn;

        /// <summary>
        /// Select et créé la liste des utilisateurs avec leur droit et la personne associée.
        /// </summary>
        /// <returns>Liste des utilisateurs, leur droit et la personne associée</returns>
        public static Dictionary<int, cls_Utilisateur> CreerListeUtilisateurs()
        {
            cls_Utilisateur l_Utilisateur = null;
            Dictionary<int, cls_Utilisateur> l_ListeUtilisateurs = new Dictionary<int, cls_Utilisateur>();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;
                // Retrieve all rows
                cmd.CommandText = "SELECT utilisateur.id_personne, nom, prenom, identifiant, mot_de_passe, mail,"
                                    + "id_droit FROM utilisateur, personne WHERE utilisateur.id_personne ="
                                    + "personne.id_personne;";
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int l_IDUtilisateur = reader.GetInt32(0);
                        string l_Nom = reader.GetString(1);
                        string l_Prenom = reader.GetString(2);
                        string l_Identifiant = reader.GetString(3);
                        string l_MotdePasse = reader.GetString(4);
                        string l_Mail = reader.GetString(5);
                        int l_IDDroit = reader.GetInt32(6);


                        l_Utilisateur = new cls_Utilisateur(l_IDUtilisateur, l_Nom, l_Prenom, 
                            l_Identifiant, l_MotdePasse, l_Mail, Program.Modele.ListeDroits[l_IDDroit]);
                        l_ListeUtilisateurs.Add(l_IDUtilisateur, l_Utilisateur);
                    }
                }
            }
            return l_ListeUtilisateurs;
        }


        ///// <summary>
        ///// Select et créé la liste des utilisateurs avec leur droit et la personne associée.
        ///// </summary>
        ///// <returns>Liste des utilisateurs, leur droit et la personne associée</returns>
        //public static cls_Utilisateur CheckLogin(string pIdentifiant, string pMotdePasse)
        //{
        //    cls_Utilisateur l_Utilisateur = null;
        //    using (NpgsqlCommand cmd = new NpgsqlCommand())
        //    {
        //        cmd.Connection = c_Cnn;
        //        // Retrieve all rows
        //        cmd.CommandText = "SELECT utilisateur.id_personne, nom, prenom, identifiant, mot_de_passe, mail,"
        //                            + "id_droit FROM utilisateur, personne WHERE utilisateur.id_personne ="
        //                            + "personne.id_personne AND identifiant = '" + pIdentifiant + "' AND mot_de_passe = '" + pMotdePasse + "';";
        //        using (NpgsqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                int l_IDUtilisateur = reader.GetInt32(0);
        //                string l_Nom = reader.GetString(1);
        //                string l_Prenom = reader.GetString(2);
        //                string l_Identifiant = reader.GetString(3);
        //                string l_MotdePasse = reader.GetString(4);
        //                string l_Mail = reader.GetString(5);
        //                int l_IDDroit = reader.GetInt32(6);


        //                l_Utilisateur = new cls_Utilisateur(l_IDUtilisateur, l_Nom, l_Prenom, l_Identifiant, l_MotdePasse, l_Mail, l_IDDroit);
        //            }
        //        }
        //    }
        //    return l_Utilisateur;
        //}
    }
}
