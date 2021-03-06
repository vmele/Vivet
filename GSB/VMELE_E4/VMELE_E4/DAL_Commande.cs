﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace VMELE_E4
{
    public class DAL_Commande
    {
        static NpgsqlConnection c_Cnn = Program.DAL.Cnn;

        /// <summary>
        /// Select et créé la liste des commandes
        /// </summary>
        /// <returns>Liste des commandes</returns>
        public static Dictionary<int, cls_Commande> CreerListeCommande()
        {
            cls_Commande l_Commande = null;
            Dictionary<int, cls_Commande> l_ListeCommande = new Dictionary<int, cls_Commande>();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;
                // Retrieve all rows
                cmd.CommandText = "SELECT id_commande, reference_commande, date_commande," +
                                    "date_demandee, id_type, id_contact, id_etat," +
                                    "id_client, id_personne FROM commande order by id_commande, reference_commande, date_commande, date_demandee, id_type, id_contact, id_etat, id_client, id_personne; ";
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int l_IDCommande = reader.GetInt32(0);
                        string l_ReferenceCommande = reader.GetString(1);
                        DateTime l_DateCommande = reader.GetDateTime(2);
                        DateTime l_DateDemandee = reader.GetDateTime(3);
                        int l_IDType = reader.GetInt32(4);
                        int l_IDContact = reader.GetInt32(5);
                        int l_IDEtat = reader.GetInt32(6);
                        int l_IDClient = reader.GetInt32(7);
                        int l_IDUtilisateur = reader.GetInt32(8);

                        l_Commande = new cls_Commande(l_IDCommande, l_ReferenceCommande, l_DateCommande,
                            l_DateDemandee, Program.Modele.ListeClients[l_IDClient], 
                            Program.Modele.ListeMoyensContact[l_IDContact],
                            Program.Modele.ListeEtatSo[l_IDEtat],
                            Program.Modele.ListeUtilisateurs[l_IDUtilisateur],
                            Program.Modele.ListeTypesCommandes[l_IDType]);
                        l_ListeCommande.Add(l_IDCommande, l_Commande);
                    }
                }
            }
            return l_ListeCommande;
        }

        public static Dictionary<int, cls_Commande> selectCommandesConditions(List<string> pConditions)
        {
            string l_ConditionsTexte = "";
            cls_Commande l_Commande = null;
            Dictionary<int, cls_Commande> l_ListeCommande = new Dictionary<int, cls_Commande>();
            if (pConditions.Any())
            {
                l_ConditionsTexte = " AND " + string.Join(" AND ", pConditions.ToArray());
            }
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;
                // Retrieve all rows
                cmd.CommandText = "SELECT cde.id_commande, cde.reference_commande, date_commande," +
                                    "date_demandee, id_type, id_contact, cde.id_etat," +
                                    "id_client, id_personne, sum(quantite*prix_cdt*(1 + taux / 100.00)) " +
                                    "as total FROM commande as cde, ligne_de_commande as ligne, produit as p, " +
                                    "tva WHERE cde.id_commande = ligne.id_commande " +
                                    "and ligne.id_produit = p.id_produit " +
                                    "and ligne.id_tva = tva.id_tva " + l_ConditionsTexte +
                                    " group by cde.id_commande, cde.reference_commande, date_commande, date_demandee, id_type, id_contact, cde.id_etat, id_client, id_personne " +
                                    " order by cde.id_commande, cde.reference_commande, date_commande, date_demandee, id_type, id_contact, cde.id_etat, id_client, id_personne;";
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int l_IDCommande = reader.GetInt32(0);
                        string l_ReferenceCommande = reader.GetString(1);
                        DateTime l_DateCommande = reader.GetDateTime(2);
                        DateTime l_DateDemandee = reader.GetDateTime(3);
                        int l_IDType = reader.GetInt32(4);
                        int l_IDContact = reader.GetInt32(5);
                        int l_IDEtat = reader.GetInt32(6);
                        int l_IDClient = reader.GetInt32(7);
                        int l_IDUtilisateur = reader.GetInt32(8);
                        float l_MontantTotal = reader.GetFloat(9);
                        l_Commande = new cls_Commande(l_IDCommande, l_ReferenceCommande, l_DateCommande,
                            l_DateDemandee, Program.Modele.ListeClients[l_IDClient],
                            Program.Modele.ListeMoyensContact[l_IDContact],
                            Program.Modele.ListeEtatSo[l_IDEtat],
                            Program.Modele.ListeUtilisateurs[l_IDUtilisateur],
                            Program.Modele.ListeTypesCommandes[l_IDType], l_MontantTotal);
                        l_ListeCommande.Add(l_IDCommande, l_Commande);
                    }
                }
            }
            return l_ListeCommande;
        }

        public static void InsertCommande(cls_Commande pCommande)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;

                // Retrieve all rows
                cmd.CommandText = "insert into commande (id_commande, reference_commande, date_commande, date_demandee, id_type, id_contact, id_etat, id_client, id_personne)"
                     + "values (" + pCommande.getID() + ",'" + pCommande.RefCommande + "', '" + pCommande.DateCommande + "', '" + pCommande.DateVoulue + "'" +
                     ", " + pCommande.TypeCommande.getID() + ", " + pCommande.MoyenContact.getID() + ", " + pCommande.Etat.getID() + ", " + pCommande.Client.getID() + ", " + pCommande.Utilisateur.getID() + ");";
                int l_Nb = cmd.ExecuteNonQuery();
                Program.Modele.ListeCommandes.Add(pCommande.getID(), pCommande);
            }
        }

        public static void ModifCommande(cls_Commande pCommande)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;

                // Retrieve all rows
                cmd.CommandText = "update commande set date_commande ='" + pCommande.DateCommande +
                    "', date_demandee='" + pCommande.DateVoulue + "', id_type ='" + pCommande.TypeCommande.getID() + "'," +
                    "id_contact ='" + pCommande.MoyenContact.getID() + "', id_etat = '" + pCommande.Etat.getID() +
                    "', id_client = '" + pCommande.Client.getID() + "' WHERE id_commande = " + pCommande.getID();
                int l_Nb = cmd.ExecuteNonQuery();

            }
        }
        public static void SupprCommande(cls_Commande pCommande)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;

                cmd.CommandText = "DELETE FROM commande WHERE id_commande=" + pCommande.getID();
                int l_Nb = cmd.ExecuteNonQuery();

            }
        }

        public static void ValiderCommande(cls_Commande pCommande, cls_EtatSo pEtat)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = c_Cnn;

                // Retrieve all rows
                cmd.CommandText = "update commande set id_etat =" + pEtat.getID()  + " WHERE id_commande = " + pCommande.getID();
                int l_Nb = cmd.ExecuteNonQuery();

            }
        }

    }
}
