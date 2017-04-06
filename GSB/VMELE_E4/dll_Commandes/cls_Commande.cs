using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Commandes
{
    public class cls_Commande : cls_ObjetBase
    {

        private string c_RefCommande;
        private DateTime c_DateCommande;
        private DateTime c_DateVoulue;
        private int c_IDClient;
        private int c_IDContact;
        private int c_IDEtat;
        private int c_IDUtilisateur;
        private int c_IDType;
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
           int pIDContact, int pIDEtat, int pIDUtilisateur, int pIDType) : base(pIDCommande)
        {
            c_RefCommande = pRefCommande;
            c_DateCommande = pDateCommande;
            c_DateVoulue = pDateVoulue;
            c_IDClient = pIDClient;
            c_IDContact = pIDContact;
            c_IDEtat = pIDEtat;
            c_IDUtilisateur = pIDUtilisateur;
            c_IDType = pIDType;
            c_ListeLigneCommande = new List<cls_LigneCommande>();

        }

        /// <summary>
        /// Récupère l'objet client avec l'ID du chantier
        /// </summary>
        /// <param name="pID">ID du chantier</param>
        /// <returns></returns>
        public cls_EtatSo getEtatSoByID(cls_Commande pCommande)
        {
            cls_EtatSo l_EtatSoVoulu = null;
            foreach (cls_EtatSo l_EtatSo in )
            {
                if (pChantier.ClientID == l_Client.getID())
                {
                    l_ClientVoulu = l_Client;
                }
            }
            return l_ClientVoulu;
        }


        public override string ToString()
        {
            return c_RefCommande;
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
