using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace gestiondeappartement.Modèle
{
    class LocataireDAO
    {
        public static bool VerifierNumeroLocataire(int numeroloc)
        {
            ConnexionDB.ConnexionBdd();
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();

            string reqCount = $"SELECT COUNT(*) FROM locataires WHERE NUMEROLOC = {numeroloc}";
            objCmd.CommandText = reqCount;
            int nbLocataires = Convert.ToInt32(objCmd.ExecuteScalar());

            return (nbLocataires > 0);
        }

        public static List<Locataire_modele> GetLesLocataires()
        {
            ConnexionDB.ConnexionBdd();
            List<Locataire_modele> LesLocataires = new List<Locataire_modele>();
            Locataire_modele locataire;
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();
            string reqQuery;
            reqQuery = "SELECT * FROM locataires";
            objCmd.CommandText = reqQuery;
            MySqlDataReader rdr = objCmd.ExecuteReader();
            int numeroloc;
            string nom;
            string prenom;
            DateTime datenaiss;
            string tel;
            int R_I_B;
            string banque;
            string rue_banque;
            string codeville_banque;
            string tel_banque;

            while (rdr.Read())
            {
                numeroloc = (int)rdr["NUMEROLOC"];
                nom = (string)rdr["NOM"];
                prenom = (string)rdr["PRENOM"];
                datenaiss = (DateTime)rdr["DATENAISS"];
                tel = (string)rdr["TEL"];
                R_I_B = (int)rdr["R_I_B"];
                banque = (string)rdr["BANQUE"];
                rue_banque = (string)rdr["RUE_BANQUE"];
                codeville_banque = (string)rdr["CODEVILLE_BANQUE"];
                tel_banque = (string)rdr["TEL_BANQUE"];
                locataire = new Locataire_modele(numeroloc, nom, prenom, datenaiss, tel, R_I_B, banque, rue_banque, codeville_banque, tel_banque);
                LesLocataires.Add(locataire);
            }

            rdr.Close();
            return LesLocataires;
        }
        public static List<Appartements> GetAppartementsByNumeroLoc(int numeroloc)
        {
            List<Appartements> MesAppartements = new List<Appartements>();

            ConnexionDB.ConnexionBdd();
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();
            objCmd.CommandText = $"SELECT * FROM appartements WHERE numeroloc = {numeroloc}";
            MySqlDataReader reader = objCmd.ExecuteReader();

            while (reader.Read())
            {
                int numappart = reader.GetInt32(0);
                string typappart = reader.GetString(1);
                decimal prix_loc = reader.GetDecimal(2);
                decimal prix_charg = reader.GetDecimal(3);
                string rue = reader.GetString(4);
                int arrondissement = reader.GetInt32(5);
                int etage = reader.GetInt32(6);
                int ascenseur = reader.GetInt32(7);
                int preavis = reader.GetInt32(8);
                DateTime date_libre = reader.GetDateTime(9);
                int courtduree = reader.GetInt32(10);
                int numeroprop = reader.GetInt32(11);
                int numeroloc_ = reader.GetInt32(12);

                Appartements appartement = new Appartements(numappart, typappart, prix_loc, prix_charg, rue, arrondissement, etage, ascenseur, preavis, date_libre,courtduree, numeroprop, numeroloc_);
                MesAppartements.Add(appartement);
            }

            reader.Close();
            return MesAppartements;
        }
    }
}
