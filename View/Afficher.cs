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
    public partial class Afficher : Form
    {
        public Afficher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnexionDB.ConnexionBdd();
            List<Client> LesClients = ClientDAO.GetLesClients();
            ListAdherent.Items.Clear();
            ListAdherent.Items.AddRange(LesClients.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnexionDB.ConnexionBdd();
            List<Proprietaire_modele> LesProprietaires = ProprietaireDAO.GetLesProprietaires();
            ListAdherent.Items.Clear();
            ListAdherent.Items.AddRange(LesProprietaires.ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConnexionDB.ConnexionBdd();
            List<Locataire_modele> LesLocataires = LocataireDAO.GetLesLocataires();
            ListAdherent.Items.Clear();
            ListAdherent.Items.AddRange(LesLocataires.ToArray());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            // Vérifier si un adhérent est sélectionné dans la liste
            if (ListAdherent.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un client à supprimer");
                return;
            }

            // Récupérer le numéro de l'adhérent à supprimer
            int num_cli = ((Client)ListAdherent.SelectedItem).GetNum();

            // Supprimer l'adhérent de la base de données
            ClientDAO.SupprimerClient(num_cli);

            // Supprimer l'adhérent de la liste
            ListAdherent.Items.Remove(ListAdherent.SelectedItem);

            // Afficher un message de confirmation
            MessageBox.Show("Le client a été supprimé avec succès !");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
