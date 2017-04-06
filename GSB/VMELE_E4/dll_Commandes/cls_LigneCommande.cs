using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Commandes
{
    public class cls_LigneCommande : cls_ObjetBase
    {
        private int c_NumeroLigne;
        private int c_Quantite;
        private double c_Montant;
        private int c_IDCommande;
        private int c_IDEtat;
        private int c_IDProduit;
        private int c_IDTva;

        /// <summary>
        /// Constructeur des lignes de commande
        /// </summary>
        /// <param name="pIDLigne">ID de la ligne de commande</param>
        /// <param name="pNumeroLigne">Numéro de ligne</param>
        /// <param name="pQuantite">Quantité de la ligne</param>
        /// <param name="pMontant">Montant de la ligne</param>
        /// <param name="pIDCommande">ID de la commande associée</param>
        /// <param name="pIDEtat">ID de l'état</param>
        /// <param name="pIDProduit">ID du produit</param>
        /// <param name="pIDTva">ID de la TVA</param>
        public cls_LigneCommande(int pIDLigne, int pNumeroLigne, int pQuantite, double pMontant,
            int pIDCommande, int pIDEtat, int pIDProduit, int pIDTva) : base(pIDLigne)
        {
            c_NumeroLigne = pNumeroLigne;
            setQuantite(pQuantite);
            c_Montant = pMontant;
            c_IDCommande = pIDCommande;
            c_IDEtat = pIDEtat;
            c_IDProduit = pIDProduit;
            c_IDTva = pIDTva;

        }

        /// <summary>
        /// Empeche la quantité d'une ligne d'etre inférieure à 0.
        /// </summary>
        /// <param name="pQuantite">Quantité d'un produit pour une ligne</param>
        public void setQuantite(int pQuantite)
        {
            if (pQuantite < 0)
            {
                throw new Exception("La quantité ne peut être inférieure à 0.");
            }
            else
            {
                c_Quantite = pQuantite;
            }
        }

        public int NumeroLigne
        {
            get
            {
                return c_NumeroLigne;
            }
            set
            {
                c_NumeroLigne = value;
            }
        }
        public int Quantite
        {
            get
            {
                return c_Quantite;
            }
            set
            {
                c_Quantite = value;
            }
        }
        public double Montant
        {
            get
            {
                return c_Montant;
            }
            set
            {
                c_Montant = value;
            }
        }
        public int idCommande
        {
            get
            {
                return c_IDCommande;
            }
            set
            {
                c_IDCommande = value;
            }
        }
        public int idTva
        {
            get
            {
                return c_IDTva;
            }
            set
            {
                c_IDTva = value;
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
        public int idEtat
        {
            get
            {
                return c_IDEtat;
            }
            set
            {
                c_IDEtat = value;
            }
        }
    }
}
