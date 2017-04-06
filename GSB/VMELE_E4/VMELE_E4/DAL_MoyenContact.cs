using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMELE_E4
{
    class DAL_MoyenContact
    {
        static NpgsqlConnection c_Cnn = Program.DAL.Cnn;

        /// <summary>
        /// Select et créé la liste états des commandes
        /// </summary>
        /// <returns>Liste états des commandes</returns>
        public static Dictionary<int, cls_MoyenContact> CreerListeMoyenContact()
        {
            cls_MoyenContact l_Contact = null;
            Dictionary<int, cls_MoyenContact> l_ListeContact = new Dictionary<int, cls_MoyenContact>();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;
                // Retrieve all rows
                cmd.CommandText = "SELECT id_contact, libelle from moyen_contact_commande;";
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int l_IDContact = reader.GetInt32(0);
                        string l_Libelle = reader.GetString(1);
                        l_Contact = new cls_MoyenContact(l_IDContact, l_Libelle);
                        l_ListeContact.Add(l_IDContact, l_Contact);
                    }
                }
            }
            return l_ListeContact;
        }
    }
}
