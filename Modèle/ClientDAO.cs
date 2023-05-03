using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;
using gestiondeappartement.Controller;

namespace gestiondeappartement.Modèle
{
    class ClientDAO
    {
        public static List<Client> LesClients = new List<Client>();

        public static List<Client> GetLesClients()
        {
            ConnexionDB.ConnexionBdd();
            List<Client> LesClients = new List<Client>();
            Client c;
            MySqlCommand objCmd;
            objCmd = ConnexionDB.conn.CreateCommand();
            string reqQuery;
            reqQuery = "Select * from clients";
            objCmd.CommandText = reqQuery;
            MySqlDataReader rdr = objCmd.ExecuteReader();
            int num_cli;
            string nom;
            string prenom;
            string adresse;
            string codeville;
            string tel;

            while (rdr.Read())
            {
                num_cli = (int)rdr["num_cli"];
                nom = (string)rdr["nom"];
                prenom = (string)rdr["prenom"];
                adresse = (string)rdr["adresse"];
                codeville = (string)rdr["codeville"];
                tel = (string)rdr["tel"];

                c = new Client(num_cli, nom, prenom, adresse, codeville, tel);
                LesClients.Add(c);
            }
            rdr.Close();
            return LesClients;
        }
        public static void SupprimerClient(int num_cli)
        {
            try
            {
                ConnexionDB.ConnexionBdd();

                MySqlCommand objCmd;
                objCmd = ConnexionDB.conn.CreateCommand();

                // Supprimer le client de la base de données
                string reqQueryClient = "DELETE FROM clients WHERE NUM_CLI = @num_cli";
                objCmd.CommandText = reqQueryClient;
                objCmd.Parameters.AddWithValue("@num_cli", num_cli);
                objCmd.ExecuteNonQuery();

                // Supprimer toutes les demandes associées au client de la base de données
                string reqQueryDemandes = "DELETE FROM demandes WHERE NUM_CLI = @num_cli";
                objCmd.CommandText = reqQueryDemandes;
                objCmd.ExecuteNonQuery();

                // Supprimer toutes les lignes de la table "concerne" associées aux demandes supprimées
                string reqQueryConcerner = "DELETE FROM concerner WHERE NUM_DEM NOT IN (SELECT NUM_DEM FROM demandes)";
                objCmd.CommandText = reqQueryConcerner;
                objCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erreur lors de la suppression du client : {e.Message}");
            }
        }
        public static void AjouterVisite(Appartements appartement, Client client, DateTime dateVisite)
        {
            try
            {
                ConnexionDB.ConnexionBdd();
                MySqlCommand objCmd;
                objCmd = ConnexionDB.conn.CreateCommand();

                // Insérer la visite dans la table "visiter"
                string reqQuery = "INSERT INTO visiter(NUM_CLI, NUMAPPART, DATE_VISITE) VALUES (@numCli, @numappart, @dateVisite)";
                objCmd.CommandText = reqQuery;
                objCmd.Parameters.AddWithValue("@numCli", client.GetNum());
                objCmd.Parameters.AddWithValue("@numappart", appartement.GetNumAppart());
                objCmd.Parameters.AddWithValue("@dateVisite", dateVisite);
                objCmd.ExecuteNonQuery();

                MessageBox.Show("La visite a été ajoutée avec succès !");
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erreur lors de l'ajout de la visite : {e.Message}");
            }
        }
        public static List<Visite_modele> GetVisitesDuClient(Client client)
        {
            List<Visite_modele> visites = new List<Visite_modele>();

            try
            {
                ConnexionDB.ConnexionBdd();

                // Récupérer les visites associées au client connecté
                string reqQueryVisites = "SELECT * FROM visiter WHERE NUM_CLI = @num_cli";
                MySqlCommand objCmd = new MySqlCommand(reqQueryVisites, ConnexionDB.conn);
                objCmd.Parameters.AddWithValue("@num_cli", client.GetNum());

                using (MySqlDataReader objReader = objCmd.ExecuteReader())
                {
                    while (objReader.Read())
                    {
                        int numappart = Convert.ToInt32(objReader["NUMAPPART"]);
                        DateTime? date_visite = objReader.IsDBNull(objReader.GetOrdinal("DATE_VISITE")) ? (DateTime?)null : Convert.ToDateTime(objReader["DATE_VISITE"]);
                        Visite_modele visite = new Visite_modele(client.GetNum(), numappart, date_visite);
                        visites.Add(visite);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erreur lors de la récupération des visites du client : {e.Message}");
            }

            return visites;
        }
        public static bool VisiteExiste(Appartements appartement, DateTime dateVisite)
        {
            bool visiteExiste = false;
            try
            {
                ConnexionDB.ConnexionBdd();

                MySqlCommand objCmd;
                objCmd = ConnexionDB.conn.CreateCommand();

                // Vérifier si une visite pour cet appartement à cette date existe déjà
                string reqQuery = "SELECT COUNT(*) FROM visiter WHERE NUM_CLI=@num_cli AND NUMAPPART=@numappart AND DATE_VISITE=@date_visite";
                objCmd.CommandText = reqQuery;
                objCmd.Parameters.AddWithValue("@num_cli", Users_Controller.GlobalVariables.UtilisateurConnecte.num_cli);
                objCmd.Parameters.AddWithValue("@numappart", appartement.GetNumAppart());
                objCmd.Parameters.AddWithValue("@date_visite", dateVisite.ToString("yyyy-MM-dd"));
                MySqlDataReader reader = objCmd.ExecuteReader();

                if (reader.Read())
                {
                    int count = Convert.ToInt32(reader[0]);
                    if (count > 0)
                    {
                        visiteExiste = true;
                    }
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erreur lors de la vérification si la visite existe déjà : {e.Message}");
            }

            return visiteExiste;
        }



    }
}
