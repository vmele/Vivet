namespace Chantier
{
    partial class frm_DetailChantier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DetailChantier));
            this.lbl_DateDebut = new System.Windows.Forms.Label();
            this.lbl_Montant = new System.Windows.Forms.Label();
            this.lbl_Client = new System.Windows.Forms.Label();
            this.tbx_Montant = new System.Windows.Forms.TextBox();
            this.tbx_Client = new System.Windows.Forms.TextBox();
            this.tbx_NomChantier = new System.Windows.Forms.TextBox();
            this.btn_CloseWindows = new System.Windows.Forms.Button();
            this.lbl_Chantier = new System.Windows.Forms.Label();
            this.dtp_DateDebut = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_DateDebut
            // 
            this.lbl_DateDebut.AutoSize = true;
            this.lbl_DateDebut.Location = new System.Drawing.Point(16, 59);
            this.lbl_DateDebut.Name = "lbl_DateDebut";
            this.lbl_DateDebut.Size = new System.Drawing.Size(98, 17);
            this.lbl_DateDebut.TabIndex = 0;
            this.lbl_DateDebut.Text = "Date de début";
            // 
            // lbl_Montant
            // 
            this.lbl_Montant.AutoSize = true;
            this.lbl_Montant.Location = new System.Drawing.Point(24, 96);
            this.lbl_Montant.Name = "lbl_Montant";
            this.lbl_Montant.Size = new System.Drawing.Size(90, 17);
            this.lbl_Montant.TabIndex = 1;
            this.lbl_Montant.Text = "Montant total";
            // 
            // lbl_Client
            // 
            this.lbl_Client.AutoSize = true;
            this.lbl_Client.Location = new System.Drawing.Point(71, 139);
            this.lbl_Client.Name = "lbl_Client";
            this.lbl_Client.Size = new System.Drawing.Size(43, 17);
            this.lbl_Client.TabIndex = 2;
            this.lbl_Client.Text = "Client";
            // 
            // tbx_Montant
            // 
            this.tbx_Montant.Location = new System.Drawing.Point(137, 96);
            this.tbx_Montant.Name = "tbx_Montant";
            this.tbx_Montant.ReadOnly = true;
            this.tbx_Montant.Size = new System.Drawing.Size(215, 22);
            this.tbx_Montant.TabIndex = 4;
            // 
            // tbx_Client
            // 
            this.tbx_Client.Location = new System.Drawing.Point(137, 134);
            this.tbx_Client.Name = "tbx_Client";
            this.tbx_Client.ReadOnly = true;
            this.tbx_Client.Size = new System.Drawing.Size(215, 22);
            this.tbx_Client.TabIndex = 5;
            // 
            // tbx_NomChantier
            // 
            this.tbx_NomChantier.Location = new System.Drawing.Point(137, 18);
            this.tbx_NomChantier.Name = "tbx_NomChantier";
            this.tbx_NomChantier.ReadOnly = true;
            this.tbx_NomChantier.Size = new System.Drawing.Size(215, 22);
            this.tbx_NomChantier.TabIndex = 6;
            // 
            // btn_CloseWindows
            // 
            this.btn_CloseWindows.Location = new System.Drawing.Point(253, 172);
            this.btn_CloseWindows.Name = "btn_CloseWindows";
            this.btn_CloseWindows.Size = new System.Drawing.Size(99, 61);
            this.btn_CloseWindows.TabIndex = 7;
            this.btn_CloseWindows.Text = "Fermer";
            this.btn_CloseWindows.UseVisualStyleBackColor = true;
            this.btn_CloseWindows.Click += new System.EventHandler(this.btn_CloseWindows_Click);
            // 
            // lbl_Chantier
            // 
            this.lbl_Chantier.AutoSize = true;
            this.lbl_Chantier.Location = new System.Drawing.Point(53, 18);
            this.lbl_Chantier.Name = "lbl_Chantier";
            this.lbl_Chantier.Size = new System.Drawing.Size(61, 17);
            this.lbl_Chantier.TabIndex = 8;
            this.lbl_Chantier.Text = "Chantier";
            // 
            // dtp_DateDebut
            // 
            this.dtp_DateDebut.Enabled = false;
            this.dtp_DateDebut.Location = new System.Drawing.Point(137, 59);
            this.dtp_DateDebut.Name = "dtp_DateDebut";
            this.dtp_DateDebut.Size = new System.Drawing.Size(215, 22);
            this.dtp_DateDebut.TabIndex = 9;
            // 
            // frm_DetailChantier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 269);
            this.Controls.Add(this.dtp_DateDebut);
            this.Controls.Add(this.lbl_Chantier);
            this.Controls.Add(this.btn_CloseWindows);
            this.Controls.Add(this.tbx_NomChantier);
            this.Controls.Add(this.tbx_Client);
            this.Controls.Add(this.tbx_Montant);
            this.Controls.Add(this.lbl_Client);
            this.Controls.Add(this.lbl_Montant);
            this.Controls.Add(this.lbl_DateDebut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DetailChantier";
            this.Text = "Chantier détaillé";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DateDebut;
        private System.Windows.Forms.Label lbl_Montant;
        private System.Windows.Forms.Label lbl_Client;
        private System.Windows.Forms.TextBox tbx_Montant;
        private System.Windows.Forms.TextBox tbx_Client;
        private System.Windows.Forms.TextBox tbx_NomChantier;
        private System.Windows.Forms.Button btn_CloseWindows;
        private System.Windows.Forms.Label lbl_Chantier;
        private System.Windows.Forms.DateTimePicker dtp_DateDebut;
    }
}