using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace gestiondeappartement.Modèle
{
    class DemandeDAO
    {
        public void InsertDemande(int num_dem, Client client, string type_dem, DateTime date_limite)
        {
            ConnexionDB.ConnexionBdd();
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();
            string reqQuery = "INSERT INTO demandes (NUM_DEM, NUM_CLI, TYPE_DEM, DATE_LIMITE) VALUES (@num_dem, @numClient, @type_dem, @date_limite)";
            objCmd.CommandText = reqQuery;
            objCmd.Parameters.AddWithValue("@num_dem", num_dem);
            objCmd.Parameters.AddWithValue("@numClient", client.GetNum());
            objCmd.Parameters.AddWithValue("@type_dem", type_dem);
            objCmd.Parameters.AddWithValue("@date_limite", date_limite.ToString("yyyy-MM-dd"));
            objCmd.ExecuteNonQuery();
        }
        public void InsertConcerne(int num_dem, string arrondissement)
        {
            ConnexionDB.ConnexionBdd();
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();
            string reqQuery = "INSERT INTO concerne (NUM_DEM, ARRONDISS_DEM) VALUES (@num_dem, @arrondissement)";
            objCmd.CommandText = reqQuery;
            objCmd.Parameters.AddWithValue("@num_dem", num_dem);
            objCmd.Parameters.AddWithValue("@arrondissement", arrondissement);
            objCmd.ExecuteNonQuery();
        }
        /*public static void AjouterDemande(Client client, string type_dem, int num_dem, DateTime date_limite, int arrondissement)
        {
            ConnexionDB.ConnexionBdd();
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();
            string reqQuery = "INSERT INTO demandes (NUM_DEM, NUM_CLI, TYPE_DEM, DATE_LIMITE) VALUES (@num_dem, @numClient, @type_dem, @date_limite)";
            objCmd.CommandText = reqQuery;
            objCmd.Parameters.AddWithValue("@num_dem", num_dem);
            objCmd.Parameters.AddWithValue("@numClient", client.GetNum());
            objCmd.Parameters.AddWithValue("@type_dem", type_dem);
            objCmd.Parameters.AddWithValue("@date_limite", date_limite);
            objCmd.ExecuteNonQuery();

            // Ensuite, on ajoute l'arrondissement dans la table "concerne"
            string reqQuery2 = "INSERT INTO concerner (NUM_DEM, ARRONDISS_DEM) VALUES (@num_dem, @arrondissement)";
            objCmd.CommandText = reqQuery2;
            objCmd.Parameters.AddWithValue("@arrondissement", arrondissement);
            objCmd.ExecuteNonQuery();
        }*/
        public static void AjouterDemande(Client client, string type_dem, int num_dem, DateTime date_limite, int arrondissement, int nbjours, DateTime datedebut, DateTime datefin)
        {
            ConnexionDB.ConnexionBdd();
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();
            string reqQuery = "INSERT INTO demandes (NUM_DEM, NUM_CLI, TYPE_DEM, DATE_LIMITE, NBJOURS, DATEDEBUT, DATEFIN) VALUES (@num_dem, @numClient, @type_dem, @date_limite, @nbjours, @datedebut, @datefin)";
            objCmd.CommandText = reqQuery;
            objCmd.Parameters.AddWithValue("@num_dem", num_dem);
            objCmd.Parameters.AddWithValue("@numClient", client.GetNum());
            objCmd.Parameters.AddWithValue("@type_dem", type_dem);
            objCmd.Parameters.AddWithValue("@date_limite", date_limite);
            objCmd.Parameters.AddWithValue("@nbjours", nbjours);
            objCmd.Parameters.AddWithValue("@datedebut", datedebut);
            objCmd.Parameters.AddWithValue("@datefin", datefin);
            objCmd.ExecuteNonQuery();

            // Ensuite, on ajoute l'arrondissement dans la table "concerne"
            string reqQuery2 = "INSERT INTO concerner (NUM_DEM, ARRONDISS_DEM) VALUES (@num_dem, @arrondissement)";
            objCmd.CommandText = reqQuery2;
            objCmd.Parameters.AddWithValue("@arrondissement", arrondissement);
            objCmd.ExecuteNonQuery();
        }

        public static bool DemandeExist(int num_dem)
        {
            ConnexionDB.ConnexionBdd();
            MySqlCommand objCmd = ConnexionDB.conn.CreateCommand();
            objCmd.CommandText = "SELECT COUNT(*) FROM demandes WHERE NUM_DEM = @num_dem";
            objCmd.Parameters.AddWithValue("@num_dem", num_dem);
            int count = Convert.ToInt32(objCmd.ExecuteScalar());
            return count > 0;
        }
        /*public static List<Demande_modele> GetDemandesDuClient(Client client)
        {
            ConnexionDB.ConnexionBdd();
            MySqlCommand objCmd = ConnexionDB.conn.CreateCommand();
            objCmd.CommandText = "SELECT demandes.NUM_DEM, demandes.TYPE_DEM, demandes.DATE_LIMITE, concerner.ARRONDISS_DEM FROM demandes INNER JOIN concerner ON demandes.NUM_DEM = concerner.NUM_DEM WHERE demandes.NUM_CLI = @numCli";
            objCmd.Parameters.AddWithValue("@numCli", client.GetNum());
            MySqlDataReader objReader = objCmd.ExecuteReader();
            List<Demande_modele> listeDemandes = new List<Demande_modele>();
            while (objReader.Read())
            {
                int num_dem = objReader.GetInt32("NUM_DEM");
                string type_dem = objReader.GetString("TYPE_DEM");
                DateTime date_limite = objReader.GetDateTime("DATE_LIMITE");
                int arrondissement = objReader.GetInt32("ARRONDISS_DEM");
                Demande_modele demande = new Demande_modele(client, type_dem, num_dem, arrondissement, date_limite);
                listeDemandes.Add(demande);
            }
            objReader.Close();
            return listeDemandes;
        }*/
        public static List<Demande_modele> GetDemandesDuClient(Client client)
        {
            ConnexionDB.ConnexionBdd();
            MySqlCommand objCmd = ConnexionDB.conn.CreateCommand();
            objCmd.CommandText = "SELECT demandes.NUM_DEM, demandes.TYPE_DEM, demandes.DATE_LIMITE, concerner.ARRONDISS_DEM, demandes.NBJOURS, demandes.DATEDEBUT, demandes.DATEFIN FROM demandes INNER JOIN concerner ON demandes.NUM_DEM = concerner.NUM_DEM WHERE demandes.NUM_CLI = @numCli ";
            objCmd.Parameters.AddWithValue("@numCli", client.GetNum());
            MySqlDataReader objReader = objCmd.ExecuteReader();
            List<Demande_modele> listeDemandes = new List<Demande_modele>();
            while (objReader.Read())
            {
                int num_dem = objReader.GetInt32("NUM_DEM");
                string type_dem = objReader.GetString("TYPE_DEM");
                DateTime date_limite = objReader.GetDateTime("DATE_LIMITE");
                int arrondissement = objReader.GetInt32("ARRONDISS_DEM");
                int nbjours = objReader.GetInt32("NBJOURS");
                DateTime datedebut = objReader.GetDateTime("DATEDEBUT");
                DateTime datefin = objReader.GetDateTime("DATEFIN");
                Demande_modele demande = new Demande_modele(client, type_dem, num_dem, arrondissement, date_limite, nbjours, datedebut, datefin);
                listeDemandes.Add(demande);
            }
            objReader.Close();
            return listeDemandes;
        }

        public static void SupprimerDemande(int num_dem)
        {
            ConnexionDB.ConnexionBdd();

            // Supprimer la ligne correspondante dans la table "concerne"
            MySqlCommand objCmd1 = ConnexionDB.conn.CreateCommand();
            string reqQueryConcerner = "DELETE FROM concerner WHERE NUM_DEM = @num_dem";
            objCmd1.CommandText = reqQueryConcerner;
            objCmd1.Parameters.AddWithValue("@num_dem", num_dem);
            objCmd1.ExecuteNonQuery();

            // Supprimer la ligne correspondante dans la table "demandes"
            MySqlCommand objCmd2 = ConnexionDB.conn.CreateCommand();
            string reqQueryDemandes = "DELETE FROM demandes WHERE NUM_DEM = @num_dem";
            objCmd2.CommandText = reqQueryDemandes;
            objCmd2.Parameters.AddWithValue("@num_dem", num_dem);
            objCmd2.ExecuteNonQuery();
        }
        public static void ModifierDemande(int num_dem, string type_dem, int arrondissement, DateTime date_limite)
        {
            try
            {
                ConnexionDB.ConnexionBdd();

                MySqlCommand objCmd;
                objCmd = ConnexionDB.conn.CreateCommand();

                // Modifier la demande dans la table "demandes"
                string reqQueryDemandes = "UPDATE demandes SET TYPE_DEM = @type_dem, DATE_LIMITE = @date_limite WHERE NUM_DEM = @num_dem";
                objCmd.CommandText = reqQueryDemandes;
                objCmd.Parameters.AddWithValue("@type_dem", type_dem);
                objCmd.Parameters.AddWithValue("@date_limite", date_limite);
                objCmd.Parameters.AddWithValue("@num_dem", num_dem);
                objCmd.ExecuteNonQuery();

                // Modifier la demande dans la table "concerner"
                string reqQueryConcerner = "UPDATE concerner SET ARRONDISS_DEM = @arrondissement WHERE NUM_DEM = @num_dem";
                objCmd.CommandText = reqQueryConcerner;
                objCmd.Parameters.AddWithValue("@arrondissement", arrondissement);
                objCmd.ExecuteNonQuery();

                // Afficher un message de confirmation
                Console.WriteLine("La demande a été modifiée avec succès !");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors de la modification de la demande : {e.Message}");
            }
        }






    }
}
