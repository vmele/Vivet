using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chantier
{
    public partial class frm_DetailChantier : Form
    {
        /// <summary>
        /// Constructeur de la frm_DetailChantier
        /// </summary>
        /// <param name="pChantierChoisi">Chantier double-cliqué</param>
        public frm_DetailChantier(cls_Chantier pChantierChoisi)
        {
            InitializeComponent();
            RemplissageChamps(pChantierChoisi);
            
        }

        /// <summary>
        /// Rempli les champs en fonction du chantier sélectionné
        /// </summary>
        /// <param name="pChantierChoisi">Chantier sélectionné</param>
        private void RemplissageChamps(cls_Chantier pChantierChoisi)
        {
            tbx_Montant.Text = Convert.ToString(pChantierChoisi.Montant);
            dtp_DateDebut.Value = pChantierChoisi.DateDebut;
            tbx_NomChantier.Text = pChantierChoisi.Nom;
            tbx_Client.Text = Convert.ToString(pChantierChoisi.getClientParID(pChantierChoisi));

        }
        /// <summary>
        /// Ferme la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CloseWindows_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
