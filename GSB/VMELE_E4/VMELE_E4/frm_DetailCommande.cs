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
        private string c_Setup;
        private int c_IDCommande = -1;

        public frm_DetailCommande(int pIdCommande = -1)
        {
            InitializeComponent();
            c_IDCommande = pIdCommande;
            setupProgressBar();
            setupDetailCommande();

        }


        /// <summary>
        /// A VOIR COMMENT GERER LA VUE L AJOUT ET LA MODIF DE COMMANDE
        /// </summary>
        private void setupDetailCommande()
        {
            if (c_IDCommande != -1)
            {
                setupModifCommande();
                c_Setup = "Modif";
            }
            else
            {
                setupAjoutCommande();
                c_Setup = "Ajout";
            }
        }

        private void setupModifCommande()
        {
            tbx_refCommande.ReadOnly = true;
            tbx_gestionnaireCommande.ReadOnly = true;

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


            cls_Commande l_Commande = Program.Modele.ListeCommandes[c_IDCommande];

            // -------
            // Remplissage datagridview
            #region
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Réf. Commande", typeof(string));
            table.Columns.Add("Numéro ligne", typeof(string));
            table.Columns.Add("Etat", typeof(string));
            table.Columns.Add("Produit", typeof(string));
            table.Columns.Add("Quantité", typeof(int));
            table.Columns.Add("Prix cdt", typeof(string));
            table.Columns.Add("Montant", typeof(string));

            foreach (cls_LigneCommande l_LigneCommande in l_Commande.ListeLignesCommande)
            {
                table.Rows.Add(l_LigneCommande.getID(),
                    l_LigneCommande.Commande.RefCommande,
                    l_LigneCommande.NumeroLigne,
                    l_LigneCommande.Etat,
                    l_LigneCommande.Produit,
                    l_LigneCommande.Quantite,
                    l_LigneCommande.Produit.PrixConditionne + " €",
                    l_LigneCommande.calculTotal() + " €");
            }
            dgv_lignesCommande.DataSource = table;
            dgv_lignesCommande.Columns[0].Visible = false;
            #endregion


            dtp_dateCommande.Value = l_Commande.DateCommande;
            dtp_dateDemandee.Value = l_Commande.DateCommande;

            tbx_refCommande.Text = l_Commande.RefCommande;
            tbx_gestionnaireCommande.Text = Program.Modele.ListeUtilisateurs[l_Commande.Utilisateur.getID()].ToString();
            tbx_client.Text = Program.Modele.ListeClients[l_Commande.Client.getID()].ToString();
            cbx_moyenContact.SelectedItem = Program.Modele.ListeMoyensContact[l_Commande.MoyenContact.getID()];
            cbx_typeCommande.SelectedItem = Program.Modele.ListeTypesCommandes[l_Commande.TypeCommande.getID()];

            pgb_statutCommande.Value = l_Commande.Etat.getID();
            lbl_StatutCommande.Text = Program.Modele.ListeEtatSo[l_Commande.Etat.getID()].ToString();
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

            tbx_refCommande.ReadOnly = true;
            tbx_gestionnaireCommande.ReadOnly = true;
            lbl_StatutCommande.Text = "Devis";

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
            if (c_Setup == "Ajout")
            {
                cls_Commande l_Commande = null;

                cls_TypeCommande l_Type = (cls_TypeCommande)cbx_typeCommande.SelectedItem;

                int l_idCommande = cls_ObjetBase.NouvelId();
                string l_RefCommande = l_Type.LibelleCourt + "00" + l_idCommande;

                DateTime l_DateCommande = dtp_dateCommande.Value;
                DateTime l_DateVoulue = dtp_dateDemandee.Value;

                cls_MoyenContact l_Contact = (cls_MoyenContact)cbx_moyenContact.SelectedItem;

                cls_Utilisateur l_Utilisateur = Program.Modele.ListeUtilisateurs[frm_Connexion.Utilisateur.getID()];

                cls_Client l_Client = null;
                foreach (cls_Client l_ClientListe in Program.Modele.ListeClients.Values)
                {
                    if (l_ClientListe.RaisonSociale == tbx_client.Text)
                    {
                        l_Client = Program.Modele.ListeClients[l_ClientListe.getID()];
                    }
                }

                int l_idEtat = 1;
                cls_EtatSo l_Etat = Program.Modele.ListeEtatSo[l_idEtat];

                l_Commande = new cls_Commande(l_idCommande, l_RefCommande,
                    l_DateCommande, l_DateVoulue, l_Client, l_Contact, l_Etat,
                    l_Utilisateur, l_Type);
                Program.Controlleur.ajoutCommande(l_Commande);
            }
            else
            {
                // TODO : Voir pourquoi les cbx et tbx ne prennent pas la nouvelle valeur.
                cls_Commande l_Commande = Program.Modele.ListeCommandes[c_IDCommande];

                cls_TypeCommande l_TypeCommande = (cls_TypeCommande)cbx_typeCommande.SelectedItem;
                l_Commande.TypeCommande = l_TypeCommande;

                l_Commande.DateCommande = dtp_dateCommande.Value;
                l_Commande.DateVoulue = dtp_dateDemandee.Value;

                cls_MoyenContact l_Contact = (cls_MoyenContact)cbx_moyenContact.SelectedItem;
                l_Commande.MoyenContact = l_Contact;

                foreach (cls_Client l_Client in Program.Modele.ListeClients.Values)
                {
                    if (l_Client.RaisonSociale == tbx_client.Text)
                    {
                        l_Commande.Client = l_Client;
                    }
                }

                Program.Controlleur.modifCommande(l_Commande);
            }

            Close();
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
    }

}
