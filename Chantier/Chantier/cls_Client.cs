using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chantier
{
    public class cls_Client : cls_ObjetBase
    {
        private string c_RaisonSociale;
        private string c_Telephone;
        private string c_Mail;

        /// <summary>
        /// Contructeur du client
        /// </summary>
        /// <param name="pIDClient">ID du client</param>
        /// <param name="pRaisonSociale">Raison sociale du client</param>
        /// <param name="pTelephone">Téléhpone du client</param>
        /// <param name="pMail">Mail du client</param>
        public cls_Client(int pIDClient, string pRaisonSociale, string pTelephone, string pMail) : base(pIDClient)
        {
            c_RaisonSociale = pRaisonSociale;
            c_Telephone = pTelephone;
            c_Mail = pMail;
        }

        /// <summary>
        /// Redéfinition du ToString(), il revoie la raison sociale du client
        /// </summary>
        /// <returns>Raison sociale</returns>
        public override string ToString()
        {
            return c_RaisonSociale;
        }

        /// <summary>
        /// Accesseur de la raison sociale
        /// </summary>
        public string RaisonSociale
        {
            get
            {
                return c_RaisonSociale;
            }
            set
            {
                c_RaisonSociale = value;
            }
        }

        /// <summary>
        /// Accesseur du telephone du client
        /// </summary>
        public string Telephone
        {
            get
            {
                return c_Telephone;
            }
            set
            {
                c_Telephone = value;
            }
        }

        /// <summary>
        /// Accesseur du mail du client
        /// </summary>
        public string eMail
        {
            get
            {
                return c_Mail;
            }
            set
            {
                c_Mail = value;
            }
        }
    }
}

