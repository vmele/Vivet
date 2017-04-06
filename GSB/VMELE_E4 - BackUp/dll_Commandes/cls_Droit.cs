using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Commandes
{
    public class cls_Droit : cls_ObjetBase
    {
        private int c_IDDroit;
        private string c_Libelle;

        /// <summary>
        /// Constructeur des droits des utilisateurs
        /// </summary>
        /// <param name="pIDDroit">id du droit</param>
        /// <param name="pLibelle">Libelle du droit</param>
        public cls_Droit(int pIDDroit, string pLibelle) : base(pIDDroit)
        {
            c_Libelle = pLibelle;
        }

        public int idDroit
        {
            get
            {
                return c_IDDroit;
            }
            set
            {
                c_IDDroit = value;
            }
        }
        public string Libelle
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
    }
}
