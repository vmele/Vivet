using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMELE_E4
{
    static class Program
    {

        static cls_Controlleur s_Controlleur;
        static DAL s_DAL;
        static cls_Modele s_Modele;


        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Connexion());
        }

        static Program()
        {
            s_Controlleur = new cls_Controlleur();
            s_Modele = new cls_Modele();
            s_DAL = new DAL("localhost", "postgres", "postgres");
            s_Controlleur.chargerModele();

        }

        public static cls_Controlleur Controlleur
        {
            get
            {
                return s_Controlleur;
            }
        }
        public static DAL DAL
        {
            get
            {
                return s_DAL;
            }
        }
        public static cls_Modele Modele
        {
            get
            {
                return s_Modele;
            }
        }
    }
}
