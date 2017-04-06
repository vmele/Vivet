using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Commandes
{
    public class cls_MoyenContact : cls_ObjetBase
    {
        private int c_IDMoyenContact;
        private string c_Libelle;

        /// <summary>
        /// Constructeur de cls_MoyenContact
        /// </summary>
        /// <param name="pIDMoyenContact">id du moyen de contact</param>
        /// <param name="pLibelle">Libelle du moyen de contact</param>
        public cls_MoyenContact(int pIDMoyenContact, string pLibelle) : base(pIDMoyenContact)
        {
            c_Libelle = pLibelle;
        }

        public int idMoyenContact
        {
            get
            {
                return c_IDMoyenContact;
            }
            set
            {
                c_IDMoyenContact = value;
            }
        }
        public string LibelleContact
        {
            get
            {
                return c_Libelle;
            }
            set
            {
                c_Libelle = value;
            }
        }

        public override string ToString()
        {
            return c_Libelle;
        }
    }
}
