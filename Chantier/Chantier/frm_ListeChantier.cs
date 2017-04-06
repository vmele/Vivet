using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chantier
{
    public partial class frm_ListeChantier : Form
    {
        
        /// <summary>
        /// Constructeur de la frm_ListeChantier
        /// </summary>
        public frm_ListeChantier()
        {
            InitializeComponent();
            CreationDesObjets(Program.Modele);
            SetupListBox();
        }

        /// <summary>
        /// Appel pour remplir les deux listes.
        /// </summary>
        /// <param name="pModele">Appelle la classe Cls_Modele qui comporte les dictionnaires</param>
        private void CreationDesObjets(cls_Modele pModele)
        {
            pModele.ListeClient = cls_DAL_Client.CreerListeClient();
            pModele.ListeChantier = cls_DAL_Chantier.CreerListeChantier();
        }
       
        /// <summary>
        /// Rempli la listBox des chantiers
        /// </summary>
        public void SetupListBox()
        {
            lsb_ListeChantier.Items.Clear();
            //Remplissage ListeBox
            foreach (cls_Chantier l_Chantier in Program.Modele.ListeChantier.Values)
            {
                lsb_ListeChantier.Items.Add(l_Chantier);
            }
        }

        /// <summary>
        /// Double clic sur un chantier ouvre une nouvelle form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsb_ListeChantier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cls_Chantier l_ChantierChoisi = (cls_Chantier)lsb_ListeChantier.SelectedItem;
            int index = this.lsb_ListeChantier.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                frm_DetailChantier l_DetailChantier = new frm_DetailChantier(l_ChantierChoisi);
                l_DetailChantier.ShowDialog();
            }
        }

        /// <summary>
        /// Clic sur Edition Chantier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EditionChantier_Click(object sender, EventArgs e)
        {
            cls_Chantier l_ChantierChoisi = (cls_Chantier)lsb_ListeChantier.SelectedItem;
            // l_frmListeChantier est la form ListeChantier, on la passe en paramètre d'EditChantier pour utiliser 
            // SetupListBox dans cette dernière.
            frm_ListeChantier l_frmListeChantier = (frm_ListeChantier)frm_ListeChantier.ActiveForm;
            frm_EditChantier l_EditChantier = new frm_EditChantier(l_ChantierChoisi, l_frmListeChantier);
            l_EditChantier.Show();
        }

        /// <summary>
        /// Clic sur Edition Client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EditionClient_Click(object sender, EventArgs e)
        {
            frm_EditClient l_EditClient = new frm_EditClient();
            l_EditClient.Show();
        }

        /// <summary>
        /// Petit menu en haut pour sauvegarder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int compteur = 0;
            
            // Try de l'ajout en base
            try
            {
                Program.Controlleur.AjoutBaseTampon(Program.Controlleur.ListeAjoutTampon);
                Program.Controlleur.ListeAjoutTampon.Clear();
                compteur += 1;

            }
            catch (Exception)
            {

                MessageBox.Show("Impossible de réaliser cet ajout en base.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Try de la modif en base
            try
            {
                Program.Controlleur.ModifBaseTampon(Program.Controlleur.ListeModifTampon);
                Program.Controlleur.ListeModifTampon.Clear();
                compteur += 1;
            }
            catch (Exception)
            {

                MessageBox.Show("Impossible de réaliser cette modification en base.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Try de la suppr en base
            try
            {
                Program.Controlleur.SupprBaseTampon(Program.Controlleur.ListeSupprTampon);
                Program.Controlleur.ListeSupprTampon.Clear();
                compteur += 1;
            }
            catch (Exception)
            {

                MessageBox.Show("Impossible de réaliser cette suppression (vérifiez que le client / chantier existe toujours).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Si tout les try sont passés, alors la sauvegarde est réussie.
            if (compteur == 3)
            {
                MessageBox.Show("Sauvegarde réussie !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
