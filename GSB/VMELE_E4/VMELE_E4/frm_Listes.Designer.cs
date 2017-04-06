namespace VMELE_E4
{
    partial class frm_Listes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tctrl_Listes = new System.Windows.Forms.TabControl();
            this.tpg_listeCommandes = new System.Windows.Forms.TabPage();
            this.cbx_Client = new System.Windows.Forms.ComboBox();
            this.dgv_listeCommandes = new System.Windows.Forms.DataGridView();
            this.btn_ajouterCommande = new System.Windows.Forms.Button();
            this.btn_soRechercher = new System.Windows.Forms.Button();
            this.btn_soVider = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_DateVoulue = new System.Windows.Forms.DateTimePicker();
            this.cbx_Utilisateur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_DateCommande = new System.Windows.Forms.DateTimePicker();
            this.cbx_soStatut = new System.Windows.Forms.ComboBox();
            this.tbx_soRefCommande = new System.Windows.Forms.TextBox();
            this.tpg_listeLignesCommande = new System.Windows.Forms.TabPage();
            this.tbx_solRefCommande = new System.Windows.Forms.TextBox();
            this.cbx_Produits = new System.Windows.Forms.ComboBox();
            this.lbl_tva = new System.Windows.Forms.Label();
            this.cbx_tva = new System.Windows.Forms.ComboBox();
            this.btn_ajouteLigne = new System.Windows.Forms.Button();
            this.btn_solRechercher = new System.Windows.Forms.Button();
            this.btn_solVider = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_quantite = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbx_noSol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx_solStatut = new System.Windows.Forms.ComboBox();
            this.dgv_listeLignesCommande = new System.Windows.Forms.DataGridView();
            this.raxonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.raxon = new VMELE_E4.raxon();
            this.raxonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tctrl_Listes.SuspendLayout();
            this.tpg_listeCommandes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeCommandes)).BeginInit();
            this.tpg_listeLignesCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeLignesCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raxonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raxon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raxonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tctrl_Listes
            // 
            this.tctrl_Listes.Controls.Add(this.tpg_listeCommandes);
            this.tctrl_Listes.Controls.Add(this.tpg_listeLignesCommande);
            this.tctrl_Listes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrl_Listes.Location = new System.Drawing.Point(0, 0);
            this.tctrl_Listes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tctrl_Listes.Name = "tctrl_Listes";
            this.tctrl_Listes.SelectedIndex = 0;
            this.tctrl_Listes.Size = new System.Drawing.Size(944, 719);
            this.tctrl_Listes.TabIndex = 0;
            this.tctrl_Listes.SelectedIndexChanged += new System.EventHandler(this.tctrl_Listes_SelectedIndexChanged);
            // 
            // tpg_listeCommandes
            // 
            this.tpg_listeCommandes.Controls.Add(this.cbx_Client);
            this.tpg_listeCommandes.Controls.Add(this.dgv_listeCommandes);
            this.tpg_listeCommandes.Controls.Add(this.btn_ajouterCommande);
            this.tpg_listeCommandes.Controls.Add(this.btn_soRechercher);
            this.tpg_listeCommandes.Controls.Add(this.btn_soVider);
            this.tpg_listeCommandes.Controls.Add(this.label6);
            this.tpg_listeCommandes.Controls.Add(this.label5);
            this.tpg_listeCommandes.Controls.Add(this.label4);
            this.tpg_listeCommandes.Controls.Add(this.label3);
            this.tpg_listeCommandes.Controls.Add(this.label2);
            this.tpg_listeCommandes.Controls.Add(this.dtp_DateVoulue);
            this.tpg_listeCommandes.Controls.Add(this.cbx_Utilisateur);
            this.tpg_listeCommandes.Controls.Add(this.label1);
            this.tpg_listeCommandes.Controls.Add(this.dtp_DateCommande);
            this.tpg_listeCommandes.Controls.Add(this.cbx_soStatut);
            this.tpg_listeCommandes.Controls.Add(this.tbx_soRefCommande);
            this.tpg_listeCommandes.Location = new System.Drawing.Point(4, 25);
            this.tpg_listeCommandes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpg_listeCommandes.Name = "tpg_listeCommandes";
            this.tpg_listeCommandes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpg_listeCommandes.Size = new System.Drawing.Size(936, 690);
            this.tpg_listeCommandes.TabIndex = 0;
            this.tpg_listeCommandes.Text = "Liste des commandes";
            this.tpg_listeCommandes.UseVisualStyleBackColor = true;
            // 
            // cbx_Client
            // 
            this.cbx_Client.FormattingEnabled = true;
            this.cbx_Client.Location = new System.Drawing.Point(304, 44);
            this.cbx_Client.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Client.Name = "cbx_Client";
            this.cbx_Client.Size = new System.Drawing.Size(121, 24);
            this.cbx_Client.TabIndex = 3;
            // 
            // dgv_listeCommandes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgv_listeCommandes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_listeCommandes.AutoGenerateColumns = false;
            this.dgv_listeCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeCommandes.DataMember = "ListeCommandes";
            this.dgv_listeCommandes.DataSource = this.raxon;
            this.dgv_listeCommandes.Location = new System.Drawing.Point(21, 138);
            this.dgv_listeCommandes.Name = "dgv_listeCommandes";
            this.dgv_listeCommandes.ReadOnly = true;
            this.dgv_listeCommandes.RowTemplate.Height = 24;
            this.dgv_listeCommandes.Size = new System.Drawing.Size(902, 488);
            this.dgv_listeCommandes.TabIndex = 42;
            this.dgv_listeCommandes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_listeCommandes_CellMouseDoubleClick);
            // 
            // btn_ajouterCommande
            // 
            this.btn_ajouterCommande.Location = new System.Drawing.Point(783, 6);
            this.btn_ajouterCommande.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ajouterCommande.Name = "btn_ajouterCommande";
            this.btn_ajouterCommande.Size = new System.Drawing.Size(141, 23);
            this.btn_ajouterCommande.TabIndex = 9;
            this.btn_ajouterCommande.Text = "Créer commande";
            this.btn_ajouterCommande.UseVisualStyleBackColor = true;
            this.btn_ajouterCommande.Click += new System.EventHandler(this.btn_ajouterCommande_Click);
            // 
            // btn_soRechercher
            // 
            this.btn_soRechercher.Location = new System.Drawing.Point(195, 110);
            this.btn_soRechercher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_soRechercher.Name = "btn_soRechercher";
            this.btn_soRechercher.Size = new System.Drawing.Size(141, 23);
            this.btn_soRechercher.TabIndex = 8;
            this.btn_soRechercher.Text = "Rechercher";
            this.btn_soRechercher.UseVisualStyleBackColor = true;
            this.btn_soRechercher.Click += new System.EventHandler(this.btn_soRechercher_Click);
            // 
            // btn_soVider
            // 
            this.btn_soVider.Location = new System.Drawing.Point(21, 110);
            this.btn_soVider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_soVider.Name = "btn_soVider";
            this.btn_soVider.Size = new System.Drawing.Size(136, 23);
            this.btn_soVider.TabIndex = 7;
            this.btn_soVider.Text = "Vider les filtres";
            this.btn_soVider.UseVisualStyleBackColor = true;
            this.btn_soVider.Click += new System.EventHandler(this.btn_soVider_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date demandée";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date commande";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "GC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Statut";
            // 
            // dtp_DateVoulue
            // 
            this.dtp_DateVoulue.Location = new System.Drawing.Point(595, 110);
            this.dtp_DateVoulue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_DateVoulue.Name = "dtp_DateVoulue";
            this.dtp_DateVoulue.Size = new System.Drawing.Size(200, 22);
            this.dtp_DateVoulue.TabIndex = 6;
            this.dtp_DateVoulue.ValueChanged += new System.EventHandler(this.dtp_DateVoulue_ValueChanged);
            // 
            // cbx_Utilisateur
            // 
            this.cbx_Utilisateur.FormattingEnabled = true;
            this.cbx_Utilisateur.Location = new System.Drawing.Point(445, 46);
            this.cbx_Utilisateur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Utilisateur.Name = "cbx_Utilisateur";
            this.cbx_Utilisateur.Size = new System.Drawing.Size(121, 24);
            this.cbx_Utilisateur.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Réf. commande";
            // 
            // dtp_DateCommande
            // 
            this.dtp_DateCommande.Location = new System.Drawing.Point(595, 48);
            this.dtp_DateCommande.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_DateCommande.Name = "dtp_DateCommande";
            this.dtp_DateCommande.Size = new System.Drawing.Size(200, 22);
            this.dtp_DateCommande.TabIndex = 5;
            this.dtp_DateCommande.ValueChanged += new System.EventHandler(this.dtp_DateCommande_ValueChanged);
            // 
            // cbx_soStatut
            // 
            this.cbx_soStatut.FormattingEnabled = true;
            this.cbx_soStatut.Location = new System.Drawing.Point(149, 46);
            this.cbx_soStatut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_soStatut.Name = "cbx_soStatut";
            this.cbx_soStatut.Size = new System.Drawing.Size(121, 24);
            this.cbx_soStatut.TabIndex = 2;
            // 
            // tbx_soRefCommande
            // 
            this.tbx_soRefCommande.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbx_soRefCommande.Location = new System.Drawing.Point(21, 46);
            this.tbx_soRefCommande.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_soRefCommande.Name = "tbx_soRefCommande";
            this.tbx_soRefCommande.Size = new System.Drawing.Size(100, 22);
            this.tbx_soRefCommande.TabIndex = 1;
            // 
            // tpg_listeLignesCommande
            // 
            this.tpg_listeLignesCommande.Controls.Add(this.tbx_solRefCommande);
            this.tpg_listeLignesCommande.Controls.Add(this.cbx_Produits);
            this.tpg_listeLignesCommande.Controls.Add(this.lbl_tva);
            this.tpg_listeLignesCommande.Controls.Add(this.cbx_tva);
            this.tpg_listeLignesCommande.Controls.Add(this.btn_ajouteLigne);
            this.tpg_listeLignesCommande.Controls.Add(this.btn_solRechercher);
            this.tpg_listeLignesCommande.Controls.Add(this.btn_solVider);
            this.tpg_listeLignesCommande.Controls.Add(this.label7);
            this.tpg_listeLignesCommande.Controls.Add(this.tbx_quantite);
            this.tpg_listeLignesCommande.Controls.Add(this.label13);
            this.tpg_listeLignesCommande.Controls.Add(this.tbx_noSol);
            this.tpg_listeLignesCommande.Controls.Add(this.label10);
            this.tpg_listeLignesCommande.Controls.Add(this.label11);
            this.tpg_listeLignesCommande.Controls.Add(this.label12);
            this.tpg_listeLignesCommande.Controls.Add(this.cbx_solStatut);
            this.tpg_listeLignesCommande.Controls.Add(this.dgv_listeLignesCommande);
            this.tpg_listeLignesCommande.Location = new System.Drawing.Point(4, 25);
            this.tpg_listeLignesCommande.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpg_listeLignesCommande.Name = "tpg_listeLignesCommande";
            this.tpg_listeLignesCommande.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpg_listeLignesCommande.Size = new System.Drawing.Size(936, 690);
            this.tpg_listeLignesCommande.TabIndex = 1;
            this.tpg_listeLignesCommande.Text = "Liste des lignes de commande";
            this.tpg_listeLignesCommande.UseVisualStyleBackColor = true;
            // 
            // tbx_solRefCommande
            // 
            this.tbx_solRefCommande.Location = new System.Drawing.Point(22, 34);
            this.tbx_solRefCommande.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_solRefCommande.Name = "tbx_solRefCommande";
            this.tbx_solRefCommande.Size = new System.Drawing.Size(104, 22);
            this.tbx_solRefCommande.TabIndex = 1;
            // 
            // cbx_Produits
            // 
            this.cbx_Produits.FormattingEnabled = true;
            this.cbx_Produits.Location = new System.Drawing.Point(183, 89);
            this.cbx_Produits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Produits.Name = "cbx_Produits";
            this.cbx_Produits.Size = new System.Drawing.Size(320, 24);
            this.cbx_Produits.TabIndex = 5;
            // 
            // lbl_tva
            // 
            this.lbl_tva.AutoSize = true;
            this.lbl_tva.Location = new System.Drawing.Point(531, 71);
            this.lbl_tva.Name = "lbl_tva";
            this.lbl_tva.Size = new System.Drawing.Size(35, 17);
            this.lbl_tva.TabIndex = 41;
            this.lbl_tva.Text = "TVA";
            // 
            // cbx_tva
            // 
            this.cbx_tva.FormattingEnabled = true;
            this.cbx_tva.Location = new System.Drawing.Point(533, 91);
            this.cbx_tva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_tva.Name = "cbx_tva";
            this.cbx_tva.Size = new System.Drawing.Size(121, 24);
            this.cbx_tva.TabIndex = 6;
            // 
            // btn_ajouteLigne
            // 
            this.btn_ajouteLigne.Location = new System.Drawing.Point(795, 114);
            this.btn_ajouteLigne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ajouteLigne.Name = "btn_ajouteLigne";
            this.btn_ajouteLigne.Size = new System.Drawing.Size(111, 47);
            this.btn_ajouteLigne.TabIndex = 9;
            this.btn_ajouteLigne.Text = "Créer ligne";
            this.btn_ajouteLigne.UseVisualStyleBackColor = true;
            this.btn_ajouteLigne.Click += new System.EventHandler(this.btn_ajouteLigne_Click);
            // 
            // btn_solRechercher
            // 
            this.btn_solRechercher.Location = new System.Drawing.Point(195, 138);
            this.btn_solRechercher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_solRechercher.Name = "btn_solRechercher";
            this.btn_solRechercher.Size = new System.Drawing.Size(141, 23);
            this.btn_solRechercher.TabIndex = 8;
            this.btn_solRechercher.Text = "Rechercher";
            this.btn_solRechercher.UseVisualStyleBackColor = true;
            this.btn_solRechercher.Click += new System.EventHandler(this.btn_solRechercher_Click);
            // 
            // btn_solVider
            // 
            this.btn_solVider.Location = new System.Drawing.Point(21, 138);
            this.btn_solVider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_solVider.Name = "btn_solVider";
            this.btn_solVider.Size = new System.Drawing.Size(136, 23);
            this.btn_solVider.TabIndex = 7;
            this.btn_solVider.Text = "Vider les filtres";
            this.btn_solVider.UseVisualStyleBackColor = true;
            this.btn_solVider.Click += new System.EventHandler(this.btn_solVider_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Quantité";
            // 
            // tbx_quantite
            // 
            this.tbx_quantite.Location = new System.Drawing.Point(22, 89);
            this.tbx_quantite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_quantite.Name = "tbx_quantite";
            this.tbx_quantite.Size = new System.Drawing.Size(77, 22);
            this.tbx_quantite.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(132, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "No. SOL";
            // 
            // tbx_noSol
            // 
            this.tbx_noSol.Location = new System.Drawing.Point(133, 36);
            this.tbx_noSol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_noSol.Name = "tbx_noSol";
            this.tbx_noSol.Size = new System.Drawing.Size(100, 22);
            this.tbx_noSol.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Produit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(261, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Statut";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Réf. commande";
            // 
            // cbx_solStatut
            // 
            this.cbx_solStatut.FormattingEnabled = true;
            this.cbx_solStatut.Location = new System.Drawing.Point(264, 34);
            this.cbx_solStatut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_solStatut.Name = "cbx_solStatut";
            this.cbx_solStatut.Size = new System.Drawing.Size(121, 24);
            this.cbx_solStatut.TabIndex = 3;
            // 
            // dgv_listeLignesCommande
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgv_listeLignesCommande.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_listeLignesCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeLignesCommande.Location = new System.Drawing.Point(7, 191);
            this.dgv_listeLignesCommande.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_listeLignesCommande.Name = "dgv_listeLignesCommande";
            this.dgv_listeLignesCommande.ReadOnly = true;
            this.dgv_listeLignesCommande.RowTemplate.Height = 24;
            this.dgv_listeLignesCommande.Size = new System.Drawing.Size(919, 458);
            this.dgv_listeLignesCommande.TabIndex = 14;
            this.dgv_listeLignesCommande.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_listeLignesCommande_CellMouseDoubleClick);
            // 
            // raxonBindingSource1
            // 
            this.raxonBindingSource1.DataSource = this.raxon;
            this.raxonBindingSource1.Position = 0;
            // 
            // raxon
            // 
            this.raxon.DataSetName = "raxon";
            this.raxon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raxonBindingSource
            // 
            this.raxonBindingSource.DataSource = this.raxon;
            this.raxonBindingSource.Position = 0;
            // 
            // frm_Listes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 719);
            this.Controls.Add(this.tctrl_Listes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Listes";
            this.Text = "GSB Commande - Listes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tctrl_Listes.ResumeLayout(false);
            this.tpg_listeCommandes.ResumeLayout(false);
            this.tpg_listeCommandes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeCommandes)).EndInit();
            this.tpg_listeLignesCommande.ResumeLayout(false);
            this.tpg_listeLignesCommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeLignesCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raxonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raxon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raxonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctrl_Listes;
        private System.Windows.Forms.TabPage tpg_listeCommandes;
        private System.Windows.Forms.TabPage tpg_listeLignesCommande;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_DateVoulue;
        private System.Windows.Forms.ComboBox cbx_Utilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_DateCommande;
        private System.Windows.Forms.ComboBox cbx_soStatut;
        private System.Windows.Forms.TextBox tbx_soRefCommande;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbx_noSol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbx_solStatut;
        private System.Windows.Forms.DataGridView dgv_listeLignesCommande;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_quantite;
        private System.Windows.Forms.Button btn_solRechercher;
        private System.Windows.Forms.Button btn_solVider;
        private System.Windows.Forms.Button btn_soRechercher;
        private System.Windows.Forms.Button btn_soVider;
        private System.Windows.Forms.Button btn_ajouteLigne;
        private System.Windows.Forms.Button btn_ajouterCommande;
        private System.Windows.Forms.Label lbl_tva;
        private System.Windows.Forms.ComboBox cbx_tva;
        private System.Windows.Forms.DataGridView dgv_listeCommandes;
        private System.Windows.Forms.ComboBox cbx_Client;
        private System.Windows.Forms.ComboBox cbx_Produits;
        private System.Windows.Forms.TextBox tbx_solRefCommande;
        private System.Windows.Forms.BindingSource raxonBindingSource;
        private raxon raxon;
        private System.Windows.Forms.BindingSource raxonBindingSource1;
    }
}