using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Commandes
{
    public class cls_Modele
    {
        Dictionary<int, cls_Commande> c_ListeCommandes = null;
        Dictionary<int, cls_Droit> c_ListeDroits = null;
        Dictionary<int, cls_EtatSo> c_ListeEtatSo = null;
        Dictionary<int, cls_EtatSol> c_ListeEtatSol = null;
        Dictionary<int, cls_LigneCommande> c_ListeLignesCommandes = null;
        Dictionary<int, cls_MoyenContact> c_ListeMoyenContact = null;
        Dictionary<int, cls_Personne> c_ListePersonne = null;
        Dictionary<int, cls_Produit> c_ListeProduits = null;
        Dictionary<int, cls_Tva> c_ListeTva = null;
        Dictionary<int, cls_TypeCommande> c_ListeTypesCommande = null;
        Dictionary<int, cls_Utilisateur> c_ListeUtilisateurs = null;

        public Dictionary<int, cls_Commande> ListeCommandes
        {
            get
            {
                return c_ListeCommandes;
            }

            set
            {
                c_ListeCommandes = value;
            }
        }
        public Dictionary<int, cls_Droit> ListeDroits
        {
            get
            {
                return c_ListeDroits;
            }

            set
            {
                c_ListeDroits = value;
            }
        }
        public Dictionary<int, cls_EtatSo> ListeEtatSo
        {
            get
            {
                return c_ListeEtatSo;
            }

            set
            {
                c_ListeEtatSo = value;
            }
        }
        public Dictionary<int, cls_EtatSol> ListeEtatSol
        {
            get
            {
                return c_ListeEtatSol;
            }

            set
            {
                c_ListeEtatSol = value;
            }
        }

        public Dictionary<int, cls_LigneCommande> ListeLignesCommandes
        {
            get
            {
                return c_ListeLignesCommandes;
            }

            set
            {
                c_ListeLignesCommandes = value;
            }
        }
        public Dictionary<int, cls_MoyenContact> ListeMoyensContact
        {
            get
            {
                return c_ListeMoyenContact;
            }

            set
            {
                c_ListeMoyenContact = value;
            }
        }
        public Dictionary<int, cls_Personne> ListePersonnes
        {
            get
            {
                return c_ListePersonne;
            }

            set
            {
                c_ListePersonne = value;
            }
        }
        public Dictionary<int, cls_Produit> ListeProduits
        {
            get
            {
                return c_ListeProduits;
            }

            set
            {
                c_ListeProduits = value;
            }
        }

        public Dictionary<int, cls_Tva> ListeTva
        {
            get
            {
                return c_ListeTva;
            }

            set
            {
                c_ListeTva = value;
            }
        }
        public Dictionary<int, cls_TypeCommande> ListeTypesCommandes
        {
            get
            {
                return c_ListeTypesCommande;
            }

            set
            {
                c_ListeTypesCommande = value;
            }
        }
        public Dictionary<int, cls_Utilisateur> ListeUtilisateurs
        {
            get
            {
                return c_ListeUtilisateurs;
            }

            set
            {
                c_ListeUtilisateurs = value;
            }
        }
    }
}
