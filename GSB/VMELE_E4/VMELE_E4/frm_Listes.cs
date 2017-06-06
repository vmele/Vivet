
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;



namespace VMELE_E4
{
    public partial class frm_Listes : Form
    {
        public frm_Listes()
        {
            InitializeComponent();
            setupListeCommande();
            setupListeLignesCommande();
        }

        /// <summary>
        /// Fonction d'envoi de mail au support GSB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nouveauMailSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Outlook.Application outlookApp = new Outlook.Application();
                //Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.
                //    CreateItem(Outlook.OlItemType.olMailItem);
                //mailItem.Subject = Form.ActiveForm.Name;
                //mailItem.To = "contact@valentinmele.fr";
                //mailItem.Body = "This is the message.";
                //mailItem.Importance = Outlook.OlImportance.olImportanceLow;
                //mailItem.Display(false);
            }
            catch (Exception eX)
            {
                throw new Exception("cDocument: Error occurred trying to Create an " +
                    "Outlook Email" + Environment.NewLine + eX.Message);
            }
        }
        private void btn_ajouteLigne_Click(object sender, EventArgs e)
        {
            frm_DetailLignesCommande l_DetailLignesCommande = new frm_DetailLignesCommande();
            l_DetailLignesCommande.Show();
        }
        private void btn_ajouterCommande_Click(object sender, EventArgs e)
        {
            frm_DetailCommande l_detailCommande = new frm_DetailCommande();
            l_detailCommande.MdiParent = MDIParent.ActiveForm;
            l_detailCommande.Show();
        }

        /// <summary>
        /// Charge les bonnes liste en fonction du tabPage sélectionné. Les listes sont rechargées
        /// depuis le modèle à chaque changement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tctrl_Listes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tctrl_Listes.SelectedIndex)
            {
                // onglet des commandes
                case 0:
                    {
                        setupDgvListeCommandes(Program.Modele.ListeCommandes);
                    }
                    break;
                // onglet des lignes de commandes
                case 1:
                    {
                        setupDgvListeLignesCommande(Program.Modele.ListeLignesCommandes);
                    }
                    break;
            }

        }

        // ------
        // COMMANDE
        #region
        /// <summary>
        /// Charge les objets depuis le modèle et rempli la dgvCommande
        /// </summary>
        private void setupListeCommande()
        {
            // -------
            // Remplissage et autocomplétion cbx_EtatSo
            #region 
            cbx_soStatut.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_soStatut.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_ListeEtatSo = new AutoCompleteStringCollection();
            foreach (cls_EtatSo l_EtatSo in Program.Modele.ListeEtatSo.Values)
            {
                l_ListeEtatSo.Add(l_EtatSo.LibelleEtatSo);
                cbx_soStatut.Items.Add(l_EtatSo);

            }
            cbx_soStatut.AutoCompleteCustomSource = l_ListeEtatSo;
            #endregion

            // -------
            // Remplissage et autocomplétion cbx_Utilisateur
            #region        
            cbx_Utilisateur.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_Utilisateur.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_ListeUtilisateur = new AutoCompleteStringCollection();
            foreach (cls_Utilisateur l_Utilisateur in Program.Modele.ListeUtilisateurs.Values)
            {
                l_ListeUtilisateur.Add(l_Utilisateur.ToString());
                cbx_Utilisateur.Items.Add(l_Utilisateur);
            }
            cbx_Utilisateur.AutoCompleteCustomSource = l_ListeUtilisateur;
            #endregion

            // -------
            // Remplissage et autocomplétion cbx_Client       
            #region             
            cbx_Client.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_Client.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_ListeClients = new AutoCompleteStringCollection();
            foreach (cls_Client l_Client in Program.Modele.ListeClients.Values)
            {
                l_ListeClients.Add(l_Client.RaisonSociale);
                cbx_Client.Items.Add(l_Client);
            }
            cbx_Client.AutoCompleteCustomSource = l_ListeClients;
            #endregion

            // -------
            // Autocomplétion de la tbx_SoRefCommande
            #region        
            tbx_soRefCommande.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbx_soRefCommande.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_listeSoRefCommande = 
                new AutoCompleteStringCollection();
            foreach (cls_Commande l_Commande in Program.Modele.ListeCommandes.Values)
            {
                l_listeSoRefCommande.Add(l_Commande.RefCommande);
            }
            tbx_soRefCommande.AutoCompleteCustomSource = l_listeSoRefCommande;
            #endregion

            // -------
            // Remplissage DGV Liste Commandes
            setupDgvListeCommandes(Program.Modele.ListeCommandes);

            // -------
            // Met une valeur " " dans les DTP pour ne pas bloquer la saisie de filtres.
            clearDateTimePicker();


        }

        /// <summary>
        /// Charge et rempli le DGV liste Commandes
        /// </summary>
        /// <param name="pDicoCommandes">Dictionnaire de commandes</param>
        public void setupDgvListeCommandes(Dictionary<int, cls_Commande> pDicoCommandes)
        {
            
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Réf. Commande", typeof(string));
            table.Columns.Add("Etat", typeof(string));
            table.Columns.Add("Gestionnaire", typeof(string));
            table.Columns.Add("Client", typeof(string));
            table.Columns.Add("Date commmande", typeof(DateTime));
            table.Columns.Add("Date voulue", typeof(DateTime));
            table.Columns.Add("Montant total", typeof(string));

            foreach (cls_Commande l_Commande in pDicoCommandes.Values)
            {
                table.Rows.Add(l_Commande.getID(),
                    l_Commande.RefCommande,
                    l_Commande.Etat,
                    l_Commande.Utilisateur,
                    l_Commande.Client,
                    l_Commande.DateCommande,
                    l_Commande.DateVoulue,
                    l_Commande.calculMontantTotal());
            }
            dgv_listeCommandes.DataSource = table;
            dgv_listeCommandes.Columns[0].Visible = false;

        }

        /// <summary>
        /// Btn Rechercher selon les filtres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_soRechercher_Click(object sender, EventArgs e)
        {
            List<string> l_Conditions = new List<string>();
            l_Conditions.Clear();

            if (tbx_soRefCommande.Text != "")
            {
                // Plusieurs commandes possibles.
                l_Conditions.Add("cde.reference_commande ilike '%" + tbx_soRefCommande.Text + "%'");
            }
            if (cbx_Client.SelectedItem != null || cbx_Client.Text != "")
            {
                // On récupère le client de la cbx, on injecte son ID dans la requête.
                // Un seul client possible.
                cls_Client l_Client = (cls_Client)cbx_Client.SelectedItem;
                l_Conditions.Add("id_client = " + l_Client.getID());
            }
            if (cbx_soStatut.SelectedItem != null || cbx_soStatut.Text != "")
            {
                cls_EtatSo l_EtatSo = (cls_EtatSo)cbx_soStatut.SelectedItem;
                l_Conditions.Add("cde.id_etat = " + l_EtatSo.getID());
            }
            if (cbx_Utilisateur.SelectedItem != null || cbx_Utilisateur.Text != "")
            {
                cls_Utilisateur l_Utilisateur = (cls_Utilisateur)cbx_Utilisateur.SelectedItem;
                l_Conditions.Add("id_personne = " + l_Utilisateur.getID());
            }
            if (dtp_DateCommande.Text != " ")
            {
                l_Conditions.Add("date_commande = '" + dtp_DateCommande.Text + "'");
            }
            if (dtp_DateVoulue.Text != " ")
            {
                l_Conditions.Add("date_demandee = '" + dtp_DateVoulue.Text + "'");
            }

            // Select de la liste tampon.
            Program.Controlleur.selectCommandeConditions(l_Conditions);

            // Remplissage de la DGV avec une liste tampon.
            setupDgvListeCommandes(Program.Modele.ListeTamponCommandes);


                }

        /// <summary>
    /// Quand on sélectionne une valeur pour le DTP, la met au format dd/MM/yyy
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void dtp_DateCommande_ValueChanged(object sender, EventArgs e)
        {
            dtp_DateCommande.CustomFormat = "dd/MM/yyyy";
        }

        /// <summary>
        /// Quand on sélectionne une valeur pour le DTP, la met au format dd/MM/yyy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtp_DateVoulue_ValueChanged(object sender, EventArgs e)
        {
            dtp_DateVoulue.CustomFormat = "dd/MM/yyyy";
        }

        /// <summary>
        /// Clear les DTP
        /// </summary>
        private void clearDateTimePicker()
        {
            dtp_DateCommande.CustomFormat = " ";
            dtp_DateCommande.Format = DateTimePickerFormat.Custom;

            dtp_DateVoulue.CustomFormat = " ";
            dtp_DateVoulue.Format = DateTimePickerFormat.Custom;
        }

        /// <summary>
        /// Vide tous les filtres pour les commandes. Réinit le DGV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_soVider_Click(object sender, EventArgs e)
        {
            cbx_Client.SelectedIndex = -1;
            cbx_Utilisateur.SelectedIndex = -1;
            cbx_soStatut.SelectedIndex = -1;
            clearDateTimePicker();
            tbx_soRefCommande.Text = "";
            setupDgvListeCommandes(Program.Modele.ListeCommandes);

        }
        #endregion


        // ------
        // LIGNE DE COMMANDE
        #region
        /// <summary>
        /// Charge les objets depuis le modèle et rempli la dgvLigneCommande
        /// </summary>
        private void setupListeLignesCommande()
        {
            // -------
            // Remplissage et autocomplétion de la cbx_Produit
            #region
            cbx_Produits.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_Produits.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_ListeProduits = new AutoCompleteStringCollection();
            foreach (cls_Produit l_Produit in Program.Modele.ListeProduits.Values)
            {
                l_ListeProduits.Add(l_Produit.LibelleProduit);
                cbx_Produits.Items.Add(l_Produit);
            }
            cbx_Produits.AutoCompleteCustomSource = l_ListeProduits;
            #endregion

            // -------
            // Remplissage et autocomplétion de la cbx_Tva
            #region 
            cbx_tva.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_tva.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_ListeTva = new AutoCompleteStringCollection();
            foreach (cls_Tva l_tva in Program.Modele.ListeTva.Values)
            {
                l_ListeTva.Add(Convert.ToString(l_tva.TauxTva));
                cbx_tva.Items.Add(l_tva);
            }
            cbx_tva.AutoCompleteCustomSource = l_ListeTva;
            #endregion

            // -------
            // Remplissage et autocomplétion de la cbx_EtatSol
            #region 
            cbx_solStatut.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_solStatut.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_ListeEtatSol = new AutoCompleteStringCollection();
            foreach (cls_EtatSol l_EtatSol in Program.Modele.ListeEtatSol.Values)
            {
                l_ListeEtatSol.Add(l_EtatSol.LibelleEtatSol);
                cbx_solStatut.Items.Add(l_EtatSol);
            }
            cbx_solStatut.AutoCompleteCustomSource = l_ListeEtatSol;
            #endregion

            // -------
            // Remplissage et autocomplétion de la cbx_RefCommande
            #region 
            tbx_solRefCommande.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbx_solRefCommande.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_ListeRefSol = new AutoCompleteStringCollection();
            foreach (cls_Commande l_Commande in Program.Modele.ListeCommandes.Values)
            {
                l_ListeRefSol.Add(l_Commande.RefCommande);
            }
            tbx_solRefCommande.AutoCompleteCustomSource = l_ListeRefSol;
            #endregion

            // -------
            // Remplissage DGV Liste Commandes
            setupDgvListeLignesCommande(Program.Modele.ListeLignesCommandes);

        }

        public void setupDgvListeLignesCommande(Dictionary<int, cls_LigneCommande> 
            pDicoLignesCommande)
        {

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Réf. Commande", typeof(string));
            table.Columns.Add("Numéro ligne", typeof(string));
            table.Columns.Add("Etat", typeof(string));
            table.Columns.Add("Produit", typeof(string));
            table.Columns.Add("Quantité", typeof(int));
            table.Columns.Add("Prix cdt", typeof(string));
            table.Columns.Add("Montant", typeof(string));

            foreach (cls_LigneCommande l_LigneCommande in pDicoLignesCommande.Values)
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

            dgv_listeLignesCommande.DataSource = table;
            dgv_listeLignesCommande.Columns[0].Visible = false;
        }
        private void btn_solVider_Click(object sender, EventArgs e)
        {
            cbx_Produits.SelectedIndex = -1;
            cbx_solStatut.SelectedIndex = -1; ;
            cbx_tva.SelectedIndex = -1;
            tbx_noSol.Text = "";
            tbx_quantite.Text = "";
            tbx_solRefCommande.Text = "";
            setupDgvListeLignesCommande(Program.Modele.ListeLignesCommandes);
        }
        private void btn_solRechercher_Click(object sender, EventArgs e)
        {
            List<string> l_Conditions = new List<string>();

            // Numéro de ligne
            if (tbx_noSol.Text != "")
            {
                l_Conditions.Add("numero_ligne = " + tbx_noSol.Text);
            }
            // Quantité
            if (tbx_quantite.Text != "")
            {
                l_Conditions.Add("quantite =" + tbx_quantite.Text);
            }
            // Produit
            if (cbx_Produits.SelectedItem != null || cbx_Produits.Text != "")
            {
                cls_Produit l_Produit = (cls_Produit)cbx_Produits.SelectedItem;
                l_Conditions.Add("id_produit = " + l_Produit.getID());
            }
            // Ref commande
            if (tbx_solRefCommande.Text != "")
            {
                l_Conditions.Add("commande.reference_commande::text ilike '%" + 
                    tbx_solRefCommande.Text + "%'");
            }
            // Etat SOL
            if (cbx_solStatut.SelectedItem != null || cbx_solStatut.Text != "")
            {
                cls_EtatSol l_EtatSol = (cls_EtatSol)cbx_solStatut.SelectedItem;
                l_Conditions.Add("ligne_de_commande.id_etat = " + l_EtatSol.getID());
            }
            // TVA
            if (cbx_tva.SelectedItem != null || cbx_tva.Text != "")
            {
                cls_Tva l_TVA = (cls_Tva)cbx_tva.SelectedItem;
                l_Conditions.Add("ligne_de_commande.id_tva = " + l_TVA.getID());
            }

            if (l_Conditions.Count != 0)
            {
                // Select de la liste tampon.
                try
                {
                    Program.Controlleur.selectLignesCommandeConditions(l_Conditions);

                }
                catch (Exception)
                {

                    MessageBox.Show("La recherche n'a pas pu être effectuée. " +
                        "Veuillez réésayer ou contacter le support utilisateur.",
                        "Erreur de recherche.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Remplissage de la DGV avec une liste tampon.
                setupDgvListeLignesCommande(Program.Modele.ListeLignesTamponCommandes);
            }
        }
        #endregion


        private void dgv_listeCommandes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int databaseRecordId = (int)dgv_listeCommandes.Rows[e.RowIndex].Cells[0].Value;
            frm_DetailCommande l_detailCommande = new frm_DetailCommande(databaseRecordId);
            l_detailCommande.Show();
        }

        private void dgv_listeLignesCommande_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int databaseRecordId = (int)dgv_listeLignesCommande.Rows[e.RowIndex].Cells[0].Value;
            frm_DetailLignesCommande l_detailLignesCommande = new frm_DetailLignesCommande(databaseRecordId);
            l_detailLignesCommande.Show();
        }
    }
}
