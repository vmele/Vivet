using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMELE_E4
{
    public class cls_Utilisateur : cls_Personne
    {
        private int c_IDPersonne;
        private string c_Nom;
        private string c_Prenom;

        private string c_Identifiant;
        private string c_MotDePasse;
        private string c_Mail;
        private cls_Droit c_Droit;

        /// <summary>
        /// Constructeur de cls_utilisateur
        /// </summary>
        /// <param name="pIDPersonne">id de la personne</param>
        /// <param name="pNom">nom de la personne</param>
        /// <param name="pPrenom">prénom de la personne</param>
        /// <param name="pIdentifiant">identifiant de l'utilisateur</param>
        /// <param name="pMotdePasse">mot de passe de l'utilisateur</param>
        /// <param name="pMail">mail de l'utilisateur</param>
        /// <param name="pIDDroit">droit de l'utilisateur</param>
        public cls_Utilisateur(int pIDPersonne, string pNom, string pPrenom, 
            string pIdentifiant, string pMotdePasse, string pMail, cls_Droit pDroit) 
            : base(pIDPersonne, pNom, pPrenom)
        {
            c_Identifiant = pIdentifiant;
            c_MotDePasse = pMotdePasse;
            c_Mail = pMail;
            c_Droit = pDroit;
        }

        public string Login
        {
            get
            {
                return c_Identifiant;
            }
            set
            {
                c_Identifiant = value;
            }
        }
        public string Mail
        {
            get
            {
                return c_Mail;
            }
            set
            {
                c_Mail = value;
            }
        }
        public cls_Droit Droit
        {
            get
            {
                return c_Droit;
            }
            set
            {
                c_Droit = value;
            }
        }
        public string MotDePasse
        {
            get
            {
                return c_MotDePasse;
            }
            set
            {
                c_MotDePasse = value;
            }
        }

        public override string ToString()
        {
            return c_Identifiant.ToUpper();
        }
    }
}
