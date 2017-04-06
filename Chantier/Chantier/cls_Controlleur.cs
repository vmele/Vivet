using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Chantier
{
    class cls_Controlleur
    {
        private List<cls_ObjetBase> ListeTamponAjout = new List<cls_ObjetBase>();
        private Dictionary<int, cls_ObjetBase> ListeTamponModif = new Dictionary<int, cls_ObjetBase>();
        private List<cls_ObjetBase> ListeTamponSuppr = new List<cls_ObjetBase>();

        /// <summary>
        /// Accesseur de la liste tampon des modifications
        /// </summary>
        public Dictionary<int, cls_ObjetBase> ListeModifTampon
        {
            get
            {
                return ListeTamponModif;
            }
        }

        /// <summary>
        /// Accesseur de la liste tampon des ajouts
        /// </summary>
        public List<cls_ObjetBase> ListeAjoutTampon
        {
            get
            {
                return ListeTamponAjout;
            }
        }

        /// <summary>
        /// Accesseur de la liste tampon des suppressions
        /// </summary>
        public List<cls_ObjetBase> ListeSupprTampon
        {
            get
            {
                return ListeTamponSuppr;
            }
        }
        

        /// <summary>
        /// Ajout en base en fonction de son type
        /// </summary>
        /// <param name="pListeTampon">Liste des ajouts tampon</param>
        public void AjoutBaseTampon(List<cls_ObjetBase> pListeTampon)
        {
            foreach (cls_ObjetBase l_Items in ListeTamponAjout)
            {
                if (l_Items.GetType() == typeof(cls_Chantier))
                {
                   cls_DAL_Chantier.InsertChantier((cls_Chantier)l_Items);
                }
                else
                {
                    if (l_Items.GetType() == typeof(cls_Client))
                    {
                        cls_DAL_Client.InsertClient((cls_Client)l_Items);
                    }
                }
            }
        }

        /// <summary>
        /// Modifie en base en fonction de son type
        /// </summary>
        /// <param name="pListeTampon">Liste des modifications tampon</param>
        public void ModifBaseTampon(Dictionary<int, cls_ObjetBase> pListeTampon)
        {
            foreach (cls_ObjetBase l_Items in ListeTamponModif.Values)
            {
                if (l_Items.GetType() == typeof(cls_Chantier))
                {
                    cls_DAL_Chantier.ModifChantier((cls_Chantier)l_Items);
                }
                else
                {
                    if (l_Items.GetType() == typeof(cls_Client))
                    {
                        cls_DAL_Client.ModifClient((cls_Client)l_Items);
                    }
                }
            }
        }

        /// <summary>
        /// Supprime un objet en base en fonction de son type
        /// </summary>
        /// <param name="pListeTampon">Liste des suppressions tampon</param>
        public void SupprBaseTampon(List<cls_ObjetBase> pListeTampon)
        {
            foreach (cls_ObjetBase l_Items in ListeTamponSuppr)
            {
                if (l_Items.GetType() == typeof(cls_Chantier))
                {
                    cls_DAL_Chantier.SupprChantier((cls_Chantier)l_Items);
                }
                else
                {
                    if (l_Items.GetType() == typeof(cls_Chantier))
                    {
                        cls_DAL_Client.SupprClient((cls_Client)l_Items);
                    }
                }
            }
        }
    }
}
