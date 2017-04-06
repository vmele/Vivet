using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Commandes
{
    public class cls_Tva : cls_ObjetBase
    {
        private int c_IDTva;
        private float c_TauxTva;
        private string c_LibelleTVA;

        /// <summary>
        /// Constructeur de cls_Tva
        /// </summary>
        /// <param name="pIDTva">id de la TVA</param>
        /// <param name="pTauxTva">Taux de la tva associée</param>
        /// <param name="pLibelle">libellé de la tva associéé</param>
        public cls_Tva(int pIDTva, float pTauxTva, string pLibelle) : base(pIDTva)
        {
            c_TauxTva = pTauxTva;
            c_LibelleTVA = pLibelle;
        }

        public float TauxTva
        {
            get
            {
                return c_TauxTva;
            }
            set
            {
                c_TauxTva = value;
            }
        }
        public string LibelleTVA
        {
            get
            {
                return c_LibelleTVA;
            }
            set
            {
                c_LibelleTVA = value;
            }
        }

        public override string ToString()
        {
            return Convert.ToString(c_TauxTva);
        }
    }
}
