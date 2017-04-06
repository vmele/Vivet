using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chantier
{
    class cls_Modele
    {

        Dictionary<int, cls_Chantier> c_ListeChantier = null;
        Dictionary<int, cls_Client> c_ListeClient = null;

        /// <summary>
        /// Accesseur de la liste des chantiers
        /// </summary>
        public Dictionary<int, cls_Chantier> ListeChantier
        {
            get
            {
                return c_ListeChantier;
            }

            set
            {
                c_ListeChantier = value;
            }
        }

        /// <summary>
        /// Accesseur de la liste des clients 
        /// </summary>
        public Dictionary<int, cls_Client> ListeClient
        {
            get
            {
                return c_ListeClient;
            }

            set
            {
                c_ListeClient = value;
            }
        }
    }
}
