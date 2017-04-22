using System.Collections.Generic;
using System.Linq;
using Npgsql;

namespace VMELE_E4
{
    class DAL_LigneCommande
    {
        static NpgsqlConnection c_Cnn = Program.DAL.Cnn;

        /// <summary>
        /// Select et créé la liste des lignes decommandes
        /// </summary>
        /// <returns>Liste des lignes commandes</returns>
        public static Dictionary<int, cls_LigneCommande> CreerListeLignesCommande()//cls_Commande pCommande
        {
            //cls_Commande l_Commande = pCommande;
            cls_LigneCommande l_LigneCommande = null;
            Dictionary<int, cls_LigneCommande> l_ListeLignesCommande = new Dictionary<int, cls_LigneCommande>();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;
                // Retrieve all rows
                cmd.CommandText = "SELECT id_sol, numero_ligne, quantite, id_tva, id_produit," +
                                    "id_etat, id_commande FROM ligne_de_commande"; //WHERE id_commande = " + l_Commande.getID();
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int l_IDLigneCommande = reader.GetInt32(0);
                        int l_NumeroLigne = reader.GetInt32(1);
                        int l_Quantite = reader.GetInt32(2);
                        int l_IDTva = reader.GetInt32(3);
                        int l_IDProduit = reader.GetInt32(4);
                        int l_IDEtat = reader.GetInt32(5);
                        int l_IDCommande = reader.GetInt32(6);
                        l_LigneCommande = new cls_LigneCommande(l_IDLigneCommande, l_NumeroLigne,
                            l_Quantite, Program.Modele.ListeCommandes[l_IDCommande],
                            Program.Modele.ListeEtatSol[l_IDEtat],
                            Program.Modele.ListeProduits[l_IDProduit],
                            Program.Modele.ListeTva[l_IDTva]);
                        l_ListeLignesCommande.Add(l_IDLigneCommande, l_LigneCommande);
                    }
                }
            }
            return l_ListeLignesCommande;
        }


        /// <summary>
        /// Select et créé la liste des lignes decommandes
        /// </summary>
        /// <returns>Liste des lignes commandes</returns>
        public static Dictionary<int, cls_LigneCommande> selectLignesCommandeConditions(List<string> pConditions)
        {
                string l_ConditionsTexte = "";
                cls_LigneCommande l_LigneCommande = null;
                Dictionary<int, cls_LigneCommande> l_ListeLignesCommande = new Dictionary<int, cls_LigneCommande>();
            if (pConditions.Any())
            {
                l_ConditionsTexte = " AND " + string.Join(" AND ", pConditions.ToArray());
            }
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;
                // Retrieve all rows
                cmd.CommandText = "SELECT id_sol, reference_commande, numero_ligne, quantite, ligne_de_commande.id_commande, " +
                                    "ligne_de_commande.id_tva, id_produit," +
                                    "ligne_de_commande.id_etat FROM ligne_de_commande, commande " +
                                    "WHERE ligne_de_commande.id_commande = commande.id_commande " + l_ConditionsTexte +
                                    " ORDER BY reference_commande, numero_ligne;";
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int l_IDLigneCommande = reader.GetInt32(0);
                        string l_ReferenceCommande = reader.GetString(1);
                        int l_NumeroLigne = reader.GetInt32(2);
                        int l_Quantite = reader.GetInt32(3);
                        int l_IDCommande = reader.GetInt32(4);
                        int l_IDTva = reader.GetInt32(5);
                        int l_IDProduit = reader.GetInt32(6);
                        int l_IDEtat = reader.GetInt32(7);

                        l_LigneCommande = new cls_LigneCommande(l_IDLigneCommande, l_NumeroLigne,
                            l_Quantite, Program.Modele.ListeCommandes[l_IDCommande],
                            Program.Modele.ListeEtatSol[l_IDEtat],
                            Program.Modele.ListeProduits[l_IDProduit],
                            Program.Modele.ListeTva[l_IDTva]);
                        l_ListeLignesCommande.Add(l_IDLigneCommande, l_LigneCommande);
                    }
                }
            }
            return l_ListeLignesCommande;
        }

        public static void InsertLigne(cls_LigneCommande pLigne)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;

                // Retrieve all rows
                cmd.CommandText = "insert into ligne_de_commande " +
                    "(id_sol, numero_ligne, quantite, id_commande, id_tva, id_produit, id_etat)"
                     + "values (" + pLigne.getID() + "," + 
                     pLigne.NumeroLigne + ", " + 
                     pLigne.Quantite + ", " + 
                     pLigne.Commande.getID() + ", " + 
                     pLigne.Tva.getID() + ", " + 
                     pLigne.Produit.getID() + ", " + 
                     pLigne.Etat.getID() +");";
                int l_Nb = cmd.ExecuteNonQuery();
                Program.Modele.ListeLignesCommandes.Add(pLigne.getID(), pLigne);
            }
        }

        public static void ModifLigne(cls_LigneCommande pLigne)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;

                // Retrieve all rows
                cmd.CommandText = "update ligne_de_commande set id_produit = " + pLigne.Produit.getID() +
                    ", id_tva = " + pLigne.Tva.getID() + ", quantite = " + pLigne.Quantite +
                    " WHERE id_sol = " + pLigne.getID();
                int l_Nb = cmd.ExecuteNonQuery();
            }
        }

        public static void SupprLign(cls_LigneCommande pLigne)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;

                cmd.CommandText = "DELETE FROM ligne_de_commande WHERE id_sol=" + pLigne.getID();
                int l_Nb = cmd.ExecuteNonQuery();
            }
        }

        public static void ValiderLigne(cls_LigneCommande pLigne, cls_EtatSol pEtat)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;

                // Retrieve all rows
                cmd.CommandText = "update ligne_de_commande set id_etat = " + pEtat.getID()
                    + " WHERE id_sol = " + pLigne.getID();
                int l_Nb = cmd.ExecuteNonQuery();
            }
        }

    }
}
