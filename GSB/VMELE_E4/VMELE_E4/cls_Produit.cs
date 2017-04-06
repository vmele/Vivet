using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMELE_E4
{
    public class cls_Produit : cls_ObjetBase
    {
        private int c_IDProduit;
        private short c_Condtionnement;
        private float c_PrixConditionne;
        private string c_Libelle;

        /// <summary>
        /// Constructeur de cls_Produit
        /// </summary>
        /// <param name="pIDProduit">ID du produit</param>
        /// <param name="pConditionnement">Quantité par lequel est conditionné le produit</param>
        /// <param name="pPrixCondtionne">Prix HT du produit conditionné</param>
        /// <param name="pLibelle">Libellé du produit</param>
        public cls_Produit(int pIDProduit, short pConditionnement, float pPrixCondtionne,
            string pLibelle) : base(pIDProduit)
        {
            setConditionnement(pConditionnement);
            setPrixConditionne(pPrixCondtionne);
            c_Libelle = pLibelle;

        }

        /// <summary>
        /// Empêche un conditionnement d'être inférieur à 0.
        /// </summary>
        /// <param name="pConditionnement"></param>
        public void setConditionnement(short pConditionnement)
        {
            if (pConditionnement < 0)
            {
                throw new Exception("Le conditionnement ne peut être inférieur à 0.");
            }
            else
            {
                c_Condtionnement = pConditionnement;
            }
        }

        /// <summary>
        /// Empêche un prix conditionné d'être inférieur à 0.
        /// </summary>
        /// <param name="pPrixConditionne"></param>
        public void setPrixConditionne(float pPrixConditionne)
        {
            if (pPrixConditionne < 0)
            {
                throw new Exception("Le prix conditionné ne peut être inférieur à 0.");
            }
            else
            {
                c_PrixConditionne = pPrixConditionne;
            }
        }

        public int idProduit
        {
            get
            {
                return c_IDProduit;
            }
            set
            {
                c_IDProduit = value;
            }
        }
        public short Conditionnement
        {
            get
            {
                return c_Condtionnement;
            }
        }
        public float PrixConditionne
        {
            get
            {
                return c_PrixConditionne;
            }

        }
        public string LibelleProduit
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
