using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMELE_E4
{
    public class cls_Controlleur
    {
        public void chargerModele()
        {

            Program.Modele.ListeClients = DAL_Client.CreerListeClients();
            Program.Modele.ListeDroits = DAL_Droit.CreerListeDroits();
            Program.Modele.ListeEtatSo = DAL_EtatSo.CreerListeEtatCommande();
            Program.Modele.ListeEtatSol = DAL_EtatSol.CreerListeEtatLignesCommande();
            Program.Modele.ListeMoyensContact = DAL_MoyenContact.CreerListeMoyenContact();
            Program.Modele.ListeProduits = DAL_Produit.CreerListeProduits();
            Program.Modele.ListeTva = DAL_Tva.CreerListeTVA();
            Program.Modele.ListeTypesCommandes = DAL_TypeCommande.CreerListeType();
            Program.Modele.ListeUtilisateurs= DAL_Utilisateur.CreerListeUtilisateurs();
            Program.Modele.ListeCommandes = DAL_Commande.CreerListeCommande();
            Program.Modele.ListeLignesCommandes = DAL_LigneCommande.
                CreerListeLignesCommande();
        }

        public void selectCommandeConditions(List<string> pListeConditions)
        {
            Program.Modele.ListeTamponCommandes = DAL_Commande.
                selectCommandesConditions(pListeConditions);
        }

        public void selectLignesCommandeConditions(List<string> pListeConditions)
        {
           Program.Modele.ListeLignesTamponCommandes = DAL_LigneCommande.
                selectLignesCommandeConditions(pListeConditions);

        }

        public void ajoutCommande(cls_Commande pCommande)
        {
            DAL_Commande.InsertCommande(pCommande);
        }

        public void modifCommande(cls_Commande pCommande)
        {
            DAL_Commande.ModifCommande(pCommande);
        }

        public void ajoutLigneCommande(cls_LigneCommande pLigne)
        {
            DAL_LigneCommande.InsertLigne(pLigne);
        }

        public void modifLigneCommande(cls_LigneCommande pLigne)
        {
            DAL_LigneCommande.ModifLigne(pLigne);
        }
    }
}
