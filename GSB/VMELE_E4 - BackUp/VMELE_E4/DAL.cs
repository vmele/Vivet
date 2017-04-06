using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace VMELE_E4
{
    class DAL
    {
        static NpgsqlConnection c_Cnn;

        public DAL(string pServeur, string pNomUtilisateur, string pMP)
        {
            string Conn = System.String.Format("Host = {0}; Username = {1}; Password = {2}; Database = e4_vmele", pServeur, pNomUtilisateur, pMP);
            c_Cnn = new NpgsqlConnection(Conn);
            c_Cnn.Open();

        }

        public NpgsqlConnection Cnn
        {
            get
            {
                return c_Cnn;
            }
        }
    }
}
