using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Commandes
{
    public class cls_EtatSol : cls_ObjetBase
    {
        private int c_IDEtatSol;
        private string c_Libelle;

        /// <summary>
        /// Constructeur de Etat Sale Order Line
        /// </summary>
        /// <param name="pIDEtatSo">id de l'état de la ligne de commande</param>
        /// <param name="pLibelle">libelle de l'état de la ligne de commande</param>
        public cls_EtatSol(int pIDEtatSol, string pLibelle) : base(pIDEtatSol)
        {
            c_Libelle = pLibelle;
        }

        public string LibelleEtatSol
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
        public int IDEtatSol
        {
            get
            {
                return c_IDEtatSol;
            }
            set
            {
                c_IDEtatSol = value;
            }
        }

        public override string ToString()
        {
            return c_Libelle;
        }
    }
}
