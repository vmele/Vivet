namespace Chantier
{
    partial class frm_ListeChantier
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ListeChantier));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lsb_ListeChantier = new System.Windows.Forms.ListBox();
            this.btn_EditionChantier = new System.Windows.Forms.Button();
            this.btn_EditionClient = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // lsb_ListeChantier
            // 
            this.lsb_ListeChantier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsb_ListeChantier.FormattingEnabled = true;
            this.lsb_ListeChantier.ItemHeight = 16;
            this.lsb_ListeChantier.Location = new System.Drawing.Point(85, 42);
            this.lsb_ListeChantier.Name = "lsb_ListeChantier";
            this.lsb_ListeChantier.Size = new System.Drawing.Size(231, 144);
            this.lsb_ListeChantier.TabIndex = 4;
            this.lsb_ListeChantier.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsb_ListeChantier_MouseDoubleClick);
            // 
            // btn_EditionChantier
            // 
            this.btn_EditionChantier.Location = new System.Drawing.Point(222, 224);
            this.btn_EditionChantier.Name = "btn_EditionChantier";
            this.btn_EditionChantier.Size = new System.Drawing.Size(94, 61);
            this.btn_EditionChantier.TabIndex = 5;
            this.btn_EditionChantier.Text = "Edition chantier";
            this.btn_EditionChantier.UseVisualStyleBackColor = true;
            this.btn_EditionChantier.Click += new System.EventHandler(this.btn_EditionChantier_Click);
            // 
            // btn_EditionClient
            // 
            this.btn_EditionClient.Location = new System.Drawing.Point(85, 224);
            this.btn_EditionClient.Name = "btn_EditionClient";
            this.btn_EditionClient.Size = new System.Drawing.Size(94, 61);
            this.btn_EditionClient.TabIndex = 6;
            this.btn_EditionClient.Text = "Edition client";
            this.btn_EditionClient.UseVisualStyleBackColor = true;
            this.btn_EditionClient.Click += new System.EventHandler(this.btn_EditionClient_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sauvegarderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(396, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            this.sauvegarderToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderToolStripMenuItem_Click);
            // 
            // frm_ListeChantier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 321);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_EditionClient);
            this.Controls.Add(this.btn_EditionChantier);
            this.Controls.Add(this.lsb_ListeChantier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_ListeChantier";
            this.Text = "Liste des chantiers";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox lsb_ListeChantier;
        private System.Windows.Forms.Button btn_EditionChantier;
        private System.Windows.Forms.Button btn_EditionClient;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
    }
}

