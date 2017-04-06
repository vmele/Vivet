using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Commandes
{
    public class cls_TypeCommande : cls_ObjetBase
    {
        private int c_IDType;
        private string c_LibelleType;
        private string c_LibelleCourt;

        /// <summary>
        /// Constructeur de cls_typeCommande
        /// </summary>
        /// <param name="pIDType">id du type de la commande</param>
        /// <param name="pLibelleType">libelle du type de la commande</param>
        /// <param name="pLibelleCourt">bigramme du type de la commande</param>
        public cls_TypeCommande(int pIDType, string pLibelleType, string pLibelleCourt) : base(pIDType)
        {
            c_LibelleType = pLibelleType;
            c_LibelleCourt = pLibelleCourt;
        }

        public string LibelleType
        {
            get
            {
                return c_LibelleType;
            }
            set
            {
                c_LibelleType = value;
            }
        }
        public string NumeroLigne
        {
            get
            {
                return c_LibelleCourt;
            }
            set
            {
                c_LibelleCourt = value;
            }
        }
    }
}
