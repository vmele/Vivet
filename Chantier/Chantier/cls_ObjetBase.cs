using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chantier
{
    public class cls_ObjetBase
    {
        int c_ID;
        static int s_IDMax;

        /// <summary>
        /// Constructeur de ObjetBase
        /// </summary>
        /// <param name="pID">ID</param>
        public cls_ObjetBase(int pID)
        {
            c_ID = pID;
            if (s_IDMax < pID)
            {
                s_IDMax = pID;
            }
        }

        /// <summary>
        /// Créé un nouvel ID en fonction de l'ID max
        /// </summary>
        /// <returns></returns>
        public static int NouvelId()
        {
            s_IDMax = s_IDMax + 1;
            return s_IDMax;
        }

        /// <summary>
        /// Accesseur de l'ID
        /// </summary>
        /// <returns></returns>
        public int getID()
        {
            return c_ID;
        }
    }
}
