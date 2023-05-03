using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace gestiondeappartement.Modèle
{
    class ProprietaireDAO

    {
        public static bool VerifierNumeroProprietaire(int numeroprop)
        {
            ConnexionDB.ConnexionBdd();
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();

            string reqCount = $"SELECT COUNT(*) FROM proprietaires WHERE NUMEROPROP = {numeroprop}";
            objCmd.CommandText = reqCount;
            int nbProprietaires = Convert.ToInt32(objCmd.ExecuteScalar());

            return (nbProprietaires > 0);
        }

        public static List<Proprietaire_modele> GetLesProprietaires()
        {
            ConnexionDB.ConnexionBdd();
            List<Proprietaire_modele> LesProprietaires = new List<Proprietaire_modele>();
            Proprietaire_modele proprietaire;
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();
            string reqQuery;
            reqQuery = "SELECT * FROM proprietaires";
            objCmd.CommandText = reqQuery;
            MySqlDataReader rdr = objCmd.ExecuteReader();
            int numeroprop;
            string nom;
            string prenom;
            string adresse;
            string code_ville;
            string tel;

            while (rdr.Read())
            {
                numeroprop = (int)rdr["NUMEROPROP"];
                nom = (string)rdr["NOM"];
                prenom = (string)rdr["PRENOM"];
                adresse = (string)rdr["ADRESSE"];
                code_ville = (string)rdr["CODE_VILLE"];
                tel = (string)rdr["TEL"];
                proprietaire = new Proprietaire_modele(numeroprop, nom, prenom, adresse, code_ville, tel);
                LesProprietaires.Add(proprietaire);
            }

            rdr.Close();

            return LesProprietaires;
        }
        public static List<Appartements> GetAppartementsByNumeroProp(int numeroprop)
        {
            List<Appartements> MesAppartements = new List<Appartements>();

            ConnexionDB.ConnexionBdd();
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();
            objCmd.CommandText = $"SELECT * FROM appartements WHERE numeroprop = {numeroprop}";
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
                int numeroprop_ = reader.GetInt32(11);
                int numeroloc = reader.GetInt32(12);

                Appartements appartement = new Appartements(numappart, typappart, prix_loc, prix_charg, rue, arrondissement, etage, ascenseur, preavis, date_libre,courtduree, numeroprop_, numeroloc);
                MesAppartements.Add(appartement);
            }

            reader.Close();
            return MesAppartements;
        }



    }
}
