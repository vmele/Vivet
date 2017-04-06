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
        public cls_LigneCommande(int pIDLigne, int pNumeroLigne, int pQuantite,
            cls_Commande pCommande, int pIDEtat, int pIDProduit, int pIDTva) : base(pIDLigne)
        {
            c_NumeroLigne = pNumeroLigne;
            c_Quantite = pQuantite;
            c_Commande = pCommande;
            c_IDEtat = pIDEtat;
            c_IDProduit = pIDProduit;
            c_IDTva = pIDTva;
            c_Commande = pCommande;
            c_Commande.AjouteLigne(this);

        }
        public int idLigne()
        {
            return this.getID();
        }


        public cls_EtatSol getEtatSolByID(cls_LigneCommande pLigneCommande)
        {
            cls_EtatSol l_EtatSolVoulu = null;
            foreach (cls_EtatSol l_EtatSol in Program.Modele.ListeEtatSol.Values)
            {
                if (pLigneCommande.idEtat == l_EtatSol.getID())
                {
                    l_EtatSolVoulu = l_EtatSol;
                }
            }
            return l_EtatSolVoulu;
        }

        public cls_Produit getProduitlByID(cls_LigneCommande pLigneCommande)
        {
            cls_Produit l_ProduitlVoulu = null;
            foreach (cls_Produit l_Produit in Program.Modele.ListeProduits.Values)
            {
                if (pLigneCommande.idProduit == l_Produit.getID())
                {
                    l_ProduitlVoulu = l_Produit;
                }
            }
            return l_ProduitlVoulu;
        }

        public cls_Tva getTvalByID(cls_LigneCommande pLigneCommande)
        {
            cls_Tva l_TVAlVoulu = null;
            foreach (cls_Tva l_TVA in Program.Modele.ListeTva.Values)
            {
                if (pLigneCommande.idTva == l_TVA.getID())
                {
                    l_TVAlVoulu = l_TVA;
                }
            }
            return l_TVAlVoulu;
        }

        public float calculTotal()
        {
            float total = Quantite * getProduitlByID(this).PrixConditionne *
                (1 + (getTvalByID(this).TauxTva /100));         
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
