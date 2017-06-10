using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace VMELE_E4
{
    public partial class frm_Connexion : Form
    {
        private int i = 0;
        private bool test = true;
        static cls_Utilisateur s_CurrentUser;

        public frm_Connexion()
        {
            InitializeComponent();
            setupUserList();
        }

        /// <summary>
        /// Clic du bouton connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Connection_Click(object sender, EventArgs e)
        {
            cls_Utilisateur l_Utilisateur = (cls_Utilisateur)cbx_login.SelectedItem;

            if (test) //tbx_pw.Text == l_Utilisateur.MotDePasse ||)
            {
                MDIParent l_MDIParent = new MDIParent();
                l_MDIParent.Show();
                this.Hide();
                // Variable de "SESSION"
                s_CurrentUser = l_Utilisateur;
            }
            else
            {
                MessageBox.Show("Le mot de passe saisi est invalide.", "Erreur",
                     MessageBoxButtons.OK, MessageBoxIcon.Error); 
            } 
        }

        /// <summary>
        /// Rempli la cbx Login + auto complétion
        /// </summary>
        private void setupUserList()
        {
            // -------
            // Remplissage cbx_login
            foreach (cls_Utilisateur l_Utilisateur in Program.Modele.ListeUtilisateurs.Values)
            {
                cbx_login.Items.Add(l_Utilisateur);
            }

            // -------
            // Autocomplétion de la tbx_login
            #region        
            cbx_login.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_login.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_listeLogin = new AutoCompleteStringCollection();
            foreach (cls_Utilisateur l_Utilisateur in Program.Modele.ListeUtilisateurs.Values)
            {
                l_listeLogin.Add(l_Utilisateur.Login.ToUpper());
            }
            cbx_login.AutoCompleteCustomSource = l_listeLogin;
            #endregion
        }

        /// <summary>
        /// Check si Entrer est pressé dans le mot de passe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Connection.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void cbx_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Connection.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        /// <summary>
        /// Ecrit dans cbx_Login direct en majuscule.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_login_TextChanged(object sender, EventArgs e)
        {
            cbx_login.Text = cbx_login.Text.ToUpper();
            cbx_login.SelectionStart = cbx_login.Text.Length;
        }

        public static cls_Utilisateur Utilisateur
        {
            get
            {
                return s_CurrentUser;
            }
        }

    }
}
