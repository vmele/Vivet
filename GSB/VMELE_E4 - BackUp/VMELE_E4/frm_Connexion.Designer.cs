namespace VMELE_E4
{
    partial class frm_Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_pw = new System.Windows.Forms.TextBox();
            this.btn_Connection = new System.Windows.Forms.Button();
            this.cbx_login = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            // 
            // tbx_pw
            // 
            this.tbx_pw.Location = new System.Drawing.Point(68, 149);
            this.tbx_pw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_pw.Name = "tbx_pw";
            this.tbx_pw.PasswordChar = '•';
            this.tbx_pw.Size = new System.Drawing.Size(177, 22);
            this.tbx_pw.TabIndex = 2;
            this.tbx_pw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_pw_KeyDown);
            // 
            // btn_Connection
            // 
            this.btn_Connection.Location = new System.Drawing.Point(333, 133);
            this.btn_Connection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Connection.Name = "btn_Connection";
            this.btn_Connection.Size = new System.Drawing.Size(131, 54);
            this.btn_Connection.TabIndex = 3;
            this.btn_Connection.Text = "Se connecter";
            this.btn_Connection.UseVisualStyleBackColor = true;
            this.btn_Connection.Click += new System.EventHandler(this.btn_Connection_Click);
            // 
            // cbx_login
            // 
            this.cbx_login.FormattingEnabled = true;
            this.cbx_login.Location = new System.Drawing.Point(68, 47);
            this.cbx_login.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_login.Name = "cbx_login";
            this.cbx_login.Size = new System.Drawing.Size(160, 24);
            this.cbx_login.TabIndex = 1;
            this.cbx_login.TextChanged += new System.EventHandler(this.cbx_login_TextChanged);
            this.cbx_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_login_KeyDown);
            // 
            // frm_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 240);
            this.Controls.Add(this.cbx_login);
            this.Controls.Add(this.btn_Connection);
            this.Controls.Add(this.tbx_pw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Connexion";
            this.Text = "GSB Commande - Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_pw;
        private System.Windows.Forms.Button btn_Connection;
        private System.Windows.Forms.ComboBox cbx_login;
    }
}

