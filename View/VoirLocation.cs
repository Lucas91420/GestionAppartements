using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using gestiondeappartement.Modèle;
using gestiondeappartement.Controller;

namespace gestiondeappartement
{
    public partial class VoirLocation : Form
    {
        public VoirLocation()
        {
            InitializeComponent();
           
        }

        private void btnPanierRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPanierSupprimer_Click(object sender, EventArgs e)
        {
       
        }

        private void btnPaiement_Click(object sender, EventArgs e)
        {
            int numeroloc = Users_Controller.GlobalVariables.UtilisateurConnecte.numeroloc ;
            MessageBox.Show($"Numéro de locataire: {numeroloc}");
            List<Appartements> appartements = LocataireDAO.GetAppartementsByNumeroLoc(numeroloc);



            // Effacer le contenu de la ListBox
            ListLocation.Items.Clear();

            // Parcourir la liste d'appartements et ajouter chaque appartement à la ListBox
            foreach (Appartements appartement in appartements)
            {
                ListLocation.Items.Add(appartement.ToString());
            }
        }

        private void FormPanier_Load(object sender, EventArgs e)
        {

        }

        private void ListPanier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
