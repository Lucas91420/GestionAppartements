using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using gestiondeappartement.Modèle;
using gestiondeappartement.Controller;
using static gestiondeappartement.Modèle.AdherentDAO;


namespace gestiondeappartement
{
    public partial class FormLoc : Form
    {
        public FormLoc()
        {
            InitializeComponent();
            List<Appartements> LesAppartements = AppartementDAO.LesAppartements;
            ListChoixAppartements.Items.Clear();
            ListChoixAppartements.Items.AddRange(LesAppartements.ToArray());
        }
        

        private void btnPanierRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void btnPanierSupprimer_Click(object sender, EventArgs e)
        {
            Article a = (Article)ListPanier.SelectedItem;
            if (a == null)
            {
                MessageBox.Show("Veuillez selectionné un article a supprimer");
            }
            else
            {
                    foreach (Article art in ORMComptes.Panier)
                    {
                        if (art.GetRefprod().Equals(a.GetRefprod()))
                        {
                             ORMComptes.Panier.Remove(art);
                             break;
                        }
                    }   
                Article b = (Article)ListPanier.SelectedItem;
                if (ListPanier.SelectedIndex > -1)
                    ListPanier.Items.RemoveAt(ListPanier.SelectedIndex);
                else
                    MessageBox.Show("Veuillez selectionné un article a supprimer");
            }
        }
        */

        private void btnPaiement_Click(object sender, EventArgs e)
        {
           
        }

        private void FormPanier_Load(object sender, EventArgs e)
        {

        }

        private void ListPanier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPanierSupprimer_Click(object sender, EventArgs e)
        {
            Appartements a = (Appartements)ListChoixAppartements.SelectedItem;
            if (a == null)
            {
                MessageBox.Show("Veuillez selectionné un appartement a supprimer");
            }
            else
            {
                foreach (Appartements art in AppartementDAO.LesAppartements)
                {
                    if (art.GetNumAppart().Equals(a.GetNumAppart()))
                    {
                        AppartementDAO.LesAppartements.Remove(art);
                        break;
                    }
                }
                Appartements b = (Appartements)ListChoixAppartements.SelectedItem;
                if (ListChoixAppartements.SelectedIndex > -1)
                    ListChoixAppartements.Items.RemoveAt(ListChoixAppartements.SelectedIndex);
                else
                    MessageBox.Show("Veuillez selectionné un appartement a supprimer");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vérifier si un appartement est sélectionné dans la liste
            if (ListChoixAppartements.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un appartement à visiter");
                return;
            }

            // Vérifier si une date a été sélectionnée
            if (dtpVisite.Value == null)
            {
                MessageBox.Show("Veuillez sélectionner une date pour la visite");
                return;
            }

            // Récupérer l'appartement sélectionné
            Appartements appartement = (Appartements)ListChoixAppartements.SelectedItem;

            // Récupérer le client connecté
            Adherent adherent = Users_Controller.GlobalVariables.UtilisateurConnecte;
            Client client = new Client(adherent.num_cli, adherent.nom, adherent.prenom, adherent.adresse, adherent.code_ville, adherent.tel);

            // Vérifier si une visite pour cet appartement à cette date existe déjà
            if (ClientDAO.VisiteExiste(appartement, dtpVisite.Value))
            {
                MessageBox.Show("Une visite pour cet appartement à cette date existe déjà.");
                return;
            }

            // Ajouter la visite à la base de données
            ClientDAO.AjouterVisite(appartement, client, dtpVisite.Value);

            MessageBox.Show("La visite a été ajoutée avec succès !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Vérifier si un client est connecté
            if (Users_Controller.GlobalVariables.UtilisateurConnecte == null)
            {
                MessageBox.Show("Vous devez vous connecter avant de pouvoir afficher vos visites");
                return;
            }

            // Récupérer le client connecté
            Adherent adherent = Users_Controller.GlobalVariables.UtilisateurConnecte;
            Client client = new Client(adherent.num_cli, adherent.nom, adherent.prenom, adherent.adresse, adherent.code_ville, adherent.tel);

            // Récupérer les visites du client connecté
            List<Visite_modele> visites = VisiteDAO.GetVisitesDuClient(client);

            // Vider la ListBox
            ListVisites.Items.Clear();

            // Ajouter les visites à la ListBox
            foreach (Visite_modele visite in visites)
            {
                ListVisites.Items.Add(visite);
            }

            // Personnaliser l'affichage des visites dans la ListBox
            ListVisites.DisplayMember = "ToString";
        }
    }
}
