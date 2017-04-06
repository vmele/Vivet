using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chantier
{
    public class cls_Chantier : cls_ObjetBase
    {
        private string c_Nom;
        private DateTime c_DateDebut;
        private double c_Montant;
        private int c_IDClient;

        /// <summary>
        /// Constructeur de la classe chantier
        /// </summary>
        /// <param name="pIDChantier">ID du chantier</param>
        /// <param name="pNom">Nom du chantier</param>
        /// <param name="pDateDebut">Date de début du chantier</param>
        /// <param name="pMontant">Montant total du chantier</param>
        /// <param name="pIDClient">ID du client associé au chantier</param>
        public cls_Chantier(int pIDChantier, string pNom, DateTime pDateDebut, double pMontant, int pIDClient) : base(pIDChantier)
        {
            c_Nom = pNom;
            c_DateDebut = pDateDebut;
            c_Montant = pMontant;
            c_IDClient = pIDClient;
        }
        /// <summary>
        /// Récupère l'objet client avec l'ID du chantier
        /// </summary>
        /// <param name="pID">ID du chantier</param>
        /// <returns></returns>
        public cls_Client getClientParID(cls_Chantier pChantier)
        {
            cls_Client l_ClientVoulu = null;
            foreach (cls_Client l_Client in Program.Modele.ListeClient.Values)
            {
                if (pChantier.ClientID ==l_Client.getID())
                {
                    l_ClientVoulu = l_Client;
                }
            }
            return l_ClientVoulu;
        }

        /// <summary>
        /// Redéfinition du ToString() : il renvoie le nom du chantier
        /// </summary>
        /// <returns>Nom du chantier</returns>
        public override string ToString()
        {
            return c_Nom;
        }

        /// <summary>
        /// Obtient l'objet chantier selon son ID
        /// </summary>
        /// <param name="pIDChantier">ID du chantier cherché</param>
        /// <returns>Chantier voulu</returns>
        public cls_Chantier getChantierParID(int pIDChantier)
        {
            cls_Chantier l_ChantierCherche = null;
            foreach (cls_Chantier l_Chantier in Program.Modele.ListeChantier.Values)
            {
                if (l_Chantier.getID() == pIDChantier)
                {
                    l_ChantierCherche = l_Chantier;
                }
            }
            return l_ChantierCherche;
        }

        /// <summary>
        /// Accesseurs de l'ID du client
        /// </summary>
        public int ClientID
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

        /// <summary>
        /// Accesseur du montant du chantier
        /// </summary>
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

        /// <summary>
        /// Accesseur du nom du chantier
        /// </summary>
        public string Nom
        {
            get
            {
                return c_Nom;
            }
            set
            {
                c_Nom = value;
            }
        }

        /// <summary>
        /// Accesseur de la date du chantier
        /// </summary>
        public DateTime DateDebut
        {
            get
            {
                return c_DateDebut;
            }
            set
            {
                c_DateDebut = value;
            }
        }
    }
}
