using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMELE_E4
{
    public partial class frm_DetailLignesCommande : Form
    {
        private string c_Setup;
        private int c_IDLigneCommande = -1;

        public frm_DetailLignesCommande(int pIdLigneCommande = -1)
        {
            InitializeComponent();
            c_IDLigneCommande = pIdLigneCommande;
            setupProgressBar();
            setupDetailCommande();

        }

        private void setupDetailCommande()
        {
            if (c_IDLigneCommande != -1)
            {
                setupModifLigneCommande();
                c_Setup = "Modif";
            }
            else
            {
                setupAjoutLigneCommande();
                c_Setup = "Ajout";
            }
        }

        private void setupModifLigneCommande()
        {


            // -------
            // Remplissage cbx_RefCommande
            #region 
            cbx_SolRefCde.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_SolRefCde.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_ListeCommande = new AutoCompleteStringCollection();
            foreach (cls_Commande l_Commande in Program.Modele.ListeCommandes.Values)
            {
                l_ListeCommande.Add(l_Commande.ToString());
                cbx_SolRefCde.Items.Add(l_Commande);
            }
            cbx_SolRefCde.AutoCompleteCustomSource = l_ListeCommande;
            #endregion

            // -------
            // Remplissage et autocomplétion cbx_Produit
            #region        
            cbx_Produit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_Produit.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_ListeProduits = new AutoCompleteStringCollection();
            foreach (cls_Produit l_Produit in Program.Modele.ListeProduits.Values)
            {
                l_ListeProduits.Add(l_Produit.ToString());
                cbx_Produit.Items.Add(l_Produit);
            }
            cbx_Produit.AutoCompleteCustomSource = l_ListeProduits;
            #endregion

            // -------
            // Remplissage et autocomplétion cbx_tva
            #region        
            cbx_tva.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_tva.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_ListeTVA = new AutoCompleteStringCollection();
            foreach (cls_Tva l_TVA in Program.Modele.ListeTva.Values)
            {
                cbx_tva.Items.Add(l_TVA);
                l_ListeTVA.Add(l_TVA.ToString());
            }
            cbx_tva.AutoCompleteCustomSource = l_ListeTVA;
            #endregion

            cls_LigneCommande l_Ligne = Program.Modele.ListeLignesCommandes[c_IDLigneCommande];

            tbx_montantTotal.ReadOnly = true;
            tbx_noSol.ReadOnly = true;
            tbx_conditionnement.ReadOnly = true;
            tbx_prixConditionne.ReadOnly = true;
            cbx_SolRefCde.Enabled = false;

            if (l_Ligne.Etat.getID() == 1)
            {

            }
            else
            {
                if (l_Ligne.Etat.getID() == 2)
                {
                    cbx_Produit.Enabled = false;
                    cbx_tva.Enabled = false;
                }
                else
                {
                    tbx_quantite.ReadOnly = true;
                    cbx_Produit.Enabled = false;
                    cbx_tva.Enabled = false;
                }
            }

            pgb_statut.Value = l_Ligne.Etat.getID();
            lbl_statut.Text = l_Ligne.Etat.LibelleEtatSol;

            cbx_SolRefCde.SelectedItem = l_Ligne.Commande;
            cbx_Produit.SelectedItem = l_Ligne.Produit;
            tbx_quantite.Text = l_Ligne.Quantite.ToString();
            cbx_tva.SelectedItem = l_Ligne.Tva;
            tbx_noSol.Text = l_Ligne.NumeroLigne.ToString();

            tbx_montantTotal.Text = montantTotal().ToString();
        }

        private void setupAjoutLigneCommande()
        {
            // -------
            // Remplissage cbx_RefCommande
            #region 
            cbx_SolRefCde.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_SolRefCde.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_ListeCommande = new AutoCompleteStringCollection();
            foreach (cls_Commande l_Commande in Program.Modele.ListeCommandes.Values)
            {
                l_ListeCommande.Add(l_Commande.ToString());
                cbx_SolRefCde.Items.Add(l_Commande);
            }
            cbx_SolRefCde.AutoCompleteCustomSource = l_ListeCommande;
            #endregion

            // -------
            // Remplissage et autocomplétion cbx_Produit
            #region        
            cbx_Produit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_Produit.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_ListeProduits = new AutoCompleteStringCollection();
            foreach (cls_Produit l_Produit in Program.Modele.ListeProduits.Values)
            {
                l_ListeProduits.Add(l_Produit.ToString());
                cbx_Produit.Items.Add(l_Produit);
            }
            cbx_Produit.AutoCompleteCustomSource = l_ListeProduits;
            #endregion

            // -------
            // Remplissage et autocomplétion cbx_tva
            #region        
            cbx_tva.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_tva.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection l_ListeTVA = new AutoCompleteStringCollection();
            foreach (cls_Tva l_TVA in Program.Modele.ListeTva.Values)
            {
                cbx_tva.Items.Add(l_TVA);
                l_ListeTVA.Add(l_TVA.ToString());
            }
            cbx_tva.AutoCompleteCustomSource = l_ListeTVA;
            #endregion

            tbx_montantTotal.ReadOnly = true;
            tbx_noSol.ReadOnly = true;
            tbx_conditionnement.ReadOnly = true;
            tbx_prixConditionne.ReadOnly = true;
            btn_valider.Enabled = false;

            pgb_statut.Value = 1;
            lbl_statut.Text = "Devis";
        }


        private void setupProgressBar()
        {
            pgb_statut.Style = ProgressBarStyle.Continuous;
            pgb_statut.Maximum = 4;
            pgb_statut.Value = 0;

        }


        private double montantTotal()
        {
            double l_Total = 0;
            cls_Tva l_Tva = (cls_Tva)cbx_tva.SelectedItem;
            cls_Commande l_Commande = (cls_Commande)cbx_SolRefCde.SelectedItem;
            cls_Produit l_Produit = (cls_Produit)cbx_Produit.SelectedItem;

            if (cbx_SolRefCde.SelectedItem != null && cbx_SolRefCde.Text != "")
            {
                if (cbx_Produit.SelectedItem != null && cbx_Produit.Text != "")
                {
                    if (cbx_tva.SelectedItem != null && cbx_tva.Text != "")
                    {
                        double qte = Convert.ToDouble(tbx_quantite.Text);
                        double prixCdt = Convert.ToDouble(tbx_prixConditionne.Text.Replace("€", ""));

                        l_Total = qte * prixCdt *
                            (1 + (l_Tva.TauxTva / 100));
                    }
                }
            }
            return l_Total;
        }


        private void cbx_tva_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbx_montantTotal.Text = montantTotal().ToString();
        }

        private void cbx_Produit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_Produit l_Produit = (cls_Produit)cbx_Produit.SelectedItem;

            tbx_conditionnement.Text = l_Produit.Conditionnement.ToString();
            tbx_prixConditionne.Text = l_Produit.PrixConditionne.ToString() + "€";
            tbx_montantTotal.Text = montantTotal().ToString();

        }

        // TODO : Voir quand on calcule le montant total
        private void tbx_quantite_TextChanged(object sender, EventArgs e)
        {
            tbx_montantTotal.Text = montantTotal().ToString();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (c_Setup == "Ajout")
            {
                cls_LigneCommande l_Ligne = null;

                cls_Commande l_Commande = (cls_Commande)cbx_SolRefCde.SelectedItem;
                cls_Tva l_Tva = (cls_Tva)cbx_tva.SelectedItem;
                cls_Produit l_Produit = (cls_Produit)cbx_Produit.SelectedItem;

                int l_NumeroLigne = Convert.ToInt32(tbx_noSol.Text);

                int l_idLigne = cls_ObjetBase.NouvelId();
                int l_Quantite = Convert.ToInt32(tbx_quantite.Text);

                int l_StateIndex = pgb_statut.Value;
                cls_EtatSol l_Etat = Program.Modele.ListeEtatSol[l_StateIndex];



                l_Ligne = new cls_LigneCommande(l_idLigne, l_NumeroLigne,
                    l_Quantite, l_Commande, l_Etat, l_Produit, l_Tva);
                Program.Controlleur.ajoutLigneCommande(l_Ligne);
            }
            else
            {
                cls_LigneCommande l_Ligne = Program.Modele.ListeLignesCommandes[c_IDLigneCommande];

                cls_Produit l_Produit = (cls_Produit)cbx_Produit.SelectedItem;
                l_Ligne.Produit = l_Produit;

                l_Ligne.Quantite = Convert.ToInt32(tbx_quantite.Text);

                cls_Tva l_Tva = (cls_Tva)cbx_tva.SelectedItem;
                l_Ligne.Tva = l_Tva;

                Program.Controlleur.modifLigneCommande(l_Ligne);
            }

            Close();

        }

        private void cbx_SolRefCde_SelectedIndexChanged(object sender, EventArgs e)
        {
            int l_Num = 0;
            cls_Commande l_Commande = (cls_Commande)cbx_SolRefCde.SelectedItem;
            foreach (cls_LigneCommande l_Ligne in l_Commande.ListeLignesCommande)
            {
                if (l_Ligne.NumeroLigne > l_Num)
                {
                    l_Num = l_Ligne.NumeroLigne;
                }
            }
            l_Num++;
            tbx_noSol.Text = l_Num.ToString();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            cls_LigneCommande l_Ligne = Program.Modele.ListeLignesCommandes[c_IDLigneCommande];

            // Si la ligne n'est pas cloturée
            if (pgb_statut.Value < 4)
            {
                cls_EtatSol l_NouvelEtatligne = Program.Modele.ListeEtatSol[pgb_statut.Value + 1];

                Program.Controlleur.validerLigneCommande(l_Ligne, l_NouvelEtatligne);
                l_Ligne.Etat = l_NouvelEtatligne;
                pgb_statut.Value++;
                lbl_statut.Text = l_NouvelEtatligne.LibelleEtatSol;

                int l_IDLigneMin = 4;
                foreach (cls_LigneCommande l_ligneCommande in l_Ligne.Commande.ListeLignesCommande)
                {
                    // On prend le plus bas ID Etat de les lignes de la commande et on affecte cet id à la commande.
                    if (l_ligneCommande.Etat.getID() < l_IDLigneMin)
                    {
                        l_IDLigneMin = l_ligneCommande.Etat.getID();
                    }

                }
                cls_EtatSo l_NouvelEtatCommande = Program.Modele.ListeEtatSo[l_IDLigneMin];
                l_Ligne.Commande.Etat = l_NouvelEtatCommande;
                Program.Controlleur.ValiderCommande(l_Ligne.Commande, l_NouvelEtatCommande);
            }
            else
            {
                MessageBox.Show("La ligne de commande est déja cloturée.",
                    "Action impossible",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            cls_LigneCommande l_Ligne = Program.Modele.ListeLignesCommandes[c_IDLigneCommande];

            if (c_Setup == "Modif")
            {
                if (frm_Connexion.Utilisateur.Droit.getID() >= 2)
                {
                    var result = MessageBox.Show("Voulez vous vraiment supprimmer cette ligne de commande ?", "Alerte",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    // Si l'opérateur clique sur Oui
                    if (result == DialogResult.Yes)
                    {
                        Program.Controlleur.supprLigneCommande(l_Ligne);
                        Program.Modele.ListeLignesCommandes.Remove(l_Ligne.getID());
                        this.Close();

                    }
                }
                // Si l'opérateur n'est pas responsable
                else
                {
                    MessageBox.Show("Vous ne pouvez pas supprimer une ligne de commande, veuillez contacter un responsable.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
