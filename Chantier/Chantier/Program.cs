using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chantier
{
    static class Program
    {
        static cls_Modele s_Modele;
        static cls_Controlleur s_Controlleur;
        static cls_DAL s_DAL;
        static cls_DAL_Chantier s_DAL_Chantier;
        static cls_DAL_Client s_DAL_Client;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Le program se lance sur frm_ListeChantier
            Application.Run(new frm_ListeChantier());
        }

        /// <summary>
        /// Constructeur de Program
        /// </summary>
        static Program()
        {
            s_Controlleur = new cls_Controlleur();
            s_Modele = new cls_Modele();
            s_DAL = new cls_DAL("localhost", "postgres", "postgres");
            s_DAL_Chantier = new cls_DAL_Chantier();
            s_DAL_Client = new cls_DAL_Client();
        }

        /// <summary>
        /// Accesseurs DALChantier
        /// </summary>
        public static cls_DAL_Chantier DALChantier { get; set; }

        /// <summary>
        /// Accesseur DALClient
        /// </summary>
        public static cls_DAL_Client DALClient { get; set; }

        /// <summary>
        /// Accesser DAL
        /// </summary>
        public static cls_DAL DAL
        {
            get
            {
                return s_DAL;
            }
        }

        /// <summary>
        /// Accesseur Modele
        /// </summary>
        public static cls_Modele Modele
        {
            get
            {
                return s_Modele;
            }
        }

        /// <summary>
        /// Accesseur Controlleur
        /// </summary>
        public static cls_Controlleur Controlleur
        {
            get
            {
                return s_Controlleur;
            }
        }
    }
}
