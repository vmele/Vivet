using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMELE_E4
{
    class DAL_Client
    {
        static NpgsqlConnection c_Cnn = Program.DAL.Cnn;

        /// <summary>
        /// Select et créé la liste des clients
        /// </summary>
        /// <returns>Liste des clients</returns>
        public static Dictionary<int, cls_Client> CreerListeClients()
        {
            cls_Client l_Client = null;
            Dictionary<int, cls_Client> l_ListeClient = new Dictionary<int, cls_Client>();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;
                // Retrieve all rows
                cmd.CommandText = "SELECT id_client, raison_sociale FROM client;";
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int l_IDClient = reader.GetInt32(0);
                        string l_RaisonSociale = reader.GetString(1);

                        l_Client = new cls_Client(l_IDClient, l_RaisonSociale);
                        l_ListeClient.Add(l_IDClient, l_Client);
                    }
                }
            }
            return l_ListeClient;
        }
    }
}
