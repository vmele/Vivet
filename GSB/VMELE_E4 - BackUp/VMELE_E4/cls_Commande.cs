using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMELE_E4
{
    public class cls_Commande : cls_ObjetBase
    {
        private int c_IDCommande;
        private string c_RefCommande;
        private DateTime c_DateCommande;
        private DateTime c_DateVoulue;
        private int c_IDClient;
        private int c_IDContact;
        private int c_IDEtat;
        private int c_IDUtilisateur;
        private int c_IDType;
        private float c_MontantTotal;
        private List<cls_LigneCommande> c_ListeLigneCommande;

        /// <summary>
        /// Constructeur de cls_Commande
        /// </summary>
        /// <param name="pIDCommande">ID de la commande</param>
        /// <param name="pRefCommande">Référence commande</param>
        /// <param name="pDateCommande">Date de la commande</param>
        /// <param name="pDateVoulue">Date demandée par le client</param>
        /// <param name="pIDContact">ID du moyen de contact de la commande</param>
        /// <param name="pIDEtat">ID de l'état de la commande</param>
        /// <param name="pIDUtilisateur">ID de l'utilisateur créant la commande</param>
        /// <param name="pIDType">ID du type de la commande</param>
        public cls_Commande(int pIDCommande, string pRefCommande, DateTime pDateCommande, DateTime pDateVoulue, int pIDClient,
           int pIDContact, int pIDEtat, int pIDUtilisateur, int pIDType, float pMontantTotal = 0) : base(pIDCommande)
        {
            c_RefCommande = pRefCommande;
            c_DateCommande = pDateCommande;
            c_DateVoulue = pDateVoulue;
            c_IDClient = pIDClient;
            c_IDContact = pIDContact;
            c_IDEtat = pIDEtat;
            c_IDUtilisateur = pIDUtilisateur;
            c_IDType = pIDType;
            c_MontantTotal = pMontantTotal;
            c_ListeLigneCommande = new List<cls_LigneCommande>();

        }

        /// <summary>
        /// Récupère l'objet EtatSo pour une commande donnée
        /// </summary>
        /// <param name="pID">Objet commande pour lequel on veut trouver l'ID EtatSo</param>
        /// <returns></returns>
        public cls_EtatSo getEtatSoByID(cls_Commande pCommande)
        {
            cls_EtatSo l_EtatSotVoulu = null;
            foreach (cls_EtatSo l_EtatSo in Program.Modele.ListeEtatSo.Values)
            {
                if (pCommande.idEtat == l_EtatSo.getID())
                {
                    l_EtatSotVoulu = l_EtatSo;
                }
            }
            return l_EtatSotVoulu;
        }

        /// <summary>
        /// Récupère l'objet Client pour une commande donnée
        /// </summary>
        /// <param name="pCommande">Objet commande pour lequel on veut trouver l'ID Client</param>
        /// <returns></returns>
        public cls_Client getClientByID(cls_Commande pCommande)
        {
            cls_Client l_ClientVoulu = null;
            foreach (cls_Client l_Client in Program.Modele.ListeClients.Values)
            {
                if (pCommande.idClient == l_Client.getID())
                {
                    l_ClientVoulu = l_Client;
                }
            }
            return l_ClientVoulu;
        }

        /// <summary>
        /// Récupère l'objet Utilisateur pour une commande donnée
        /// </summary>
        /// <param name="pCommande">Objet commande pour lequel on veut trouver l'ID Utilisateur</param>
        /// <returns></returns>
        public cls_Utilisateur getUtilisateurByID(cls_Commande pCommande)
        {
            cls_Utilisateur l_UtilisateurVoulu = null;
            foreach (cls_Utilisateur l_Utilisateur in Program.Modele.ListeUtilisateurs.Values)
            {
                if (pCommande.idUtilisateur == l_Utilisateur.getID())
                {
                    l_UtilisateurVoulu = l_Utilisateur;
                }
            }
            return l_UtilisateurVoulu;
        }


        public cls_LigneCommande getligneCommandeParID(int pID)
        {
            cls_LigneCommande l_LigneARetourner = null;
            foreach (cls_LigneCommande l_Ligne in Program.Modele.ListeLignesCommandes.Values)
            {
                if (pID == l_Ligne.getID())
                {
                    l_LigneARetourner = l_Ligne;
                }
            }
            return l_LigneARetourner;
        }

        /// <summary>
        /// Ajoute une ligne de commande à la collection de lignes d'une commande
        /// </summary>
        /// <param name="pLigne"></param>
        public void AjouteLigne(cls_LigneCommande pLigne)
        {
            c_ListeLigneCommande.Add(pLigne);
        }

        public override string ToString()
        {
            return c_RefCommande;
        }

        public float calculMontantTotal()
        {
            if (c_MontantTotal == 0)
            {
                foreach (cls_LigneCommande l_Ligne in c_ListeLigneCommande)
                {
                    c_MontantTotal += l_Ligne.calculTotal();
                }

            }
            return c_MontantTotal;
        }


        public string RefCommande
        {
            get
            {
                return c_RefCommande;
            }
            set
            {
                c_RefCommande = value;
            }
        }
        public DateTime DateCommande
        {
            get
            {
                return c_DateCommande;
            }
            set
            {
                c_DateCommande = value;
            }
        }
        public DateTime DateVoulue
        {
            get
            {
                return c_DateVoulue;
            }
            set
            {
                c_DateVoulue = value;
            }

        }
        public int idClient
        {
            get
            {
                return c_IDClient;
            }
            set
            {
                c_IDClient = value;
            }
        }
        public int idContact
        {
            get
            {
                return c_IDContact;
            }
            set
            {
                c_IDContact = value;
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
        public int idUtilisateur
        {
            get
            {
                return c_IDUtilisateur;
            }
            set
            {
                c_IDUtilisateur = value;
            }
        }
        public int idType
        {
            get
            {
                return c_IDType;
            }
            set
            {
                c_IDType = value;
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
        public List<cls_LigneCommande> ListeLignesCommande
        {
            get
            {
                return c_ListeLigneCommande;
            }
            set
            {
                c_ListeLigneCommande = value;
            }
        }
    }
}
