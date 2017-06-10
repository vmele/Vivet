using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace VMELE_E4
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Connexion l_FrmConnexion = new frm_Connexion();
            l_FrmConnexion.Show();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void listeDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Listes l_listeCommande = new frm_Listes();
            l_listeCommande.MdiParent = this;
            l_listeCommande.Show();
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            // Ouvre la frm_Listes directement
            frm_Listes l_listeCommande = new frm_Listes();
            l_listeCommande.MdiParent = this;
            l_listeCommande.Show();
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DetailCommande l_frmCommande = new frm_DetailCommande();
            l_frmCommande.ShowDialog();
        }

        private void ligneDeCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DetailLignesCommande l_frmLigne = new frm_DetailLignesCommande();
            l_frmLigne.ShowDialog();

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void mailSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Outlook.Application outlookApp = new Microsoft.Office.Interop.Outlook.Application();
                Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp
                    .CreateItem(Outlook.OlItemType.olMailItem);
                mailItem.Subject = Form.ActiveForm.Name;
                mailItem.To = "valmele@hotmail.fr";
                mailItem.Body = "";
                mailItem.Subject = "";
                mailItem.Importance = Outlook.OlImportance.olImportanceHigh;
                mailItem.Display(false);
            }
            catch (Exception eX)
            {
                throw new Exception("cDocument: Error occurred trying to Create an " +
                    "Outlook Email" + Environment.NewLine + eX.Message);
            }
        }
    }
}
