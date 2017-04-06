using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Chantier
{
    public partial class frm_EditClient : Form
    {
        /// <summary>
        /// Constructeur de la frm_EditClient
        /// </summary>
        public frm_EditClient()
        {
            InitializeComponent();
            Setup();
        }

        /// <summary>
        /// Ajoute les client à la cbx
        /// </summary>
        private void Setup()
        {
            foreach (cls_Client l_Client in Program.Modele.ListeClient.Values)
            {
                cbx_Client.Items.Add(l_Client);
            }
        }

        /// <summary>
        /// Clear les objets form
        /// </summary>
        private void Clear()
        {
            cbx_Client.Items.Clear();
            tbx_eMail.Clear();
            tbx_RaisonSociale.Clear();
            tbx_Telephone.Clear();
            
        }

        /// <summary>
        /// Ajoute un client
        /// </summary>
        private void ValiderAjout()
        {
            if (tbx_RaisonSociale.Text == "")
            {
                MessageBox.Show("Veuillez saisir une raison sociale valide.",
                    "Attention",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (TelephoneRegex(tbx_Telephone.Text) == false)
                {
                    MessageBox.Show("Veuillez saisir un numéro de téléphone valide.",
                        "Attention",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (MailRegex(tbx_eMail.Text) == false)
                    {
                        MessageBox.Show("Veuillez saisir un mail valide.",
                            "Attention",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        cls_Client l_Client = new cls_Client(cls_ObjetBase.NouvelId(), tbx_RaisonSociale.Text, tbx_Telephone.Text,
                            tbx_eMail.Text);
                        Program.Controlleur.ListeAjoutTampon.Add(l_Client);
                        Program.Modele.ListeClient.Add(l_Client.getID(), l_Client);
                        this.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Modifie un client
        /// </summary>
        private void ValiderModif()
        {
            if (cbx_Client.SelectedItem == null || cbx_Client.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un client valide.",
                    "Attention",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (tbx_RaisonSociale.Text == "")
                {
                    MessageBox.Show("Veuillez saisir une raison sociale valide.",
                        "Attention",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (TelephoneRegex(tbx_Telephone.Text) == false)
                    {
                        MessageBox.Show("Veuillez saisir un numéro de téléphone valide.",
                            "Attention",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        if (MailRegex(tbx_eMail.Text) == false)
                        {
                            MessageBox.Show("Veuillez saisir un mail valide.",
                                "Attention",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            // Set des attributs du client
                            cls_Client l_Client = (cls_Client)cbx_Client.SelectedItem;
                            l_Client.RaisonSociale = tbx_RaisonSociale.Text;
                            l_Client.Telephone = tbx_Telephone.Text;
                            l_Client.eMail = tbx_eMail.Text;

                            // Ajout du client à la liste tampon
                            Program.Controlleur.ListeModifTampon.Add(l_Client.getID(), l_Client);
                        }
                            this.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Supprime un client
        /// </summary>
        private void ValiderSuppr()
        {
            if (cbx_Client.SelectedItem == null || cbx_Client.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un client valide.",
                    "Attention",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Voulez vous vraiment supprimer cet élément ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        cls_Client l_Client = (cls_Client)cbx_Client.SelectedItem;
                        // Supprime de la liste tampon l'objet avec le clef donnée
                        Program.Modele.ListeClient.Remove(l_Client.getID());
                        Program.Controlleur.ListeSupprTampon.Add(l_Client);
                        this.Close();
                    }
                    else if (dr == DialogResult.No)
                    {
                        this.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Vous ne pouvez pas faire ça (Erreur BDD)", "Interdiction");
                }
            }
        }

        /// <summary>
        /// Vérifie que le mail écrit est bon
        /// </summary>
        /// <param name="pMail"></param>
        /// <returns></returns>
        private bool MailRegex(String pMail)
        {
            return Regex.IsMatch(pMail, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
        }

        /// <summary>
        /// Vérifie de le tel écrit est bon
        /// </summary>
        /// <param name="pTel"></param>
        /// <returns></returns>
        private bool TelephoneRegex(String pTel)
        {
            return Regex.IsMatch(pTel, @"^\+?\s*(\d+\s?){8,}$");
        }

        /// <summary>
        /// Au changement de client dans la cbx
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbt_ModifClient.Checked == true || rbt_SupprClient.Checked == true)
            {
                cls_Client l_Client = (cls_Client)cbx_Client.SelectedItem;
                tbx_RaisonSociale.Text = l_Client.RaisonSociale;
                tbx_Telephone.Text = l_Client.Telephone;
                tbx_eMail.Text = l_Client.eMail;
            }
            else
            {
                Clear();
            }
        }

        /// <summary>
        /// Chargement de la fenetre : cbx client désactivée par défaut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_EditClient_Load(object sender, EventArgs e)
        {
            cbx_Client.Enabled = false;
        }

        /// <summary>
        /// Bouton retour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Retour_Click(object sender, EventArgs e)
        {
            Close();

        }

        /// <summary>
        /// Lance une action selon le rbt coché
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Valider_Click(object sender, EventArgs e)
        {
            if (rbt_AjoutClient.Checked == true)
            {
                ValiderAjout();
            }
            else
            {
                if (rbt_ModifClient.Checked == true)
                {
                    ValiderModif();
                }
                else
                {
                    ValiderSuppr();
                }
            }
        }

        /// <summary>
        /// Rbt ajout coché
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbt_AjoutClient_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            cbx_Client.Enabled = false;
            tbx_eMail.Enabled = true;
            tbx_RaisonSociale.Enabled = true;
            tbx_Telephone.Enabled = true;
            Setup();
        }

        /// <summary>
        /// Rbt modif coché
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbt_ModifClient_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            cbx_Client.Enabled = true;
            tbx_eMail.Enabled = true;
            tbx_RaisonSociale.Enabled = true;
            tbx_Telephone.Enabled = true;
            Setup();
        }

        /// <summary>
        /// Rbt suppr coché
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbt_SupprClient_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            cbx_Client.Enabled = true;
            tbx_eMail.Enabled = false;
            tbx_RaisonSociale.Enabled = false;
            tbx_Telephone.Enabled = false;
            Setup();
        }
    }
}
