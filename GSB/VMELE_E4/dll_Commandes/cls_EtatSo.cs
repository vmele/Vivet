using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Commandes
{
    public class cls_EtatSo : cls_ObjetBase
    {
        private int c_IDEtatSo;
        private string c_Libelle;

        /// <summary>
        /// Constructeur de Etat Sale Order
        /// </summary>
        /// <param name="pIDEtatSo">id de l'état de la commande</param>
        /// <param name="pLibelle">libelle de l'état de la commande</param>
        public cls_EtatSo(int pIDEtatSo, string pLibelle) : base(pIDEtatSo)
        {
            c_Libelle = pLibelle;
        }

        public string LibelleEtatSo
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
        public int idEtatSo
        {
            get
            {
                return c_IDEtatSo;
            }
            set
            {
                c_IDEtatSo = value;
            }
        }

        public override string ToString()
        {
            return c_Libelle;
        }
    }
}
