using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace gestiondeappartement.Modèle
{
    class AppartementDAO
    {
        
        public static List<Appartements> LesAppartements = new List<Appartements>();
        //public static ConnexionDB maConnexion = new ConnexionDB();
        //public static string connexion = @"server=localhost;userid=Lucas;password=;database=gestiondeappartement";
        
        public static List<Appartements> GetLesAppartements()//Afficher tous les appartements
        {
            ConnexionDB.ConnexionBdd();
            List<Appartements> LesAppartements = new List<Appartements>();
            Appartements a;
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();
            string reqQuery;
            reqQuery = "Select * from appartements";
            objCmd.CommandText = reqQuery;
            MySqlDataReader rdr = objCmd.ExecuteReader();
            int NUMAPPART;
            string TYPAPPART;
            decimal PRIX_LOC;
            decimal PRIX_CHARG;
            string RUE;
            int ARRONDISSEMENT;
            int ETAGE;
            int ASCENSEUR;
            int PREAVIS;
            DateTime DATE_LIBRE;
            int COURTDUREE;
            int NUMEROPROP;
            int NUMEROLOC;



            while (rdr.Read())
            {
                NUMAPPART = (int)rdr["NUMAPPART"];
                TYPAPPART = (string)rdr["TYPAPPART"];
                PRIX_LOC = (decimal)rdr["PRIX_LOC"];
                PRIX_CHARG = (decimal)rdr["PRIX_CHARG"];
                RUE = (string)rdr["RUE"];
                ARRONDISSEMENT = (int)rdr["ARRONDISSEMENT"];
                ETAGE = (int)rdr["ETAGE"];
                ASCENSEUR = (int)rdr["ASCENSEUR"];
                PREAVIS = (int)rdr["PREAVIS"];
                DATE_LIBRE = (DateTime)rdr["DATE_LIBRE"];
                COURTDUREE = (int)rdr["COURTDUREE"];
                NUMEROPROP = (int)rdr["NUMEROPROP"];
                NUMEROLOC = (int)rdr["NUMEROLOC"];

                a = new Appartements(NUMAPPART, TYPAPPART, PRIX_LOC, PRIX_CHARG, RUE , ARRONDISSEMENT, ETAGE, ASCENSEUR, PREAVIS,DATE_LIBRE,COURTDUREE,NUMEROPROP,NUMEROLOC);
                LesAppartements.Add(a);
            }
            rdr.Close();
            return LesAppartements;
        }
        public static bool SupprimerAppartement(int numappart)
        {
            ConnexionDB.ConnexionBdd();
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();

            string reqCount = $"DELETE FROM appartements WHERE NUMAPPART = {numappart}";
            objCmd.CommandText = reqCount;
            int nbMaj = objCmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }
        public static bool AjouterAppartement(Appartements a)
        {
            ConnexionDB.ConnexionBdd();
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();

            string reqInsert = $"INSERT INTO appartements (NUMAPPART,TYPAPPART, PRIX_LOC, PRIX_CHARG, RUE, ARRONDISSEMENT, ETAGE, ASCENSEUR, PREAVIS, DATE_LIBRE, NUMEROPROP, NUMEROLOC) " +
                              $"VALUES ('{a.GetNumAppart()}',{a.GetTypappart()}', {a.GetPrixLoc()}, {a.GetPrixCharg()}, '{a.GetRue()}', {a.GetArrondissement()}, {a.GetEtage()}, {a.GetAscenceur()}, {a.GetPreavis()}, '{a.GetDateLibre().ToString("yyyy-MM-dd")}', {a.GetNumprop()}, {a.GetNumloc()})";
            objCmd.CommandText = reqInsert;

            int nbMaj = objCmd.ExecuteNonQuery();

            return (nbMaj == 1);
        }

        internal static List<String> GetToutesLesTypes()
        {
            ConnexionDB.ConnexionBdd();
            List<String> lesTypes = new List<string>();
            string codetypeprod;
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();
            string req;

            req = "SELECT ";
            objCmd.CommandText = req;
            MySqlDataReader rdr = objCmd.ExecuteReader();

            while (rdr.Read())
            {
                codetypeprod = rdr.GetString("CODETYPEPROD");
                lesTypes.Add(codetypeprod);

            }
            rdr.Close();
            return lesTypes;
        }
        public static bool ModifierAppartement(int numappart, string typappart, decimal prix_loc, decimal prix_charg, string rue, int arrondissement, int etage, int ascenseur, int preavis, DateTime date_libre, int numeroprop, int numeroloc)
        {
            ConnexionDB.ConnexionBdd();
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();

            string reqCount = $"UPDATE appartements SET  TYPAPPART = '{typappart}', PRIX_LOC = {prix_loc}, PRIX_CHARG = {prix_charg}, RUE = '{rue}', ARRONDISSEMENT = {arrondissement}, ETAGE = {etage}, ASCENSEUR = {ascenseur}, PREAVIS = {preavis}, DATE_LIBRE = '{date_libre:yyyy-MM-dd}', NUMEROPROP = {numeroprop}, NUMEROLOC = {numeroloc} WHERE NUMAPPART = {numappart}";
            objCmd.CommandText = reqCount;
            int nbMaj = objCmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }
        public static bool VerifierNumeroAppartement(int numappart)
        {
            ConnexionDB.ConnexionBdd();
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();

            string reqCount = $"SELECT COUNT(*) FROM appartements WHERE NUMAPPART = {numappart}";
            objCmd.CommandText = reqCount;
            int nbAppartements = Convert.ToInt32(objCmd.ExecuteScalar());

            return (nbAppartements > 0);
        }
        public static List<Appartements> AfficherAppartementsCourteDuree()
        {
            List<Appartements> appartementsCourteDuree = new List<Appartements>();
            try
            {
                ConnexionDB.ConnexionBdd();

                MySqlCommand objCmd;
                objCmd = ConnexionDB.conn.CreateCommand();

                // Récupérer les appartements ayant une courte durée
                string reqQueryAppartements = "SELECT * FROM appartements WHERE courtduree = 1 AND typappart IN ('F1', 'F2')";
                objCmd.CommandText = reqQueryAppartements;
                MySqlDataReader objReader = objCmd.ExecuteReader();

                while (objReader.Read())
                {
                    int numAppart = objReader.GetInt32(0);
                    string typAppart = objReader.GetString(1);
                    decimal prixLoc = objReader.GetDecimal(2);
                    decimal prixCharg = objReader.GetDecimal(3);
                    string rue = objReader.GetString(4);
                    int arrondissement = objReader.GetInt32(5);
                    int etage = objReader.GetInt32(6);
                    int ascenseur = objReader.GetInt32(7);
                    int preavis = objReader.GetInt32(8);
                    DateTime dateLibre = objReader.GetDateTime(9);
                    int courtDuree = objReader.GetInt32(10);
                    int numeroProp = objReader.GetInt32(11);
                    int numeroLoc = objReader.GetInt32(12);

                    Appartements appartement = new Appartements(numAppart, typAppart, prixLoc, prixCharg, rue, arrondissement, etage, ascenseur, preavis, dateLibre, courtDuree, numeroProp, numeroLoc);
                    appartementsCourteDuree.Add(appartement);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors de la récupération des appartements : {e.Message}");
            }
            return appartementsCourteDuree;
        }







    }
}
