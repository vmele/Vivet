using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Commandes
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
        public cls_Utilisateur(int pIDPersonne, string pNom, string pPrenom, string pIdentifiant, string pMotdePasse,
            string pMail, int pIDDroit) : base(pIDPersonne, pNom, pPrenom)
        {
            setIdentifiant(pIdentifiant);
            setMotdePasse(pMotdePasse);
            c_Mail = pMail;
            c_IDDroit = pIDDroit;
        }

        /// <summary>
        /// Empêche l'identifiant d'être vide
        /// </summary>
        /// <param name="pIdentifiant">Identifiant de l'utilisateur</param>
        public void setIdentifiant(string pIdentifiant)
        {
            if (pIdentifiant == "")
            {
                throw new Exception("L'identifiant ne peut être vide.");
            }
            else
            {
                c_Identifiant = pIdentifiant;
            }
        }

        /// <summary>
        /// Empêche le mot de passe d'être vide
        /// </summary>
        /// <param name="pMotdePasse">Mot de passe de l'utilisateur</param>
        public void setMotdePasse(string pMotdePasse)
        {
            if (pMotdePasse == "")
            {
                throw new Exception("Le mot de passe ne peut être vide.");
            }
            else
            {
                c_MotDePasse = pMotdePasse;
            }
        }

        //public cls_Utilisateur getUtilisateurByID(int pID)
        //{
        //    cls_Utilisateur l_Utilisateur = null;

        //    foreach (cls_Utilisateur l_Utilisateur in )
        //    {

        //    }
        //    return l_Utilisateur;
        //}
    }
}
