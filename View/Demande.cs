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
    public partial class Demande : Form
    {
        public Demande()
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
        
        }

        private void FormPanier_Load(object sender, EventArgs e)
        {
            // ... autres instructions ...

            // Ajouter l'événement SelectedIndexChanged à la ListBox ListDemandes
            ListDemandes.SelectedIndexChanged += new EventHandler(ListDemandes_SelectedIndexChanged);

            // ... autres instructions ...
        }

        private void ListPanier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnregistrerFormulaire_Click(object sender, EventArgs e)
        {
            // Vérifier si un client est connecté
            if (Users_Controller.GlobalVariables.UtilisateurConnecte == null)
            {
                MessageBox.Show("Vous devez vous connecter avant de pouvoir faire une demande");
                return;
            }

            // Récupérer les valeurs saisies par l'utilisateur
            // Vérifier que les champs numériques sont bien remplis
            int num_dem;
            if (!int.TryParse(txtNumDem.Text, out num_dem))
            {
                MessageBox.Show("Le numéro de demande doit être un nombre entier.");
                return;
            }
            int arrondissement;
            if (!int.TryParse(txtArrondissement.Text, out arrondissement))
            {
                MessageBox.Show("L'arrondissement doit être un nombre entier.");
                return;
            }

            // Récupérer les valeurs saisies par l'utilisateur
            string type_dem = txtTypeDem.Text;
            DateTime dateLimite = dtpDateLimite.Value;

            // Vérifier que les dates de début et de fin de location sont valides
            DateTime dateDebut = dtpdatedebut.Value;
            DateTime dateFin = dtpdatefin.Value;
            int nbJours;
            if (dateDebut >= dateFin || !int.TryParse(txtnbjours.Text, out nbJours) || nbJours <= 0)
            {
                MessageBox.Show("La durée de la location doit être d'au moins un jour et la date de début doit être antérieure à la date de fin.");
                return;
            }

            // Récupérer le client connecté et son numéro
            Adherent adherent = Users_Controller.GlobalVariables.UtilisateurConnecte;
            Client client = new Client(adherent.num_cli, adherent.nom, adherent.prenom, adherent.adresse, adherent.code_ville, adherent.tel);

            //Vérifier si le numéro de demande existe déjà en base de données
            if (DemandeDAO.DemandeExist(num_dem))
            {
                MessageBox.Show("Le numéro de demande existe déjà, veuillez en choisir un autre.");
                return;
            }

            // Créer une instance de Demande_modele avec les valeurs saisies
            Demande_modele nouvelleDemande = new Demande_modele(client, type_dem, num_dem, arrondissement, dateLimite, nbJours, dateDebut,dateFin);

            // Ajouter la nouvelle demande à la base de données
            DemandeDAO.AjouterDemande(client, type_dem, num_dem, dateLimite, arrondissement, nbJours, dateDebut,dateFin);

            // Afficher un message de confirmation
            MessageBox.Show("La demande a été ajoutée avec succès !");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Vérifier si un client est connecté
            if (Users_Controller.GlobalVariables.UtilisateurConnecte == null)
            {
                MessageBox.Show("Vous devez vous connecter avant de pouvoir afficher vos demandes");
                return;
            }

            // Récupérer le client connecté
            Adherent adherent = Users_Controller.GlobalVariables.UtilisateurConnecte;
            Client client = new Client(adherent.num_cli, adherent.nom, adherent.prenom, adherent.adresse, adherent.code_ville, adherent.tel);

            // Récupérer les demandes du client connecté
            List<Demande_modele> demandes = DemandeDAO.GetDemandesDuClient(client);

            // Vider la ListBox
            ListDemandes.Items.Clear();

            // Vérifier si le client a des demandes enregistrées
            if (demandes.Count == 0)
            {
                MessageBox.Show("Vous n'avez pas de demande enregistrée");
                return;
            }

            // Ajouter les demandes à la ListBox
            foreach (Demande_modele demande in demandes)
            {
                ListDemandes.Items.Add(demande);
            }

            // Personnaliser l'affichage des demandes dans la ListBox
            ListDemandes.DisplayMember = "ToString";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Vérifier si une demande est sélectionnée dans la liste
            if (ListDemandes.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une demande à supprimer");
                return;
            }

            // Récupérer la demande sélectionnée
            Demande_modele demande = (Demande_modele)ListDemandes.SelectedItem;

            // Supprimer la demande de la base de données
            DemandeDAO.SupprimerDemande(demande.GetNumDem());

            // Supprimer la demande de la liste
            ListDemandes.Items.Remove(demande);

            // Afficher un message de confirmation
            MessageBox.Show("La demande a été supprimée avec succès !");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Vérifier si une demande est sélectionnée dans la liste
            if (ListDemandes.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une demande à modifier");
                return;
            }

            // Récupérer la demande sélectionnée
            Demande_modele demande = (Demande_modele)ListDemandes.SelectedItem;

            // Récupérer les nouvelles informations depuis les champs de saisie
            string typeDemande = txtTypeDem.Text;
            int arrondissement = Convert.ToInt32(txtArrondissement.Text);
            DateTime dateLimite = dtpDateLimite.Value;

            // Mettre à jour les propriétés de l'objet demande avec les nouvelles valeurs
            demande.SetTypeDemande(typeDemande);
            demande.SetArrondissement(arrondissement);
            demande.SetDateLimite(dateLimite);

            // Modifier la demande dans la base de données
            DemandeDAO.ModifierDemande(demande.GetNumDem(), typeDemande, arrondissement, dateLimite);

           

            // Afficher un message de confirmation
            MessageBox.Show("La demande a été modifiée avec succès !");
        }

        private void ListDemandes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vérifier si une demande est sélectionnée dans la liste
            if (ListDemandes.SelectedItem == null)
            {
                return;
            }

            // Récupérer la demande sélectionnée
            Demande_modele demande = (Demande_modele)ListDemandes.SelectedItem;

            // Mettre à jour les champs de saisie avec les informations de la demande sélectionnée
            txtNumDem.Text = demande.GetNumDem().ToString();
            txtTypeDem.Text = demande.GetTypeDem();
            txtArrondissement.Text = demande.GetArrondissement().ToString();
            dtpDateLimite.Value = demande.GetDateLimite();
        }

        private void txtnbjours_TextChanged(object sender, EventArgs e)
        {

        }
    }
}