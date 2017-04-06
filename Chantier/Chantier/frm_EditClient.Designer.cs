namespace Chantier
{
    partial class frm_EditClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditClient));
            this.rbt_AjoutClient = new System.Windows.Forms.RadioButton();
            this.rbt_ModifClient = new System.Windows.Forms.RadioButton();
            this.rbt_SupprClient = new System.Windows.Forms.RadioButton();
            this.cbx_Client = new System.Windows.Forms.ComboBox();
            this.tbx_RaisonSociale = new System.Windows.Forms.TextBox();
            this.tbx_Telephone = new System.Windows.Forms.TextBox();
            this.tbx_eMail = new System.Windows.Forms.TextBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_Retour = new System.Windows.Forms.Button();
            this.lbl_Client = new System.Windows.Forms.Label();
            this.lbl_RaisonSociale = new System.Windows.Forms.Label();
            this.lbl_TelClient = new System.Windows.Forms.Label();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbt_AjoutClient
            // 
            this.rbt_AjoutClient.AutoSize = true;
            this.rbt_AjoutClient.Location = new System.Drawing.Point(45, 28);
            this.rbt_AjoutClient.Name = "rbt_AjoutClient";
            this.rbt_AjoutClient.Size = new System.Drawing.Size(61, 21);
            this.rbt_AjoutClient.TabIndex = 0;
            this.rbt_AjoutClient.TabStop = true;
            this.rbt_AjoutClient.Text = "Ajout";
            this.rbt_AjoutClient.UseVisualStyleBackColor = true;
            this.rbt_AjoutClient.CheckedChanged += new System.EventHandler(this.rbt_AjoutClient_CheckedChanged);
            // 
            // rbt_ModifClient
            // 
            this.rbt_ModifClient.AutoSize = true;
            this.rbt_ModifClient.Location = new System.Drawing.Point(163, 28);
            this.rbt_ModifClient.Name = "rbt_ModifClient";
            this.rbt_ModifClient.Size = new System.Drawing.Size(104, 21);
            this.rbt_ModifClient.TabIndex = 1;
            this.rbt_ModifClient.TabStop = true;
            this.rbt_ModifClient.Text = "Modification";
            this.rbt_ModifClient.UseVisualStyleBackColor = true;
            this.rbt_ModifClient.CheckedChanged += new System.EventHandler(this.rbt_ModifClient_CheckedChanged);
            // 
            // rbt_SupprClient
            // 
            this.rbt_SupprClient.AutoSize = true;
            this.rbt_SupprClient.Location = new System.Drawing.Point(321, 28);
            this.rbt_SupprClient.Name = "rbt_SupprClient";
            this.rbt_SupprClient.Size = new System.Drawing.Size(108, 21);
            this.rbt_SupprClient.TabIndex = 2;
            this.rbt_SupprClient.TabStop = true;
            this.rbt_SupprClient.Text = "Suppression";
            this.rbt_SupprClient.UseVisualStyleBackColor = true;
            this.rbt_SupprClient.CheckedChanged += new System.EventHandler(this.rbt_SupprClient_CheckedChanged);
            // 
            // cbx_Client
            // 
            this.cbx_Client.FormattingEnabled = true;
            this.cbx_Client.Location = new System.Drawing.Point(187, 65);
            this.cbx_Client.Name = "cbx_Client";
            this.cbx_Client.Size = new System.Drawing.Size(157, 24);
            this.cbx_Client.TabIndex = 3;
            this.cbx_Client.SelectedIndexChanged += new System.EventHandler(this.cbx_Client_SelectedIndexChanged);
            // 
            // tbx_RaisonSociale
            // 
            this.tbx_RaisonSociale.Location = new System.Drawing.Point(187, 110);
            this.tbx_RaisonSociale.Name = "tbx_RaisonSociale";
            this.tbx_RaisonSociale.Size = new System.Drawing.Size(157, 22);
            this.tbx_RaisonSociale.TabIndex = 4;
            // 
            // tbx_Telephone
            // 
            this.tbx_Telephone.Location = new System.Drawing.Point(187, 157);
            this.tbx_Telephone.Name = "tbx_Telephone";
            this.tbx_Telephone.Size = new System.Drawing.Size(157, 22);
            this.tbx_Telephone.TabIndex = 5;
            // 
            // tbx_eMail
            // 
            this.tbx_eMail.Location = new System.Drawing.Point(187, 202);
            this.tbx_eMail.Name = "tbx_eMail";
            this.tbx_eMail.Size = new System.Drawing.Size(157, 22);
            this.tbx_eMail.TabIndex = 6;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(278, 261);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(91, 44);
            this.btn_Valider.TabIndex = 7;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // btn_Retour
            // 
            this.btn_Retour.Location = new System.Drawing.Point(73, 261);
            this.btn_Retour.Name = "btn_Retour";
            this.btn_Retour.Size = new System.Drawing.Size(91, 44);
            this.btn_Retour.TabIndex = 8;
            this.btn_Retour.Text = "Retour";
            this.btn_Retour.UseVisualStyleBackColor = true;
            this.btn_Retour.Click += new System.EventHandler(this.btn_Retour_Click);
            // 
            // lbl_Client
            // 
            this.lbl_Client.AutoSize = true;
            this.lbl_Client.Location = new System.Drawing.Point(121, 72);
            this.lbl_Client.Name = "lbl_Client";
            this.lbl_Client.Size = new System.Drawing.Size(43, 17);
            this.lbl_Client.TabIndex = 9;
            this.lbl_Client.Text = "Client";
            // 
            // lbl_RaisonSociale
            // 
            this.lbl_RaisonSociale.AutoSize = true;
            this.lbl_RaisonSociale.Location = new System.Drawing.Point(64, 110);
            this.lbl_RaisonSociale.Name = "lbl_RaisonSociale";
            this.lbl_RaisonSociale.Size = new System.Drawing.Size(100, 17);
            this.lbl_RaisonSociale.TabIndex = 10;
            this.lbl_RaisonSociale.Text = "Raison sociale";
            // 
            // lbl_TelClient
            // 
            this.lbl_TelClient.AutoSize = true;
            this.lbl_TelClient.Location = new System.Drawing.Point(88, 157);
            this.lbl_TelClient.Name = "lbl_TelClient";
            this.lbl_TelClient.Size = new System.Drawing.Size(76, 17);
            this.lbl_TelClient.TabIndex = 11;
            this.lbl_TelClient.Text = "Téléphone";
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(123, 202);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(41, 17);
            this.lbl_Mail.TabIndex = 12;
            this.lbl_Mail.Text = "eMail";
            // 
            // frm_EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 351);
            this.Controls.Add(this.lbl_Mail);
            this.Controls.Add(this.lbl_TelClient);
            this.Controls.Add(this.lbl_RaisonSociale);
            this.Controls.Add(this.lbl_Client);
            this.Controls.Add(this.btn_Retour);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.tbx_eMail);
            this.Controls.Add(this.tbx_Telephone);
            this.Controls.Add(this.tbx_RaisonSociale);
            this.Controls.Add(this.cbx_Client);
            this.Controls.Add(this.rbt_SupprClient);
            this.Controls.Add(this.rbt_ModifClient);
            this.Controls.Add(this.rbt_AjoutClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EditClient";
            this.Text = "Edition de clients";
            this.Load += new System.EventHandler(this.frm_EditClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbt_AjoutClient;
        private System.Windows.Forms.RadioButton rbt_ModifClient;
        private System.Windows.Forms.RadioButton rbt_SupprClient;
        private System.Windows.Forms.ComboBox cbx_Client;
        private System.Windows.Forms.TextBox tbx_RaisonSociale;
        private System.Windows.Forms.TextBox tbx_Telephone;
        private System.Windows.Forms.TextBox tbx_eMail;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Retour;
        private System.Windows.Forms.Label lbl_Client;
        private System.Windows.Forms.Label lbl_RaisonSociale;
        private System.Windows.Forms.Label lbl_TelClient;
        private System.Windows.Forms.Label lbl_Mail;
    }
}