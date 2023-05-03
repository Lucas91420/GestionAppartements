using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace gestiondeappartement.Modèle
{
    class VisiteDAO
    {
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

    }
}
