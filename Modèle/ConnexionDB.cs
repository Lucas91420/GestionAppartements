using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace gestiondeappartement.Modèle
{
    class ConnexionDB
    {

        public static string connexion = @"server=localhost;userid=Lucas;password=;database=gestiondeappartement";
        public static MySqlConnection conn = null;

        public static bool ConnexionBdd()
        {
            conn = new MySqlConnection(connexion);
            conn.Open();

            return (conn.State == System.Data.ConnectionState.Open);

        }

        /* public static Adherent_modele Connexion(string nom, string prenom)
         {
             ConnexionBdd();
             Adherent_modele objCompte = null;
             MySqlCommand objCmd;
             objCmd = conn.CreateCommand();
             string reqQuery;
             reqQuery = "Select * from Client,locataire,propriétaire WHERE NOM = @nom AND PRENOM = @prenom ";
             objCmd.Parameters.AddWithValue("@nom", nom);
             objCmd.Parameters.AddWithValue("@prenom", prenom);
             objCmd.CommandText = reqQuery;
             MySqlDataReader rdr = objCmd.ExecuteReader();

             while (rdr.Read())
             {
             objCompte = new Adherent_modele(rdr.GetInt32("num"), rdr.GetString("nom"), rdr.GetString("prenom"));
             }
             rdr.Close();

             return objCompte;


         }
        */

        public static object Connexion(string nom, string prenom)
        {
            ConnexionBdd();
            object objCompte = null;
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            string reqQuery;
            reqQuery = "Select * from clients WHERE NOM = @nom AND PRENOM = @prenom ";
            objCmd.Parameters.AddWithValue("@nom", nom);
            objCmd.Parameters.AddWithValue("@prenom", prenom);
            objCmd.CommandText = reqQuery;
            MySqlDataReader rdr = objCmd.ExecuteReader();

            while (rdr.Read())
            {
                objCompte = new Client(rdr.GetInt32("num_cli"), rdr.GetString("nom"), rdr.GetString("prenom"), rdr.GetString("adresse"), rdr.GetString("codeville"), rdr.GetString("tel"));
            }

            rdr.Close();

            return objCompte;
        }
        public static object ConnexionProprietaire(string nom, string prenom)
        {
            
                ConnexionBdd();
                object objCompte = null;
                MySqlCommand objCmd;
                objCmd = conn.CreateCommand();
                string reqQuery;
                reqQuery = "SELECT numeroprop, nom, prenom, adresse, code_ville, tel FROM proprietaires WHERE NOM = @nom AND PRENOM = @prenom";
                objCmd.Parameters.AddWithValue("@nom", nom);
                objCmd.Parameters.AddWithValue("@prenom", prenom);
                objCmd.CommandText = reqQuery;
                MySqlDataReader rdr = objCmd.ExecuteReader();

                while (rdr.Read())
                {
                    objCompte = new Proprietaire_modele(rdr.GetInt32("numeroprop"), rdr.GetString("nom"), rdr.GetString("prenom"), rdr.GetString("adresse"), rdr.GetString("code_ville"), rdr.GetString("tel"));
                }

                rdr.Close();

                return objCompte;
            

        
        }
        public static object ConnexionLocataire(string nom, string prenom)
        {

            ConnexionBdd();
            object objCompte = null;
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            string reqQuery;
            reqQuery = "SELECT numeroloc, nom, prenom, datenaiss, tel, R_I_B, banque, rue_banque, codeville_banque, tel_banque FROM locataires WHERE NOM = @nom AND PRENOM = @prenom";
            objCmd.Parameters.AddWithValue("@nom", nom);
            objCmd.Parameters.AddWithValue("@prenom", prenom);
            objCmd.CommandText = reqQuery;
            MySqlDataReader rdr = objCmd.ExecuteReader();

            while (rdr.Read())
            {
                objCompte = new Locataire_modele(rdr.GetInt32("numeroloc"), rdr.GetString("nom"), rdr.GetString("prenom"), rdr.GetDateTime("datenaiss"), rdr.GetString("tel"), rdr.GetInt32("R_I_B"), rdr.GetString("banque"), rdr.GetString("rue_banque"), rdr.GetString("codeville_banque"), rdr.GetString("tel_banque"));
            }

            rdr.Close();

            return objCompte;
        }
    }
}




        /*
        ConnexionBdd();
        object objCompte = null;
        MySqlCommand objCmd;
        objCmd = conn.CreateCommand();
        string reqQuery;
        reqQuery = "SELECT * FROM clients WHERE NOM_CLI = @nom AND PRENOM_CLI = @prenom; " +
                   "SELECT * FROM locataires WHERE NOM_LOC = @nom AND PRENOM_LOC = @prenom; " +
                   "SELECT * FROM proprietaires WHERE NOM = @nom AND PRENOM = @prenom; ";
        objCmd.Parameters.AddWithValue("@nom", nom);
        objCmd.Parameters.AddWithValue("@prenom", prenom);
        objCmd.CommandText = reqQuery;

        MySqlDataReader rdr = objCmd.ExecuteReader();

        while (rdr.HasRows)
        {
            rdr.Read();

            if (rdr.GetName(0).Equals("num_cli"))
            {
                Client cli = new Client(rdr.GetInt32("num_cli"), rdr.GetString("nom"), rdr.GetString("prenom"));
                objCompte = cli;
                break;
            }
            else if (rdr.GetName(0).Equals("numeroloc"))
            {
                Locataire_modele loc = new Locataire_modele(rdr.GetInt32("numeroloc"), rdr.GetString("nom"), rdr.GetString("prenom"));
                objCompte = loc;
                break;
            }
            else if (rdr.GetName(0).Equals("numeroprop"))
            {
                Proprietaire_modele prop = new Proprietaire_modele(rdr.GetInt32("numeroprop"), rdr.GetString("nom"), rdr.GetString("prenom"));
                objCompte = prop;
                break;
            }
        }
        rdr.Close();

        return objCompte;
        */
