using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMELE_E4
{
    public class cls_LigneCommande : cls_ObjetBase
    {
        private int c_NumeroLigne;
        private int c_Quantite;
        private cls_Commande c_Commande;
        private cls_EtatSol c_Etat;
        private cls_Produit c_Produit;
        private cls_Tva c_Tva;

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
        public cls_LigneCommande(int pIDLigne, int pNumeroLigne, int pQuantite,
            cls_Commande pCommande, cls_EtatSol pEtat, cls_Produit pProduit, cls_Tva pTva) : base(pIDLigne)
        {
            c_NumeroLigne = pNumeroLigne;
            c_Quantite = pQuantite;
            c_Commande = pCommande;
            c_Etat = pEtat;
            c_Produit = pProduit;
            c_Tva = pTva;
            c_Commande = pCommande;
            c_Commande.AjouteLigne(this);

        }
        public int idLigne()
        {
            return this.getID();
        }

        public float calculTotal()
        {
            float total = Quantite * this.Produit.PrixConditionne *
                (1 + (this.Tva.TauxTva /100));         
            return total;
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
        public cls_Commande Commande
        {
            get
            {
                return c_Commande;
            }
            set
            {
                c_Commande = value;
            }
        }
        public cls_Tva Tva
        {
            get
            {
                return c_Tva;
            }
            set
            {
                c_Tva = value;
            }
        }
        public cls_Produit Produit
        {
            get
            {
                return c_Produit;
            }
            set
            {
                c_Produit = value;
            }
        }
        public cls_EtatSol Etat
        {
            get
            {
                return c_Etat;
            }
            set
            {
                c_Etat = value;
            }
        }


    }
}
