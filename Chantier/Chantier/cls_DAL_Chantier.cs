using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Chantier
{
    public class cls_DAL_Chantier
    {
        static NpgsqlConnection c_Cnn = Program.DAL.Cnn; 

        /// <summary>
        /// Select et créé la liste de chantiers
        /// </summary>
        /// <returns>Liste de chantiers</returns>
        public static Dictionary<int, cls_Chantier> CreerListeChantier()
        {

            cls_Chantier l_Chantier = null;
            Dictionary<int, cls_Chantier> l_ListeChantier = new Dictionary<int, cls_Chantier>();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;
                // Retrieve all rows
                cmd.CommandText = "SELECT id_chantier, nom, date_debut, montant, id_client FROM chantier";
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int l_IDChantier = reader.GetInt32(0);
                        string l_Nom = reader.GetString(1);
                        DateTime l_DateChantier = reader.GetDateTime(2);
                        double l_Montant = reader.GetDouble(3);
                        int l_IDClient = reader.GetInt32(4);

                        l_Chantier = new cls_Chantier(l_IDChantier, l_Nom, l_DateChantier, l_Montant, l_IDClient);
                        l_ListeChantier.Add(l_IDChantier, l_Chantier);
                    }
                }
            }
            return l_ListeChantier;
        }

        /// <summary>
        /// Insert un chantier
        /// </summary>
        /// <param name="pChantier">Objet chantier</param>
        public static void InsertChantier(cls_Chantier pChantier)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;

                // Retrieve all rows
                cmd.CommandText = "insert into chantier (id_chantier, nom, date_debut, montant, id_client)"
                     + "values (" + pChantier.getID() + ",'" + pChantier.Nom + "','" + pChantier.DateDebut + "'," +
                     pChantier.Montant.ToString().Replace(',', '.') + "," + pChantier.ClientID + ");";
                int l_Nb = cmd.ExecuteNonQuery();

            }
        }

        /// <summary>
        /// Update un chantier
        /// </summary>
        /// <param name="pChantier">Objet chantier</param>
        public static void ModifChantier(cls_Chantier pChantier)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;

                // Retrieve all rows
                cmd.CommandText = "update chantier set nom='" + pChantier.Nom + "', date_debut='" + pChantier.DateDebut
                    + "', montant=" + pChantier.Montant.ToString().Replace(',', '.') + ", id_client = " + pChantier.ClientID + " where id_chantier="
                    + pChantier.getID();
                int l_Nb = cmd.ExecuteNonQuery();

            }
        }

        /// <summary>
        /// Delete un chantier
        /// </summary>
        /// <param name="pChantier">Objet chantier</param>
        public static void SupprChantier(cls_Chantier pChantier)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;

                // Retrieve all rows
                cmd.CommandText = "DELETE FROM chantier WHERE id_chantier=" + pChantier.getID();
                int l_Nb = cmd.ExecuteNonQuery();

            }
        }
    }
}
