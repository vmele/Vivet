namespace Chantier
{
    partial class frm_EditChantier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditChantier));
            this.rbt_SupprChantier = new System.Windows.Forms.RadioButton();
            this.rbt_ModifChantier = new System.Windows.Forms.RadioButton();
            this.rbt_AjoutChantier = new System.Windows.Forms.RadioButton();
            this.tbx_NomChantier = new System.Windows.Forms.TextBox();
            this.tbx_MontantChantier = new System.Windows.Forms.TextBox();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_Clients = new System.Windows.Forms.ComboBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.cbx_Chantier = new System.Windows.Forms.ComboBox();
            this.dtp_DateDebut = new System.Windows.Forms.DateTimePicker();
            this.lbl_Chantier = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbt_SupprChantier
            // 
            this.rbt_SupprChantier.AutoSize = true;
            this.rbt_SupprChantier.Location = new System.Drawing.Point(308, 11);
            this.rbt_SupprChantier.Margin = new System.Windows.Forms.Padding(2);
            this.rbt_SupprChantier.Name = "rbt_SupprChantier";
            this.rbt_SupprChantier.Size = new System.Drawing.Size(108, 21);
            this.rbt_SupprChantier.TabIndex = 11;
            this.rbt_SupprChantier.TabStop = true;
            this.rbt_SupprChantier.Text = "Suppression";
            this.rbt_SupprChantier.UseVisualStyleBackColor = true;
            this.rbt_SupprChantier.CheckedChanged += new System.EventHandler(this.rbt_SupprChantier_CheckedChanged);
            // 
            // rbt_ModifChantier
            // 
            this.rbt_ModifChantier.AutoSize = true;
            this.rbt_ModifChantier.Location = new System.Drawing.Point(180, 11);
            this.rbt_ModifChantier.Margin = new System.Windows.Forms.Padding(2);
            this.rbt_ModifChantier.Name = "rbt_ModifChantier";
            this.rbt_ModifChantier.Size = new System.Drawing.Size(104, 21);
            this.rbt_ModifChantier.TabIndex = 10;
            this.rbt_ModifChantier.TabStop = true;
            this.rbt_ModifChantier.Text = "Modification";
            this.rbt_ModifChantier.UseVisualStyleBackColor = true;
            this.rbt_ModifChantier.CheckedChanged += new System.EventHandler(this.rbt_ModifChantier_CheckedChanged);
            // 
            // rbt_AjoutChantier
            // 
            this.rbt_AjoutChantier.AutoSize = true;
            this.rbt_AjoutChantier.Checked = true;
            this.rbt_AjoutChantier.Location = new System.Drawing.Point(82, 11);
            this.rbt_AjoutChantier.Margin = new System.Windows.Forms.Padding(2);
            this.rbt_AjoutChantier.Name = "rbt_AjoutChantier";
            this.rbt_AjoutChantier.Size = new System.Drawing.Size(61, 21);
            this.rbt_AjoutChantier.TabIndex = 9;
            this.rbt_AjoutChantier.TabStop = true;
            this.rbt_AjoutChantier.Text = "Ajout";
            this.rbt_AjoutChantier.UseVisualStyleBackColor = true;
            this.rbt_AjoutChantier.CheckedChanged += new System.EventHandler(this.rbt_AjoutChantier_CheckedChanged);
            // 
            // tbx_NomChantier
            // 
            this.tbx_NomChantier.Location = new System.Drawing.Point(171, 97);
            this.tbx_NomChantier.Name = "tbx_NomChantier";
            this.tbx_NomChantier.Size = new System.Drawing.Size(170, 22);
            this.tbx_NomChantier.TabIndex = 12;
            // 
            // tbx_MontantChantier
            // 
            this.tbx_MontantChantier.Location = new System.Drawing.Point(171, 178);
            this.tbx_MontantChantier.Name = "tbx_MontantChantier";
            this.tbx_MontantChantier.Size = new System.Drawing.Size(170, 22);
            this.tbx_MontantChantier.TabIndex = 14;
            this.tbx_MontantChantier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_MontantChantier_KeyPress);
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Location = new System.Drawing.Point(106, 102);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(37, 17);
            this.lbl_Nom.TabIndex = 16;
            this.lbl_Nom.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Date de début";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Montant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Client";
            // 
            // cbx_Clients
            // 
            this.cbx_Clients.FormattingEnabled = true;
            this.cbx_Clients.Location = new System.Drawing.Point(171, 216);
            this.cbx_Clients.Name = "cbx_Clients";
            this.cbx_Clients.Size = new System.Drawing.Size(170, 24);
            this.cbx_Clients.TabIndex = 20;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(308, 276);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(86, 47);
            this.btn_Valider.TabIndex = 21;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(87, 276);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(86, 47);
            this.btn_Annuler.TabIndex = 22;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // cbx_Chantier
            // 
            this.cbx_Chantier.FormattingEnabled = true;
            this.cbx_Chantier.Location = new System.Drawing.Point(171, 54);
            this.cbx_Chantier.Name = "cbx_Chantier";
            this.cbx_Chantier.Size = new System.Drawing.Size(170, 24);
            this.cbx_Chantier.TabIndex = 24;
            this.cbx_Chantier.SelectedIndexChanged += new System.EventHandler(this.cbx_Chantier_SelectedIndexChanged);
            // 
            // dtp_DateDebut
            // 
            this.dtp_DateDebut.Location = new System.Drawing.Point(171, 141);
            this.dtp_DateDebut.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_DateDebut.Name = "dtp_DateDebut";
            this.dtp_DateDebut.Size = new System.Drawing.Size(170, 22);
            this.dtp_DateDebut.TabIndex = 25;
            // 
            // lbl_Chantier
            // 
            this.lbl_Chantier.AutoSize = true;
            this.lbl_Chantier.Location = new System.Drawing.Point(82, 57);
            this.lbl_Chantier.Name = "lbl_Chantier";
            this.lbl_Chantier.Size = new System.Drawing.Size(61, 17);
            this.lbl_Chantier.TabIndex = 26;
            this.lbl_Chantier.Text = "Chantier";
            // 
            // frm_EditChantier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 355);
            this.Controls.Add(this.lbl_Chantier);
            this.Controls.Add(this.dtp_DateDebut);
            this.Controls.Add(this.cbx_Chantier);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.cbx_Clients);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.tbx_MontantChantier);
            this.Controls.Add(this.tbx_NomChantier);
            this.Controls.Add(this.rbt_SupprChantier);
            this.Controls.Add(this.rbt_ModifChantier);
            this.Controls.Add(this.rbt_AjoutChantier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EditChantier";
            this.Text = "Edition de chantier";
            this.Load += new System.EventHandler(this.frm_EditChantier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbt_SupprChantier;
        private System.Windows.Forms.RadioButton rbt_ModifChantier;
        private System.Windows.Forms.RadioButton rbt_AjoutChantier;
        private System.Windows.Forms.TextBox tbx_NomChantier;
        private System.Windows.Forms.TextBox tbx_MontantChantier;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_Clients;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.ComboBox cbx_Chantier;
        private System.Windows.Forms.DateTimePicker dtp_DateDebut;
        private System.Windows.Forms.Label lbl_Chantier;
    }
}