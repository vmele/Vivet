namespace VMELE_E4
{
    partial class frm_DetailLignesCommande
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
            this.tbx_noSol = new System.Windows.Forms.TextBox();
            this.tbx_conditionnement = new System.Windows.Forms.TextBox();
            this.tbx_prixConditionne = new System.Windows.Forms.TextBox();
            this.tbx_quantite = new System.Windows.Forms.TextBox();
            this.tbx_montantTotal = new System.Windows.Forms.TextBox();
            this.cbx_tva = new System.Windows.Forms.ComboBox();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.pgb_statut = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_statut = new System.Windows.Forms.Label();
            this.cbx_SolRefCde = new System.Windows.Forms.ComboBox();
            this.cbx_Produit = new System.Windows.Forms.ComboBox();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_noSol
            // 
            this.tbx_noSol.Location = new System.Drawing.Point(196, 47);
            this.tbx_noSol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_noSol.Name = "tbx_noSol";
            this.tbx_noSol.Size = new System.Drawing.Size(88, 20);
            this.tbx_noSol.TabIndex = 1;
            // 
            // tbx_conditionnement
            // 
            this.tbx_conditionnement.Location = new System.Drawing.Point(430, 46);
            this.tbx_conditionnement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_conditionnement.Name = "tbx_conditionnement";
            this.tbx_conditionnement.Size = new System.Drawing.Size(88, 20);
            this.tbx_conditionnement.TabIndex = 2;
            // 
            // tbx_prixConditionne
            // 
            this.tbx_prixConditionne.Location = new System.Drawing.Point(540, 47);
            this.tbx_prixConditionne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_prixConditionne.Name = "tbx_prixConditionne";
            this.tbx_prixConditionne.Size = new System.Drawing.Size(84, 20);
            this.tbx_prixConditionne.TabIndex = 3;
            // 
            // tbx_quantite
            // 
            this.tbx_quantite.Location = new System.Drawing.Point(330, 46);
            this.tbx_quantite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_quantite.Name = "tbx_quantite";
            this.tbx_quantite.Size = new System.Drawing.Size(76, 20);
            this.tbx_quantite.TabIndex = 5;
            this.tbx_quantite.TextChanged += new System.EventHandler(this.tbx_quantite_TextChanged);
            // 
            // tbx_montantTotal
            // 
            this.tbx_montantTotal.Location = new System.Drawing.Point(548, 122);
            this.tbx_montantTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_montantTotal.Name = "tbx_montantTotal";
            this.tbx_montantTotal.Size = new System.Drawing.Size(76, 20);
            this.tbx_montantTotal.TabIndex = 6;
            // 
            // cbx_tva
            // 
            this.cbx_tva.FormattingEnabled = true;
            this.cbx_tva.Location = new System.Drawing.Point(330, 121);
            this.cbx_tva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_tva.Name = "cbx_tva";
            this.cbx_tva.Size = new System.Drawing.Size(92, 21);
            this.cbx_tva.TabIndex = 7;
            this.cbx_tva.SelectedIndexChanged += new System.EventHandler(this.cbx_tva_SelectedIndexChanged);
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(512, 248);
            this.btn_enregistrer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(112, 32);
            this.btn_enregistrer.TabIndex = 9;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(283, 248);
            this.btn_valider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(112, 32);
            this.btn_valider.TabIndex = 9;
            this.btn_valider.Text = "Valider la ligne";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // pgb_statut
            // 
            this.pgb_statut.Location = new System.Drawing.Point(251, 192);
            this.pgb_statut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pgb_statut.Name = "pgb_statut";
            this.pgb_statut.Size = new System.Drawing.Size(184, 19);
            this.pgb_statut.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Référence commande";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "No. ligne";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantité";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Conditionnement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Prix conditionné";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Produit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "TVA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Montant total";
            // 
            // lbl_statut
            // 
            this.lbl_statut.AutoSize = true;
            this.lbl_statut.Location = new System.Drawing.Point(327, 177);
            this.lbl_statut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_statut.Name = "lbl_statut";
            this.lbl_statut.Size = new System.Drawing.Size(0, 13);
            this.lbl_statut.TabIndex = 20;
            // 
            // cbx_SolRefCde
            // 
            this.cbx_SolRefCde.FormattingEnabled = true;
            this.cbx_SolRefCde.Location = new System.Drawing.Point(40, 46);
            this.cbx_SolRefCde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_SolRefCde.Name = "cbx_SolRefCde";
            this.cbx_SolRefCde.Size = new System.Drawing.Size(111, 21);
            this.cbx_SolRefCde.TabIndex = 21;
            this.cbx_SolRefCde.SelectedIndexChanged += new System.EventHandler(this.cbx_SolRefCde_SelectedIndexChanged);
            // 
            // cbx_Produit
            // 
            this.cbx_Produit.FormattingEnabled = true;
            this.cbx_Produit.Location = new System.Drawing.Point(40, 121);
            this.cbx_Produit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_Produit.Name = "cbx_Produit";
            this.cbx_Produit.Size = new System.Drawing.Size(188, 21);
            this.cbx_Produit.TabIndex = 22;
            this.cbx_Produit.SelectedIndexChanged += new System.EventHandler(this.cbx_Produit_SelectedIndexChanged);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(40, 248);
            this.btn_Annuler.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(112, 32);
            this.btn_Annuler.TabIndex = 23;
            this.btn_Annuler.Text = "Supprimer";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // frm_DetailLignesCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(659, 302);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.cbx_Produit);
            this.Controls.Add(this.cbx_SolRefCde);
            this.Controls.Add(this.lbl_statut);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgb_statut);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.cbx_tva);
            this.Controls.Add(this.tbx_montantTotal);
            this.Controls.Add(this.tbx_quantite);
            this.Controls.Add(this.tbx_prixConditionne);
            this.Controls.Add(this.tbx_conditionnement);
            this.Controls.Add(this.tbx_noSol);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_DetailLignesCommande";
            this.Text = "GSB Commande - Détail ligne de commande";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbx_noSol;
        private System.Windows.Forms.TextBox tbx_conditionnement;
        private System.Windows.Forms.TextBox tbx_prixConditionne;
        private System.Windows.Forms.TextBox tbx_quantite;
        private System.Windows.Forms.TextBox tbx_montantTotal;
        private System.Windows.Forms.ComboBox cbx_tva;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.ProgressBar pgb_statut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_statut;
        private System.Windows.Forms.ComboBox cbx_SolRefCde;
        private System.Windows.Forms.ComboBox cbx_Produit;
        private System.Windows.Forms.Button btn_Annuler;
    }
}