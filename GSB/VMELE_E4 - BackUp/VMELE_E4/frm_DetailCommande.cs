using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace VMELE_E4
{
    public partial class frm_DetailCommande : Form
    {
        public frm_DetailCommande()
        {
            InitializeComponent();
            setupProgressBar();
            setupAjoutCommande();
        }

        private void nouveauMailSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                //Outlook.Application outlookApp = new Outlook.Application();
                //Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
                //mailItem.Subject = Form.ActiveForm.Name;
                //mailItem.To = "contact@valentinmele.fr";
                //mailItem.Body = "This is the message.";
                //mailItem.Importance = Outlook.OlImportance.olImportanceLow;
                //mailItem.Display(false);
            }
            catch (Exception eX)
            {
                throw new Exception("cDocument: Error occurred trying to Create an Outlook Email"
                                    + Environment.NewLine + eX.Message);
            }
        }

        /// <summary>
        /// A VOIR COMMENT GERER LA VUE L AJOUT ET LA MODIF DE COMMANDE
        /// </summary>
        private void setupDetailCommande()
        {
            if (true)
            {

            }
        }


        private void setupAjoutCommande()
        {
            // -------
            // Remplissage tbx_RefCommande
            #region 
            #endregion

            // -------
            // Remplissage et autocomplétion tbx_client
            #region        
            tbx_client.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbx_client.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_ListeClient = new AutoCompleteStringCollection();
            foreach (cls_Client l_Client in Program.Modele.ListeClients.Values)
            {
                l_ListeClient.Add(l_Client.ToString());
            }
            tbx_client.AutoCompleteCustomSource = l_ListeClient;
           
            #endregion

            // -------
            // Remplissage et autocomplétion cbx_MoyenContact  
            #region             
            cbx_moyenContact.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_moyenContact.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_ListeMoyenContact = new AutoCompleteStringCollection();
            foreach (cls_MoyenContact l_MoyenContact in Program.Modele.ListeMoyensContact.Values)
            {
                l_ListeMoyenContact.Add(l_MoyenContact.LibelleContact);
                cbx_moyenContact.Items.Add(l_MoyenContact);
            }
            cbx_moyenContact.AutoCompleteCustomSource = l_ListeMoyenContact;

            #endregion

            // -------
            // Autocomplétion de la cbx_TypeCommande
            #region        
            cbx_typeCommande.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_typeCommande.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_ListeType =
                new AutoCompleteStringCollection();
            foreach (cls_TypeCommande l_Type in Program.Modele.ListeTypesCommandes.Values)
            {
                l_ListeType.Add(l_Type.LibelleType);
                cbx_typeCommande.Items.Add(l_Type);
            }
            cbx_typeCommande.AutoCompleteCustomSource = l_ListeType;
            #endregion

            // -------
            // Custom DateTime Picker
            clearDateTimePicker();
            dtp_dateCommande.Value = DateTime.Today;

            // -------
            // Set du Progress bar à Devis
            pgb_statutCommande.Value = 1;

            // -------
            // Set GC à l'utilisateur connecté
            tbx_gestionnaireCommande.Text = frm_Connexion.Utilisateur.ToString();
        }


        private void setupProgressBar()
        {
            pgb_statutCommande.Style = ProgressBarStyle.Continuous;
            pgb_statutCommande.Maximum = 4;
            pgb_statutCommande.Value = 0;

        }

        /// <summary>
        /// Clear les DTP
        /// </summary>
        private void clearDateTimePicker()
        {
            dtp_dateCommande.CustomFormat = " ";
            dtp_dateCommande.Format = DateTimePickerFormat.Custom;

            dtp_dateDemandee.CustomFormat = " ";
            dtp_dateDemandee.Format = DateTimePickerFormat.Custom;
        }

        /// <summary>
        /// Quand on sélectionne une valeur pour le DTP, la met au format dd/MM/yyy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtp_dateDemandee_ValueChanged(object sender, EventArgs e)
        {
            dtp_dateDemandee.CustomFormat = "dd/MM/yyyy";

        }

        /// <summary>
        /// Quand on sélectionne une valeur pour le DTP, la met au format dd/MM/yyy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtp_dateCommande_ValueChanged_1(object sender, EventArgs e)
        {
            dtp_dateCommande.CustomFormat = "dd/MM/yyyy";

        }

        private void btn_enregistrerFermer_Click(object sender, EventArgs e)
        {
            cls_Commande l_Commande = null;

            cls_TypeCommande l_Type = (cls_TypeCommande) cbx_typeCommande.SelectedItem;
            int l_idType = l_Type.getID();

            int l_idCommande = cls_ObjetBase.NouvelId();
            string l_RefCommande = l_Type.LibelleCourt + "00" + l_idCommande;

            DateTime l_DateCommande = dtp_dateCommande.Value;

            DateTime l_DateVoulue = dtp_dateDemandee.Value;

            cls_MoyenContact l_Contact = (cls_MoyenContact)cbx_moyenContact.SelectedItem;
            int l_idContact = l_Contact.getID();

            int l_idUtilisateur = frm_Connexion.Utilisateur.getID();

            int l_idClient = 0;
            foreach (cls_Client l_Client in Program.Modele.ListeClients.Values)
            {
                if (l_Client.RaisonSociale == tbx_client.Text)
                {
                    l_idClient = l_Client.getID();
                }
            }

            int l_idEtat = 1;

            l_Commande = new cls_Commande(l_idCommande, l_RefCommande, 
                l_DateCommande, l_DateVoulue, l_idClient, l_idContact, l_idEtat, 
                l_idUtilisateur, l_idType);
            Program.Controlleur.ajoutCommande(l_Commande);
        }
    }

}
