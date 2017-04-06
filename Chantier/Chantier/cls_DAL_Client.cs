using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Chantier
{
    public class cls_DAL_Client
    {
        // On récupère la variable de connexion. La connexion est ok.
        static NpgsqlConnection c_Cnn = Program.DAL.Cnn;

        /// <summary>
        /// Select et créé la liste des clients
        /// </summary>
        /// <returns>Liste des clients</returns>
        public static Dictionary<int, cls_Client> CreerListeClient()
        {
            cls_Client l_Client = null;
            Dictionary<int, cls_Client> l_ListeClient = new Dictionary<int, cls_Client>();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;
                // Retrieve all rows
                cmd.CommandText = "SELECT id_client, raison_sociale_client, telephone, mail FROM client";
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int l_IDClient = reader.GetInt32(0);
                        string l_RaisonSociale = reader.GetString(1);
                        string l_Telephone = reader.GetString(2);
                        string l_Mail = reader.GetString(3);

                        l_Client = new cls_Client(l_IDClient, l_RaisonSociale, l_Telephone, l_Mail);
                        l_ListeClient.Add(l_IDClient, l_Client);
                    }
                }
            }
            return l_ListeClient;
        }

        /// <summary>
        /// Ajoute un client en base
        /// </summary>
        /// <param name="pClient">Client à ajouter</param>
        public static void InsertClient(cls_Client pClient)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;

                // Retrieve all rows
                cmd.CommandText = "insert into client (id_client, raison_sociale_client, telephone, mail)"
                     + "values (" + pClient.getID() + ",'" + pClient.RaisonSociale + "','" + pClient.Telephone + "','" +
                     pClient.eMail + "');";
                int l_Nb = cmd.ExecuteNonQuery();

            }
        }

        /// <summary>
        /// Modifie un client en base
        /// </summary>
        /// <param name="pClient">Client à modifier</param>
        public static void ModifClient(cls_Client pClient)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;

                // Retrieve all rows
                cmd.CommandText = "update client set raison_sociale_client='" + pClient.RaisonSociale +
                    "', telephone='" + pClient.Telephone + "', mail='" + pClient.eMail + "' WHERE id_client="
                    + pClient.getID();
                int l_Nb = cmd.ExecuteNonQuery();

            }
        }

        /// <summary>
        /// Supprime un client en base
        /// </summary>
        /// <param name="pClient">Client à supprimer</param>
        public static void SupprClient(cls_Client pClient)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                    cmd.Connection = c_Cnn;

                    cmd.CommandText = "DELETE FROM client WHERE id_client=" + pClient.getID();
                    int l_Nb = cmd.ExecuteNonQuery();
            }
        }
    }
}
