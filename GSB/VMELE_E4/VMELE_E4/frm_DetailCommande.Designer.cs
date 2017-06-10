namespace VMELE_E4
{
    partial class frm_DetailCommande
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_refCommande = new System.Windows.Forms.TextBox();
            this.tbx_client = new System.Windows.Forms.TextBox();
            this.dtp_dateCommande = new System.Windows.Forms.DateTimePicker();
            this.dtp_dateDemandee = new System.Windows.Forms.DateTimePicker();
            this.tbx_gestionnaireCommande = new System.Windows.Forms.TextBox();
            this.cbx_moyenContact = new System.Windows.Forms.ComboBox();
            this.cbx_typeCommande = new System.Windows.Forms.ComboBox();
            this.dgv_lignesCommande = new System.Windows.Forms.DataGridView();
            this.btn_enregistrerFermer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pgb_statutCommande = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editerPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerPDFEtImprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.seDéconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterLapplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesLignesDeCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.pagePrécédenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aiderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauMailSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_StatutCommande = new System.Windows.Forms.Label();
            this.btn_Annuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lignesCommande)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Réf. commande";
            // 
            // tbx_refCommande
            // 
            this.tbx_refCommande.Location = new System.Drawing.Point(74, 57);
            this.tbx_refCommande.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_refCommande.Name = "tbx_refCommande";
            this.tbx_refCommande.Size = new System.Drawing.Size(92, 20);
            this.tbx_refCommande.TabIndex = 1;
            // 
            // tbx_client
            // 
            this.tbx_client.Location = new System.Drawing.Point(243, 57);
            this.tbx_client.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_client.Name = "tbx_client";
            this.tbx_client.Size = new System.Drawing.Size(92, 20);
            this.tbx_client.TabIndex = 2;
            // 
            // dtp_dateCommande
            // 
            this.dtp_dateCommande.Location = new System.Drawing.Point(109, 114);
            this.dtp_dateCommande.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_dateCommande.Name = "dtp_dateCommande";
            this.dtp_dateCommande.Size = new System.Drawing.Size(151, 20);
            this.dtp_dateCommande.TabIndex = 3;
            this.dtp_dateCommande.ValueChanged += new System.EventHandler(this.dtp_dateCommande_ValueChanged_1);
            // 
            // dtp_dateDemandee
            // 
            this.dtp_dateDemandee.Location = new System.Drawing.Point(332, 114);
            this.dtp_dateDemandee.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_dateDemandee.Name = "dtp_dateDemandee";
            this.dtp_dateDemandee.Size = new System.Drawing.Size(151, 20);
            this.dtp_dateDemandee.TabIndex = 4;
            this.dtp_dateDemandee.ValueChanged += new System.EventHandler(this.dtp_dateDemandee_ValueChanged);
            // 
            // tbx_gestionnaireCommande
            // 
            this.tbx_gestionnaireCommande.Location = new System.Drawing.Point(559, 114);
            this.tbx_gestionnaireCommande.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_gestionnaireCommande.Name = "tbx_gestionnaireCommande";
            this.tbx_gestionnaireCommande.Size = new System.Drawing.Size(76, 20);
            this.tbx_gestionnaireCommande.TabIndex = 5;
            // 
            // cbx_moyenContact
            // 
            this.cbx_moyenContact.FormattingEnabled = true;
            this.cbx_moyenContact.Location = new System.Drawing.Point(421, 57);
            this.cbx_moyenContact.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_moyenContact.Name = "cbx_moyenContact";
            this.cbx_moyenContact.Size = new System.Drawing.Size(92, 21);
            this.cbx_moyenContact.TabIndex = 8;
            // 
            // cbx_typeCommande
            // 
            this.cbx_typeCommande.FormattingEnabled = true;
            this.cbx_typeCommande.Location = new System.Drawing.Point(586, 57);
            this.cbx_typeCommande.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_typeCommande.Name = "cbx_typeCommande";
            this.cbx_typeCommande.Size = new System.Drawing.Size(92, 21);
            this.cbx_typeCommande.TabIndex = 9;
            // 
            // dgv_lignesCommande
            // 
            this.dgv_lignesCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lignesCommande.Location = new System.Drawing.Point(26, 174);
            this.dgv_lignesCommande.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_lignesCommande.Name = "dgv_lignesCommande";
            this.dgv_lignesCommande.RowTemplate.Height = 24;
            this.dgv_lignesCommande.Size = new System.Drawing.Size(678, 155);
            this.dgv_lignesCommande.TabIndex = 10;
            // 
            // btn_enregistrerFermer
            // 
            this.btn_enregistrerFermer.Location = new System.Drawing.Point(592, 389);
            this.btn_enregistrerFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_enregistrerFermer.Name = "btn_enregistrerFermer";
            this.btn_enregistrerFermer.Size = new System.Drawing.Size(112, 35);
            this.btn_enregistrerFermer.TabIndex = 11;
            this.btn_enregistrerFermer.Text = "Enregistrer et fermer";
            this.btn_enregistrerFermer.UseVisualStyleBackColor = true;
            this.btn_enregistrerFermer.Click += new System.EventHandler(this.btn_enregistrerFermer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Type cde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date commande";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date demandée";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "GC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Moyen contact";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 159);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Ligne(s) de commande";
            // 
            // pgb_statutCommande
            // 
            this.pgb_statutCommande.Location = new System.Drawing.Point(243, 376);
            this.pgb_statutCommande.Margin = new System.Windows.Forms.Padding(2);
            this.pgb_statutCommande.Name = "pgb_statutCommande";
            this.pgb_statutCommande.Size = new System.Drawing.Size(233, 19);
            this.pgb_statutCommande.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.allerToolStripMenuItem,
            this.aiderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.toolStripSeparator1,
            this.editerPDFToolStripMenuItem,
            this.editerPDFEtImprimerToolStripMenuItem,
            this.toolStripSeparator2,
            this.supprimerToolStripMenuItem,
            this.toolStripSeparator3,
            this.seDéconnecterToolStripMenuItem,
            this.quitterLapplicationToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.testToolStripMenuItem.Text = "Fichier";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // editerPDFToolStripMenuItem
            // 
            this.editerPDFToolStripMenuItem.Name = "editerPDFToolStripMenuItem";
            this.editerPDFToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.editerPDFToolStripMenuItem.Text = "Editer PDF";
            // 
            // editerPDFEtImprimerToolStripMenuItem
            // 
            this.editerPDFEtImprimerToolStripMenuItem.Name = "editerPDFEtImprimerToolStripMenuItem";
            this.editerPDFEtImprimerToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.editerPDFEtImprimerToolStripMenuItem.Text = "Editer PDF et imprimer";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.supprimerToolStripMenuItem.Text = "Annuler";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(190, 6);
            // 
            // seDéconnecterToolStripMenuItem
            // 
            this.seDéconnecterToolStripMenuItem.Name = "seDéconnecterToolStripMenuItem";
            this.seDéconnecterToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.seDéconnecterToolStripMenuItem.Text = "Se déconnecter";
            // 
            // quitterLapplicationToolStripMenuItem
            // 
            this.quitterLapplicationToolStripMenuItem.Name = "quitterLapplicationToolStripMenuItem";
            this.quitterLapplicationToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.quitterLapplicationToolStripMenuItem.Text = "Quitter l\'application";
            // 
            // allerToolStripMenuItem
            // 
            this.allerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesCommandesToolStripMenuItem,
            this.listeDesLignesDeCommandeToolStripMenuItem,
            this.toolStripSeparator4,
            this.pagePrécédenteToolStripMenuItem});
            this.allerToolStripMenuItem.Name = "allerToolStripMenuItem";
            this.allerToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.allerToolStripMenuItem.Text = "Aller";
            // 
            // listeDesCommandesToolStripMenuItem
            // 
            this.listeDesCommandesToolStripMenuItem.Name = "listeDesCommandesToolStripMenuItem";
            this.listeDesCommandesToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.listeDesCommandesToolStripMenuItem.Text = "Liste des commandes";
            // 
            // listeDesLignesDeCommandeToolStripMenuItem
            // 
            this.listeDesLignesDeCommandeToolStripMenuItem.Name = "listeDesLignesDeCommandeToolStripMenuItem";
            this.listeDesLignesDeCommandeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.listeDesLignesDeCommandeToolStripMenuItem.Text = "Liste des lignes de commande";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(230, 6);
            // 
            // pagePrécédenteToolStripMenuItem
            // 
            this.pagePrécédenteToolStripMenuItem.Name = "pagePrécédenteToolStripMenuItem";
            this.pagePrécédenteToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.pagePrécédenteToolStripMenuItem.Text = "Page précédente";
            // 
            // aiderToolStripMenuItem
            // 
            this.aiderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauMailSupportToolStripMenuItem});
            this.aiderToolStripMenuItem.Name = "aiderToolStripMenuItem";
            this.aiderToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aiderToolStripMenuItem.Text = "Aide";
            // 
            // nouveauMailSupportToolStripMenuItem
            // 
            this.nouveauMailSupportToolStripMenuItem.Name = "nouveauMailSupportToolStripMenuItem";
            this.nouveauMailSupportToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.nouveauMailSupportToolStripMenuItem.Text = "Nouveau mail support";
            this.nouveauMailSupportToolStripMenuItem.Click += new System.EventHandler(this.nouveauMailSupportToolStripMenuItem_Click);
            // 
            // lbl_StatutCommande
            // 
            this.lbl_StatutCommande.AutoSize = true;
            this.lbl_StatutCommande.Location = new System.Drawing.Point(371, 361);
            this.lbl_StatutCommande.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StatutCommande.Name = "lbl_StatutCommande";
            this.lbl_StatutCommande.Size = new System.Drawing.Size(0, 13);
            this.lbl_StatutCommande.TabIndex = 27;
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(26, 389);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(83, 35);
            this.btn_Annuler.TabIndex = 28;
            this.btn_Annuler.Text = "Supprimer";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // frm_DetailCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 453);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.lbl_StatutCommande);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pgb_statutCommande);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_enregistrerFermer);
            this.Controls.Add(this.dgv_lignesCommande);
            this.Controls.Add(this.cbx_typeCommande);
            this.Controls.Add(this.cbx_moyenContact);
            this.Controls.Add(this.tbx_gestionnaireCommande);
            this.Controls.Add(this.dtp_dateDemandee);
            this.Controls.Add(this.dtp_dateCommande);
            this.Controls.Add(this.tbx_client);
            this.Controls.Add(this.tbx_refCommande);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_DetailCommande";
            this.Text = "GSB Commande - Détail commande";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lignesCommande)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_refCommande;
        private System.Windows.Forms.TextBox tbx_client;
        private System.Windows.Forms.DateTimePicker dtp_dateCommande;
        private System.Windows.Forms.DateTimePicker dtp_dateDemandee;
        private System.Windows.Forms.TextBox tbx_gestionnaireCommande;
        private System.Windows.Forms.ComboBox cbx_moyenContact;
        private System.Windows.Forms.ComboBox cbx_typeCommande;
        private System.Windows.Forms.DataGridView dgv_lignesCommande;
        private System.Windows.Forms.Button btn_enregistrerFermer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar pgb_statutCommande;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editerPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerPDFEtImprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem seDéconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterLapplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesLignesDeCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem pagePrécédenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aiderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauMailSupportToolStripMenuItem;
        private System.Windows.Forms.Label lbl_StatutCommande;
        private System.Windows.Forms.Button btn_Annuler;
    }
}