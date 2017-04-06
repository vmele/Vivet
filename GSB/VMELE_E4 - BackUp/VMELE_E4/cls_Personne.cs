using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMELE_E4
{
    public class cls_Personne : cls_ObjetBase
    {
        private int c_IDPersonne;
        private string c_Nom;
        private string c_Prenom;

        /// <summary>
        /// Constructeur de la classe personne
        /// </summary>
        /// <param name="pIDPersonne">id de la personne</param>
        /// <param name="pNom">Nom de la personne</param>
        /// <param name="pPrenom">Prenom de la personne</param>
        public cls_Personne(int pIDPersonne, string pNom, string pPrenom)
            : base(pIDPersonne)
        {
            setNom(pNom);
            setPrenom(pPrenom);
        }

        /// <summary>
        /// Empêche le nom d'être vide
        /// </summary>
        /// <param name="pNom">Nom de la personne</param>
        public void setNom(string pNom)
        {
            if (pNom == "")
            {
                throw new Exception("Le nom ne peut être vide.");
            }
            else
            {
                c_Nom = pNom;
            }
        }

        /// <summary>
        /// Empêche le prénom d'être vide
        /// </summary>
        /// <param name="pPrenom">Prénom de la personne</param>
        public void setPrenom(string pPrenom)
        {
            if (pPrenom == "")
            {
                throw new Exception("Le prénom ne peut être vide.");
            }
            else
            {
                c_Prenom = pPrenom;
            }
        }


        public int idPersonne
        {
            get
            {
                return c_IDPersonne;
            }
            set
            {
                c_IDPersonne = value;
            }
        }
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
        public string Prenom
        {
            get
            {
                return c_Prenom;
            }
            set
            {
                c_Prenom = value;
            }
        }
    }
}
