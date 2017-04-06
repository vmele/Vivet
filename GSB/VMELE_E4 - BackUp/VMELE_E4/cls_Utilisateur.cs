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
        private int c_IDDroit;

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
            string pIdentifiant, string pMotdePasse, string pMail, int pIDDroit) 
            : base(pIDPersonne, pNom, pPrenom)
        {
            c_Identifiant = pIdentifiant;
            c_MotDePasse = pMotdePasse;
            c_Mail = pMail;
            c_IDDroit = pIDDroit;
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
        public int IDdroit
        {
            get
            {
                return c_IDDroit;
            }
            set
            {
                c_IDDroit = value;
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
