using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMELE_E4
{
    public class cls_Client : cls_ObjetBase
    {
        private int c_IDClient;
        private string c_RaisonSociale;

        public cls_Client(int pIDClient, string pRaisonSociale) : base(pIDClient)
        {
            c_RaisonSociale = pRaisonSociale;
        }

        public int IDClient
        {
            get
            {
                return c_IDClient;
            }
            set
            {
                c_IDClient = value;
            }
        }
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
        public override string ToString()
        {
            return c_RaisonSociale;
        }
    }
}
