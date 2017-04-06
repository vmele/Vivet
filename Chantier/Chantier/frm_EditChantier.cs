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
    public partial class frm_EditChantier : Form
    {
        private frm_ListeChantier c_ListeChantier;

        /// <summary>
        /// Constructeur de la frm_EditChantier
        /// </summary>
        /// <param name="pChantier">Chantier</param>
        /// <param name="pFrmListeChantier">Form ListeChantier pour utiliser les methodes publiques ici.</param>
        public frm_EditChantier(cls_Chantier pChantier, frm_ListeChantier pFrmListeChantier)
        {
            InitializeComponent();
            Setup();
            // Variable ListeChantier
            c_ListeChantier = pFrmListeChantier;
        }

        /// <summary>
        /// Fill les cbx
        /// </summary>
        private void Setup()
        {
            foreach (cls_Client l_Client in Program.Modele.ListeClient.Values)
            {
                cbx_Clients.Items.Add(l_Client);
            }

            foreach (cls_Chantier l_Chantier in Program.Modele.ListeChantier.Values)
            {
                cbx_Chantier.Items.Add(l_Chantier);
            }
        }

        /// <summary>
        /// Si rbt ajout est coché
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbt_AjoutChantier_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            lbl_Chantier.Enabled = false;
            cbx_Chantier.Enabled = false;
            dtp_DateDebut.Enabled = true;
            tbx_MontantChantier.Enabled = true;
            tbx_NomChantier.Enabled = true;
            cbx_Clients.Enabled = true;
            Setup();
        }

        /// <summary>
        /// si rbt modif est coché
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbt_ModifChantier_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            lbl_Chantier.Enabled = true;
            cbx_Chantier.Enabled = true;
            dtp_DateDebut.Enabled = true;
            tbx_MontantChantier.Enabled = true;
            tbx_NomChantier.Enabled = true;
            cbx_Clients.Enabled = true;
            Setup();
        }

        /// <summary>
        /// si rbt suppr est coché
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbt_SupprChantier_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            lbl_Chantier.Enabled = true;
            cbx_Chantier.Enabled = true;
            dtp_DateDebut.Enabled = false;
            tbx_MontantChantier.Enabled = false; ;
            tbx_NomChantier.Enabled = false; ;
            cbx_Clients.Enabled = false;
            Setup();

        }

        /// <summary>
        /// Clear les objets form
        /// </summary>
        private void Clear()
        {
            dtp_DateDebut.ResetText();
            tbx_MontantChantier.Clear();
            tbx_NomChantier.Clear();
            cbx_Chantier.Items.Clear();
            cbx_Clients.Items.Clear();
        }

        /// <summary>
        /// Effectue une action selon le rbt choisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Valider_Click(object sender, EventArgs e)
        {
            if (rbt_AjoutChantier.Checked == true)
            {
                ValiderAjout();
                c_ListeChantier.SetupListBox();               
            }
            else
            {
                if (rbt_ModifChantier.Checked == true)
                {
                    ValiderModif();
                    c_ListeChantier.SetupListBox();
                }
                else
                {
                    ValiderSuppr();
                    c_ListeChantier.SetupListBox();
                }
            }
        }



        /// <summary>
        /// Ajout d'un nouveau chantier
        /// </summary>
        private void ValiderAjout()
        {
            if (cbx_Clients.SelectedItem == null || cbx_Clients.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un client valide.",
                    "Attention",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (MontantRegex(tbx_MontantChantier.Text.Replace('.',',')) == false || Double.Parse(tbx_MontantChantier.Text.Replace('.', ',')) < 0)
                {
                    MessageBox.Show("Veuillez saisir un montant valide.",
                        "Attention",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (tbx_NomChantier.Text == "")
                    {
                        MessageBox.Show("Veuillez saisir un nom de chantier valide.",
                            "Attention",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        cls_Client l_Client = (cls_Client)cbx_Clients.SelectedItem;
                        string l_DateDebut = dtp_DateDebut.Value.ToString("yyyy-MM-dd");
                        cls_Chantier l_Chantier = new cls_Chantier(cls_ObjetBase.NouvelId(), tbx_NomChantier.Text, DateTime.Parse(l_DateDebut),
                            double.Parse(tbx_MontantChantier.Text.Replace('.', ',')), l_Client.getID());
                        // Ajoute le chantier au tampon
                        Program.Controlleur.ListeAjoutTampon.Add(l_Chantier);
                        Program.Modele.ListeChantier.Add(l_Chantier.getID(), l_Chantier);
                        this.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Modifie un chantier
        /// </summary>
        private void ValiderModif()
        {
            if (cbx_Clients.SelectedItem == null || cbx_Clients.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un client valide.",
                    "Attention",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (MontantRegex(tbx_MontantChantier.Text.Replace('.', ',')) == false || Double.Parse(tbx_MontantChantier.Text.Replace('.', ',')) < 0)
                {
                    MessageBox.Show("Veuillez saisir un montant valide.",
                        "Attention",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (tbx_NomChantier.Text == "")
                    {
                        MessageBox.Show("Veuillez saisir un nom de chantier valide.",
                            "Attention",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        string l_DateDebut = dtp_DateDebut.Value.ToString("yyyy-MM-dd");
                        // Update du chantier
                        cls_Chantier l_Chantier = (cls_Chantier)cbx_Chantier.SelectedItem;
                        cls_Client l_Client = (cls_Client)cbx_Clients.SelectedItem;
                        l_Chantier.Nom = tbx_NomChantier.Text;
                        l_Chantier.Montant = Double.Parse(tbx_MontantChantier.Text.Replace('.', ','));
                        l_Chantier.DateDebut = DateTime.Parse(dtp_DateDebut.Text);
                        l_Chantier.ClientID = l_Client.getID();

                        try
                        {
                            Program.Controlleur.ListeModifTampon.Add(l_Chantier.getID(), l_Chantier);
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Cet enregistrement est déja présent. Veuillez tout enregistrer pour effectuer à nouveau une modification sur cet élément.",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                        }
                    }
                        this.Close();
                }
            }
        }


        /// <summary>
        /// Modifie un chantier
        /// </summary>
        private void ValiderSuppr()
        {
            if (cbx_Chantier.SelectedItem == null || cbx_Chantier.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un chantier valide.",
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
                        cls_Chantier l_Chantier = (cls_Chantier)cbx_Chantier.SelectedItem;
                        Program.Modele.ListeChantier.Remove(l_Chantier.getID());
                        Program.Controlleur.ListeSupprTampon.Add(l_Chantier);
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
        /// Rempli les cbx / tbx / dtp lorsque l'on choisit un chantier en mode modif et suppr
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_Chantier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbt_ModifChantier.Checked == true || rbt_SupprChantier.Checked == true)
            {
                cls_Chantier l_Chantier = (cls_Chantier)cbx_Chantier.SelectedItem;
                tbx_MontantChantier.Text = Convert.ToString(l_Chantier.Montant);
                tbx_NomChantier.Text = l_Chantier.Nom;
                dtp_DateDebut.Value = l_Chantier.DateDebut;
                // Met le bon client dans la cbx client
                cbx_Clients.SelectedItem = l_Chantier.getClientParID(l_Chantier);
            }
            else
            {
                Clear();
            }
        }

        /// <summary>
        /// Boutton annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Corrige le soucis de la cbx_Chantier qui ne se grise pas au chargement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_EditChantier_Load(object sender, EventArgs e)
        {
            cbx_Chantier.Enabled = false;
        }

        /// <summary>
        /// Autorise seulement les entrée de controle, de nombre et de ponctuation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_MontantChantier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool MontantRegex(string pMontant)
        {
            return Regex.IsMatch(pMontant, @"^[1-9]\d*(,\d+)?$");
        }
    }
}
