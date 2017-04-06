using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Chantier
{
    class cls_DAL
    {
        static NpgsqlConnection c_Cnn;

        /// <summary>
        /// Constructeur du DAL : connexion à la BDD
        /// </summary>
        /// <param name="pServeur">Nom de serveur</param>
        /// <param name="pNomUtilisateur">Nom d'utilisateur</param>
        /// <param name="pMP">PW utilisateur</param>
        public cls_DAL(string pServeur, string pNomUtilisateur, string pMP)
        {
            c_Cnn = new NpgsqlConnection("Host=" + pServeur + ";Username=" + pNomUtilisateur + ";Password=" + pMP + ";Database=tp_chantier");
            c_Cnn.Open();
        }

        /// <summary>
        /// Accesseur lecture de la connexion.
        /// </summary>
        public NpgsqlConnection Cnn
        {
            get
            {
                return c_Cnn;
            }
        }
    }
}
